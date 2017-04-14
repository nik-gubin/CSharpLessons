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

        public new void Eat()
        {
            Console.WriteLine("Пудель что-то ест");
        }
    }
}
