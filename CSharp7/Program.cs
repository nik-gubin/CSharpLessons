using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 133;
            int numTwo = 0;
            int result;
            int[] arr = new int[5];

            //механизv отлова исключений
            try
            {
                object o = new object();
                string s1 = (string)o;
                // arr[5] = 9;
                result = numOne / numTwo;
            }
            //обработка деления на ноль
            catch (DivideByZeroException objDivide)
            {
                Console.WriteLine("Exception caught: {0}", objDivide);
            }
            //обработка выхода за пределы массива
            catch (IndexOutOfRangeException)
            {

                Console.WriteLine("Вышли за пределы массива");
            }
            //обработка всех остальных исключений
            catch
            {
                Console.WriteLine("Все исключения");
            }
            //блок, который выполняется всегда
            finally
            {
                Console.WriteLine("Finally excute");
                int c = 0;
                // int i = 1 / c;
                //return 0;
            }

            //тестирование собственных исключений
            Student s = new Student("Иван");
            try
            {
                s.Add("группа 1");
            }
            catch (StudentException e)
            {

                Console.WriteLine(e);
            }

            //тестирование свойств
            s.Birthday = new DateTime(1990, 1, 1);
            s.Name = "Сергей"; //s.Age = 10;
            s.Lastname = "Сергеев";
            s.Surname = "Сергеевевич121221";
            Console.WriteLine("{0}, {1}, {2}", s.Name, s.Age, s.Surname);

            //тестирование индексаторов
            EmployeeDetails empl = new EmployeeDetails();

            //empl[0] = "Имя 1";
            //empl[1] = "Имя 2";

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(empl[i]);
            }

        }

        public static int m()
        {
            try
            {
                return 1;
            }
            catch (Exception)
            {
                return 2;
            }
            finally
            {
                int c = 0;
                int i = 1 / c;
            }
        }
    }

    

 

 
}
