using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal a = new Animal();
            Lion l = new Lion();
            l.AnimalSound();
            l.Eat();

            Crocodile c = new Crocodile();
            
            ITerrestrialAnimal t = c;
            IMarineAnimal m = c;
            m.Eat();
            t.Eat();
            Crocodile c1 = c;
            //Dog d1 = new Dog("Тузик");
            //Dog d2 = d1;
            //Console.WriteLine(d1);
            //Console.WriteLine(d2);

            //d2.name = "Пес";
            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            Dog d1 = new Dog("Тузик");
            Dog d2 = (Dog)d1.Clone() ;
            Console.WriteLine(d1);
            Console.WriteLine(d2);

            d2.name = "Пес";
            Console.WriteLine(d1);
            Console.WriteLine(d2);

            Animal a1 = d1;
            Dog d3 = (Dog)a1;

            bool b = d1 is Dog;
            if (b)
            {
                Dog d5 = (Dog)a1;
                Console.WriteLine("Собака");
            }
            else
            {
                Console.WriteLine("Не собака");
            }

            Console.WriteLine("\n----as-----");
            Dog d4 = a1 as Dog;
            if (d4!=null)
            {
                Console.WriteLine("Собака");
            }
            else
            {
                Console.WriteLine("Не собака");
            }
            Pudel p = new Pudel("");
            d1 = p;
            a1 = p;
            d1.Eat();
            a1.Eat();
            p.Eat();
        }
    }
}
