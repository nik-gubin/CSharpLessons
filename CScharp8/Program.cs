using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    class Program
    {
        static void Main(string[] args)
        {

            //тестировние обобщенного класс. Работает только с типом string
            Console.WriteLine("----General string----");
            General<string> objGeneral = new General<string>(3);
            objGeneral.Add("John");
            objGeneral.Add("Patrick");
            objGeneral.Display();


            //тестировние обобщенного класс. Работает только с типом int
            Console.WriteLine("\n----General int----");
            General<int> objGeneral2 = new General<int>(2);
            objGeneral2.Add(200);
            objGeneral2.Add(35);
            objGeneral2.Display();


            //тестировние обобщенного класс. Работает только с типом Student
            Console.WriteLine("\n----General student----");
            General<Student> stdGenaral = new General<Student>(3);
            stdGenaral.Add(new Student { Group = "Групаа 1", Name = "Иван" });
            stdGenaral.Add(new Student { Group = "Групаа 12", Name = "Иван 2" });
            stdGenaral.Add(new Student { Group = "Групаа 121", Name = "Иван 3" });
            stdGenaral.Display();

            //нетипизированный динамический массив
            Console.WriteLine("\n----ArrayList----");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("stygh");
            arrayList.Add(new object());
            arrayList.Add(true); ;
            arrayList.Add(1.0f);
            arrayList.Add(1.0);

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine("{0}", arrayList[i]);
                if (arrayList[i] is string)
                {
                    Console.WriteLine(((string)arrayList[i]).ToUpper());
                }
            }

            //типизированный динамический массив типов int
            Console.WriteLine("\n----List int----");
            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(2);


            //типизированный динамический массив типов Student
            Console.WriteLine("\n----List Student----");
            List<Student> students = new List<Student>();
            students.Add(new Student { Group = "Групаа 1", Name = "Иван" });
            students.Add(new Student { Group = "Групаа 12", Name = "Иван 2" });
            LinkedList<string> linkedList = new LinkedList<string>();


            //нетипизированный словарь
            Console.WriteLine("\n----Hashtable----");
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Ivan", new Student { Group = "Групаа 1", Name = "Иван" });
            hashtable.Add("Ivan1", new Student { Group = "Групаа 112", Name = "Иван2" });
            hashtable.Add("Ivan2", new Student { Group = "Групаа 121", Name = "Иван3" });
            hashtable.Add("Ivan3", new Student { Group = "Групаа 231", Name = "Иван4" });

            hashtable[new object()] = new Student { Group = "Групаа 231", Name = "Иван42" };
            hashtable[21] = new Student { Group = "Групаа 231", Name = "Иван42" };
            hashtable[32] = new Student { Group = "Групаа 231", Name = "Иван42" };

            hashtable.Remove("Ivan1");
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine("{0} = {1}", item.Key, item.Value);
            }

            //нетипизированный отсортированный словарь по ключам
            Console.WriteLine("\n----SortedList----");
            SortedList sortedList = new SortedList(new ReversoSort());
            sortedList.Add("Ivan", new Student { Group = "Групаа 1", Name = "Иван" });
            sortedList.Add("Ivan1", new Student { Group = "Групаа 112", Name = "Иван2" });
            sortedList.Add("Ivan2", new Student { Group = "Групаа 121", Name = "Иван3" });
            sortedList.Add("Ivan3", new Student { Group = "Групаа 231", Name = "Иван4" });
            sortedList["Ivan3"] = null;
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine("{0} = {1}", item.Key, item.Value);
            }

            //типизированный словарь 
            Console.WriteLine("\n----Dictionary----");
            Dictionary<int, Student> dictionary = new Dictionary<int, Student>();
            dictionary.Add(231, new Student { Group = "Групаа 1", Name = "Иван" });
            dictionary.Add(23231, new Student { Group = "Групаа 1", Name = "Иван 1" });
            dictionary.Add(212131, new Student { Group = "Групаа 1", Name = "Иван 2" });
            dictionary.Add(21231, new Student { Group = "Групаа 1", Name = "Иван 2" });
            if (dictionary.ContainsKey(231))
            {
                dictionary[231].Group = "Group 213";
            }
            foreach (KeyValuePair<int, Student> item in dictionary)
            {
                Console.WriteLine("{0} = {1}", item.Key, item.Value.Group);
            }


            //типизированный отсортированное множество 
            Console.WriteLine("\n----SortedSet----");
            SortedSet<Student> sortedSet = new SortedSet<Student>();
            sortedSet.Add(new Student { Group = "Групаа 11", Name = "Иван" });
            sortedSet.Add(new Student { Group = "Групаа 21", Name = "Иван 1" });
            sortedSet.Add(new Student { Group = "Групаа 11", Name = "Иван 2" });
            foreach (Student item in sortedSet)
            {
                Console.WriteLine("{0} = {1}", item.Group, item.Name);
            }
        }
    }
}
