using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CSharp4;

namespace CSharp3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int numOne = 10;
            int numTwo = 20;
            Console.WriteLine("Value of Num1 and Num2 before calling method {0}, {1}", numOne, numTwo);
            Calculate(ref numOne, ref numTwo);
            Console.WriteLine("Value of Num1 and Num2 after calling method {0}, {1}", numOne, numTwo);


            int value = 200;
            Depreciation(out value);
            Console.WriteLine(value);

            int a = 1;
            int b = 2;
            int c;
            float avg;
            object o = new object();
            Console.WriteLine(o.GetHashCode());
            c = Add(a, b, out avg, ref o);
            Console.WriteLine(o.GetHashCode());
            Console.WriteLine("{0}+{1}={2}\n{3}", a, b, c, avg);


            bool bp = int.TryParse("12", out a);

            //int[] count = new int[10] { 1,32,23,32,23,324,324,3,234,234};
            //int[] count = { 1, 32, 23, 32, 23, 324, 324, 3, 234, 234 };

            int[] count = SingleArray();

            int[,] dimension = RectangleArray();
            PrintRectangleArray(dimension);

            string[][] companies = JaggedArray();

            TestForeach(companies);
            TetsForeach2(dimension);

            Console.WriteLine(count.Length);

            Console.WriteLine(dimension.GetLength(1));
            Console.WriteLine(companies[2].Length);

            int[] arr = new int[] { 2, };

            ArrayReverse(count);

            ArraySort(count);

            Student s2 = new Student();
            
        }


        /// <summary>
        /// Метод, получающий два параметра по ссылке
        /// </summary>
        /// <param name="numValueOne"></param>
        /// <param name="numValueTwo"></param>
        static void Calculate(ref int numValueOne, ref int
numValueTwo)
        {
            numValueOne = numValueOne * 2;
            numValueTwo = numValueTwo / 2;
        }
        /// <summary>
        /// Метод, получающий два параметра по значению
        /// </summary>
        /// <param name="numValueOne"></param>
        /// <param name="numValueTwo"></param>
        static void Calculate(int numValueOne, int
numValueTwo)
        {
            numValueOne = numValueOne * 2;
            numValueTwo = numValueTwo / 2;
        }

        /// <summary>
        /// Метод, получающий параметр, который необходимо проинициализировать
        /// </summary>
        /// <param name="numValueOne"></param>
        /// <param name="numValueTwo"></param>
        static void Depreciation(out int val)
        {
            val = 20000;
            int dep = val * 5 / 100;
            int amt = val - dep;
            Console.WriteLine("Depreciation Amount: {0}", dep);
            Console.WriteLine("Reduced value after depreciation: {0}", amt);
        }

        /// <summary>
        /// Совмещение типов принимающих в матоде аргументов
        /// </summary>
        /// <param name="numOne"></param>
        /// <param name="numTwo"></param>
        /// <param name="avg"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        static int Add(int numOne, int numTwo, out float avg, ref Object o)
        {
            o = new Object();
            avg = (numOne + numTwo) / 2.0f;
            return numOne + numTwo;
        }



        /// <summary>
        /// Создние одномерного массива
        /// </summary>
        /// <returns>Одномерный массив</returns>
        private static int[] SingleArray()
        {
            int[] count = new int[10];//создание массива
            int counter = 0;
            for (int i = 0; i < 10; i++)
            {
                //присваивание значений   элементам
                count[i] = counter++;
                //вывод значений элементов
                Console.WriteLine("The count value is: {0}", count[i]);
            }

            return count;
        }

        /// <summary>
        /// Печать значений одномерного массива
        /// </summary>
        /// <param name="dimension"></param>
        private static void PrintRectangleArray(int[,] dimension)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0} \t", dimension[i, j]);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Создание прямоугольного массива
        /// </summary>
        /// <returns></returns>
        private static int[,] RectangleArray()
        {
            int[,] dimension = new int[4, 5];
            int numThree = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dimension[i, j] = numThree;
                    numThree++;
                }
            }

            return dimension;

        }
        /// <summary>
        /// Создание неровного массива
        /// </summary>
        /// <returns>Неровный массив</returns>
        private static string[][] JaggedArray()
        {
            string[][] companies = new string[3][];
            companies[0] = new string[] { "Intel", "AMD" };
            companies[1] = new string[] { "IBM", "Microsoft", "Sun" };
            companies[2] = new string[] { "HP", "Canon", "Lexmark", "Epson" };
            for (int i = 0; i < companies.GetLength(0); i++)
            {
                Console.Write("List of companies in group {0}: ", i + 1);
                for (int j = 0; j < companies[i].GetLength(0); j++)
                {
                    Console.Write("{0} ", companies[i][j]);
                }
                Console.WriteLine();

            }

            return companies;
        }

        /// <summary>
        /// Использование foreach для перебора элеменотов прямоугольного массива
        /// </summary>
        /// <param name="dimension">Прямоугольный массив</param>
        private static void TetsForeach2(int[,] dimension)
        {
            foreach (int item in dimension)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Использование foreach для перебора элеменотов неровного двумерного массива
        /// </summary>
        /// <param name="dimension">Двумерный массив</param>
        private static void TestForeach(string[][] companies)
        {
            foreach (string[] comp in companies)
            {
                foreach (string cp in comp)
                {
                    Console.Write("{0} ", cp);
                }
            }
            Console.WriteLine();
        }


        /// <summary>
        /// Измение порядка следования элементов в одномерном массиве
        /// </summary>
        /// <param name="arr">одномерный массив</param>
        private static void ArrayReverse(int[] arr)
        {
            Array.Reverse(arr);


            foreach (int item in arr)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }


        /// <summary>
        /// Сортировка одномерного массива
        /// </summary>
        /// <param name="count">Одномерный массив</param>
        private static void ArraySort(int[] count)
        {
            Array.Sort(count);
            foreach (int item in count)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
