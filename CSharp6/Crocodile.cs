using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{

    /// <summary>
    /// Класс, который реализует множество интерфейсов
    /// </summary>
    class Crocodile : ITerrestrialAnimal,IMarineAnimal
    {
       /// <summary>
       /// пНеявное переопределение метода интерфейсов
       /// </summary>
        public void Eat() {
            Console.WriteLine("Что ест");
        }

        /// <summary>
        /// Явное переопределение методов
        /// </summary>
         void ITerrestrialAnimal.Eat() {
            Console.WriteLine("ITerrestrialAnimal");
        }

        /// <summary>
        /// Явное переопределение методов
        /// </summary>
        void IMarineAnimal.Eat()
        {
            Console.WriteLine("IMarineAnimal");
        }
    }
}
