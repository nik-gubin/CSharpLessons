using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    public class Dog : Animal, IAnimal, ICloneable
    {
      public  string name;

        public override void Eat()
        {
            Console.WriteLine("Собака ест");
        }

        public Dog(string name) {
            this.name = name;
        }
        public override void AnimalSound()
        {
            Console.WriteLine("gavvvv");
        }

        public object Clone()
        {
            return new Dog(name);
        }

        public void Habitat()
        {
            Console.WriteLine("Can be housed with human beings");

        }

        public override string ToString()
        {
            return string.Format("Кличка {0}",name);
        }
    }
}
