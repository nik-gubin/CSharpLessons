using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSharp11
{
    class Program
    {
        static void Main(string[] args)
        {

            //Работа с ресурсами
            Assembly objAssembly = Assembly.GetExecutingAssembly();
            ResourceManager objResourceManage = Resource1.ResourceManager;
            // new ResourceManager("Resource1", objAssembly);
            string str = objResourceManage.GetString("const1");
            //string str = Resource1.const1;
            Console.WriteLine(str);

            //создание xml файла
            string FileName = "D:\\Phone.xml";
            XmlTextWriter Writer = new XmlTextWriter(FileName, null);
            Writer.Formatting = Formatting.Indented;
            Writer.Indentation = 5;
            Writer.WriteStartDocument();

            Writer.WriteStartElement("PhoneBook");
            Writer.WriteAttributeString("id", "b001");

            Writer.WriteStartElement("Name");
            Writer.WriteString("David");
            Writer.WriteEndElement();

            Writer.WriteStartElement("Numbers");
            Writer.WriteStartElement("Number");
            Writer.WriteString("123456787654");
            Writer.WriteEndElement();
            Writer.WriteStartElement("Number");
            Writer.WriteString("123456787654");
            Writer.WriteEndElement();
            Writer.WriteElementString("Number", "23443252523");
            Writer.WriteEndElement();

            Writer.WriteStartElement("City");
            Writer.WriteString("New York");
            Writer.WriteEndElement();

            Writer.WriteEndElement();

            Writer.WriteEndDocument();
            Writer.Flush();
            Writer.Close();

            //Чтение данных из XML файла
            //  String FileName = "D:\\Phone.xml";
            XmlTextReader Reader = new XmlTextReader(FileName);
            while (Reader.Read())
            {
                if (Reader.NodeType == XmlNodeType.Element)
                {
                   // Console.WriteLine("{0} {1}.", Reader.LocalName, Reader.ReadString());
                    if (Reader.LocalName == "Name")
                    {
                        Console.WriteLine("The Phone numbers of {0} is", Reader.ReadString());
                    }
                    if (Reader.LocalName == "Number")
                    {
                        Console.WriteLine("\t"+Reader.ReadString());
                    }
                }
            }
            Reader.Close();

            //Работа с XML через DOM
            XmlDocument document = new XmlDocument();
            document.Load("D:\\Phone.xml");
            XmlNode rootNode = document.DocumentElement;
            Console.WriteLine(rootNode.Name);

            XmlNodeList phones = rootNode.ChildNodes;

            foreach (XmlNode p in phones)
            {
                if (p.Name=="Numbers")
                {
                    Console.WriteLine("\tNumbers");
                    foreach (XmlNode n in p.ChildNodes)
                    {
                        Console.WriteLine("\t\t{0} {1}", n.Name, n.InnerText);
                    }

                    XmlElement newNumber = document.CreateElement("Number");
                    newNumber.InnerText = "1-2-3-4-56-7";
                    p.AppendChild(newNumber);
                }else
                Console.WriteLine("\t{0} {1}",p.Name,p.InnerText);
            }

            //ПОиск элементов, используя XPath
            Console.WriteLine("XPath");
            XmlNodeList numbers = rootNode.SelectNodes("//Number");
            foreach (XmlNode n in numbers)
            {
               
                Console.WriteLine("{0}", n.Name);
                
            }

            //Добавление элементов в XML
            XmlElement NewFriendsName = document.CreateElement("Name");
            NewFriendsName.InnerText = "Dorsan";
            document.DocumentElement.InsertAfter(NewFriendsName, document.DocumentElement.LastChild);

            //Добавление элементов в XML
            XmlElement NewFriendsNumber = document.CreateElement("Number");
            NewFriendsNumber.InnerText = "21324354";
            document.DocumentElement.InsertAfter(NewFriendsNumber, document.DocumentElement.LastChild);

            //Добавление элементов в XML
            XmlElement NewFriendsCity = document.CreateElement("City");
            NewFriendsCity.InnerText = "Sydney";
            document.DocumentElement.InsertAfter(NewFriendsCity, document.DocumentElement.LastChild);

            //Сохранение изменений в XML-Файл
            document.Save("D:\\Phone.xml");
        }
    }
}
