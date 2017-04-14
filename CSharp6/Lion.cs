using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{    
    /// <summary>
     /// Класс, реализующий абстрактный класс
     /// </summary>
    public class Lion : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Lion roars");
        }
    }
}
