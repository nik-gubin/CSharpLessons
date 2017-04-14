using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    public class Pudel : Dog
    {
        public Pudel(string name) : base(name) { }

        /// <summary>
        /// Скрытие метода от базового класса
        /// </summary>
        public new void Eat()
        {
            Console.WriteLine("Пудель что-то ест");
        }
    }
}
