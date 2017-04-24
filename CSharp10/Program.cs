using StudentNameSpace;
using StudentNameSpace.Predodavatel.SSTU;
using human = Human.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            human p1 = new human();
            Propod pr = new Propod();


            //Запись и чтние занных в файл
            BinaryWriter objBinaryWrite = new BinaryWriter(File.Create("D:/Test.bin"));
            byte b = 45;
            string str1 = "Billy";
            objBinaryWrite.Write(b);
            objBinaryWrite.Write(str1);
            objBinaryWrite.Close();

            //чтение из файла
            BinaryReader objBinaryRead = new
            BinaryReader(File.OpenRead("d:/Test.bin"));
            Byte b2 = objBinaryRead.ReadByte();
            string str2 = objBinaryRead.ReadString();
            Console.WriteLine(str2);
            Console.WriteLine(b2);
            objBinaryRead.Close();

            //Запись и чтение из потоков (данные находятся в оперативной памяти)
            MemoryStream objMemStr = new MemoryStream();
            BufferedStream objBuffStr = new BufferedStream(objMemStr);
            objBuffStr.WriteByte((byte)100);
            objBuffStr.WriteByte((byte)100);

            objBuffStr.Position = 0;
            byte[] Arr = { 1, 2, 3 };
            objBuffStr.Read(Arr, 0, Arr.Length);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("The value is {0}", Arr[i]);
            }
            Console.WriteLine("The return value for ReadByte() is {0}", objBuffStr.ReadByte());


            //работа с файлами
            string path = @"D:\NewFile.txt";
            try
            {
                //Create a FileInfo object
                FileInfo objFileInfo = new FileInfo(@"D:\test.txt");
                //Create the file
                FileStream objFileStream = objFileInfo.Create();
                //Prepare to write text to file
                Byte[] info = new UTF8Encoding(true).GetBytes("This file was programmatically created using C#");
                //Write the data
                objFileStream.Write(info, 0, info.Length);
                //Flush and close the FileStream
                objFileStream.Flush();
                objFileStream.Close();


                //Copy the file
                objFileInfo.CopyTo(@"D:\My Documents", true);
                Console.WriteLine(@"{0} Copied to D:\MyDocuments", path);

                //Display the file creation time
                Console.WriteLine("{0} was created on {1}", path, objFileInfo.CreationTime.ToString());
                //Display the file last accessed time
                Console.WriteLine("{0} was last accessed on {1}", path, objFileInfo.LastAccessTime.ToString());
                //Display the file last written to time
                Console.WriteLine("{0} was last written to on {1}", path, objFileInfo.LastWriteTime.ToString());
                //Delete the file
                objFileInfo.Delete();

            }
            catch (Exception ex) { Console.WriteLine(ex); }

            //работа каталогами
            try
            {
                //Set source and destination paths
                string path1 = @"D:\Student";
                string destPath = @"D:\NewStudent";
                //Create a DirectoryInfo object
                DirectoryInfo di = new DirectoryInfo(path1);
                //Create the Directory
                di.Create();
                Console.WriteLine("{0} created on {1}", path1, di.CreationTime.ToString());
                //Move the Directory
                di.MoveTo(destPath);
                Console.WriteLine("{0} moved to {1}", path1, destPath);
                //Delete the directory
                di.Delete();
                Console.WriteLine("{0} has been deleted.", destPath);

                DirectoryInfo cdir = new DirectoryInfo("C:\\");
                DirectoryInfo[] dirs = cdir.GetDirectories();

                FileInfo[] files = cdir.GetFiles();

                Console.WriteLine(cdir.Name);
                foreach (DirectoryInfo d in dirs)
                {

                    Console.WriteLine("\t" + d.Name);
                }
                foreach (FileInfo f in files)
                {

                    Console.WriteLine("\t {0} {1} {2}", f.Name, f.CreationTime, f.LastWriteTime);
                }

                FileInfo fl = new FileInfo("D:\\test.txt");
                FileStream fs = fl.Create();
                fs.Close();
                fl.CreationTime = new DateTime(1990, 1, 31);
                fl.LastAccessTime = new DateTime(1990, 1, 31);
                fl.LastAccessTime = new DateTime(1990, 1, 31);
                fl.IsReadOnly = true;

            }
            catch (Exception ex) { Console.WriteLine(ex); }



        }
    }
}
