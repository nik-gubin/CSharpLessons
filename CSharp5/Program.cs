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


            Console.WriteLine(a);
            Console.WriteLine();

            Console.WriteLine("-----Работа со временем-----");

            DateTime d = DateTime.Now;
            Console.WriteLine("Текущее время {0}\n",d);

            DateTime d1 = d.AddHours(3).AddMinutes(3).AddSeconds(3);
            Console.WriteLine("Увеличенное время {0}\n",d1);

            DateTime d2 = d1.AddHours(-3).AddMinutes(-3).AddSeconds(-3);
            Console.WriteLine("Уменьшенное время {0}\n",d2);


            DateTime d3 = d1.Add(new TimeSpan(-d2.Ticks));
            Console.WriteLine("Разница двух дат {0}\n",d3);

            DateTime d4 = new DateTime(1, 1, 11, 12, 36, 6, 956);
            Console.WriteLine("Создание собственной даты {0}\n", d4);

            Console.WriteLine("Представление даты для другого языка {0}\n", 
                d4.ToString(CultureInfo.GetCultureInfo("ja-JP")));
            Console.WriteLine("Длинное время {0}\n", d4.ToLongTimeString());


            Console.WriteLine("Короткая дата {0}\n", d4.ToShortDateString());
            Console.WriteLine("Короткое время {0}\n", d4.ToShortTimeString());

            Console.WriteLine("Шаблон даты {0}\n", d4.ToString("dd-MMMM-yyyy hh:mm", CultureInfo.GetCultureInfo("ja-JP")));
            //foreach (var item in CultureInfo.GetCultures(CultureTypes.AllCultures))
            //{
            //    Console.WriteLine(item);
            //} 
            Console.WriteLine("Количество тактов  {0}\n", DateTime.Now.Ticks);
            Console.WriteLine("Количество тактов  {0}\n", DateTime.Now.Ticks);
        }
    }
}
