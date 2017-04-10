using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //создание экземпляра класса student
            Student s1 = new Student("Name ", 18);
            //вызов метода у объекта s1
            s1.Display();
            //вызов метода у объекта s1
            s1.PervodGroup("Testing");
            //вызов метода у объекта s1
            s1.Display();

            for (int i = 0; i < 10; i++)
            {
                //вызов метода у объекта s1
                float avg = s1.AvgDegree();
                Console.WriteLine("Семестр {0}. Средний балл: \t{1}", i + 1, avg);
            }
            //создание экземпляра класса student
            Student s2 = new Student("Name ", 18);
            //создание экземпляра класса student
            Student s4 = new Student("Name ", 18, "", 0, "");
            //создание экземпляра класса student
            Student s5 = new Student("Pert", 22);
            //создание экземпляра класса student
            Student s3 = new Student();
            //"удаление" объекта s5
            s5 = null;

            //демострация автоматического удаление объекта из памяти
            while (true) {
                if (Console.ReadLine()=="q")
                {
                    break;
                }
                for (int i = 0; i < 1000; i++)
                {

                    s1 = new Student();
                }
                Console.ReadLine();
                Console.WriteLine();
                s3.Display();
            }
        }


        //статический конструктор класса Program
        static Program()
        {
            Console.WriteLine("Load class program");
        }
    }
}
