using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    class Crocodile : ITerrestrialAnimal,IMarineAnimal
    {
        public void Eat() {
            Console.WriteLine("Что ест");
        }

         void ITerrestrialAnimal.Eat() {
            Console.WriteLine("ITerrestrialAnimal");
        }


        void IMarineAnimal.Eat()
        {
            Console.WriteLine("IMarineAnimal");
        }
    }
}
