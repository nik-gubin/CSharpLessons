using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //вывод строки на консоль
            Console.WriteLine("Hello");
            int a;
            int b, c = 10, f;
            c = 15;
            Console.WriteLine(c);
            const int countType = 100;
            // countType = 10;

            bool bo = true;
            int i = 10;
            long l = 1000000000000;

            Console.WriteLine(l);
            string s = "2342\t342";
            string s2 = @"2342\t342";
            Console.WriteLine(s);
            Console.WriteLine(s2);
            string s3 = null;
            object o = null;
            Console.WriteLine("\a");

            Console.WriteLine("c={0} bo = {1} s2 = {2}  s3 ={3} o ={4}", c, bo, s2, s3, o);
            Console.WriteLine("c={4} bo = {2} s2 = {2}  s3 ={3} o ={4} bo = {1}", c, bo, s2, s3, o);
            double d = 1 / 3.0;
            Console.WriteLine("c={0:F} bo = {0:F3} s2 = {0:F50}  s3 ={0} o ={0} bo = {0}", d);

            DateTime date = DateTime.Now;
            Console.WriteLine("{0}", date);
            Console.WriteLine("{0:d}", date);
            Console.WriteLine("{0:D}", date);
            Console.WriteLine("{0:f}", date);
            Console.WriteLine("{0:F}", date);
            Console.WriteLine("{0:g}", date);
            Console.WriteLine("a {0} a", date.ToString("dd MMM"));

            string s4 = Console.ReadLine();
            Console.WriteLine("Enter : {0}", s4);
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine("ВВЕДИТЕ ЧМСЛО");
            s4 = Console.ReadLine();
            double d1 = Convert.ToDouble(s4);
            Console.WriteLine(d1);

           int a1= int.Parse("232");

            int cout;
          
            bool b3 = int.TryParse("135", out cout);
            Console.WriteLine(b3);
        }

        /// <summary>
        /// Что-то делает данный метод
        /// </summary>
        static void m() { }
    }
}
