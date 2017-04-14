using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{

    /// <summary>
    /// Абстрактный класс
    /// </summary>
   public abstract class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Every animal eats food in order to survive");
        }

        /// <summary>
        /// Абстрактный метод
        /// </summary>
        public abstract void AnimalSound();
    }

}
