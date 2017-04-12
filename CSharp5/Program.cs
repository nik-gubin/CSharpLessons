using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.Display();
            Console.WriteLine();

            Cat c2 = new Cat("f", "a");
            c2.Display();
            c2.Eat();
            Animal a = new Cat();
            a.Eat();

            object o = new object();

            Console.WriteLine();
            Console.WriteLine(a);

            DateTime d = DateTime.Now;
            Console.WriteLine(d);

            DateTime d1 = d.AddHours(3).AddMinutes(3).AddSeconds(3);
            Console.WriteLine(d1);

            DateTime d2 = d1.AddHours(-3).AddMinutes(-3).AddSeconds(-3);
            Console.WriteLine(d2);


            DateTime d3 = d1.Add(new TimeSpan(-d2.Ticks));
            Console.WriteLine(d3);

            DateTime d4 = new DateTime(1, 1, 11, 12, 36, 6, 956);
            Console.WriteLine(d4);

            Console.WriteLine(d4.ToString( CultureInfo.GetCultureInfo("ja-JP")));
            Console.WriteLine(d4.ToLongTimeString());


            Console.WriteLine(d4.ToShortDateString());
            Console.WriteLine(d4.ToShortTimeString());
            
            Console.WriteLine(d4.ToString("dd-MMMM-yyyy hh:mm",CultureInfo.GetCultureInfo("ja-JP")));
            //foreach (var item in CultureInfo.GetCultures(CultureTypes.AllCultures))
            //{
            //    Console.WriteLine(item);
            //} 
            Console.WriteLine(DateTime.Now.Ticks);
            Console.WriteLine(DateTime.Now.Ticks);
        }
    }
}
