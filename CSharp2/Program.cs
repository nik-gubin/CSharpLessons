using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //оператор ветвления
            int num = -13;
            if (num < 0)
                Console.WriteLine("The number is negative");
            else if ((num % 2) == 0)
                Console.WriteLine("The number is even");
            else
                Console.WriteLine("The number is odd");

            //тернарный оператор
            int a = num > 0 ? 1 : -1;
            Console.WriteLine(a);

            //аналогия тернарного оператора
            if (num > 0) { a = 1; }
            else { a = -1; }
            Console.WriteLine(a);

            string[] arr = { "A", "B", "C" };

            //цикл со счетчиком
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();

            //перебор всх элементов в массиве
            int j = 0;
            foreach (string s in arr)
            {
                if (j % 2 == 0)
                {
                    Console.Write("{0} ", s);
                    // s = "XXXXX";
                }
                j++;
            }
            Console.WriteLine();
            bool result;
            int number1;

            //цикл с условием
            while (true)
            {
                Console.Write("Enter number: ");
                string s = Console.ReadLine();
                 result = int.TryParse(s, out number1);
                if (result)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("This is not number");
                }
            }
            Console.WriteLine("You enter {0}", number1);


            //просто do...while
            int number2;
            do
            {
                Console.Write("Enter number: ");
                string s = Console.ReadLine();
                result = int.TryParse(s, out number2);
                if (!result)
                {
                    Console.WriteLine("This is not number");
                }               
            } while (!result);
            Console.WriteLine("You enter {0}", number2);

            //нахождениие суммы элементов натурального ряд от num1 до num2
            int sum = 0;
            for (int i = number1; i <= number2; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum = {0}",sum);
            
        }
    }
}
