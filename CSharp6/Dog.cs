using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    /// <summary>
    /// Класс, реализующий абстрактный класс и два интерфейса
    /// </summary>
    public class Dog : Animal, IAnimal, ICloneable
    {
      public  string name;

        /// <summary>
        /// Замещение метода базового класса
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine("Собака ест");
        }

        public Dog(string name) {
            this.name = name;
        }

        /// <summary>
        /// Замещение астракного метода базового класс
        /// </summary>
        public override void AnimalSound()
        {
            Console.WriteLine("gavvvv");
        }

        public object Clone()
        {
            return new Dog(name);
        }

        /// <summary>
        /// Переопределение метода интерфейса
        /// </summary>
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
