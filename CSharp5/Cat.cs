using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5
{
    class Cat : Animal
    {
        public Cat() : base("food1", "activity1") { }
        public Cat(string food,string activity) : base(food, activity) { }


        private string food;
        public void Display() {
            food = "milk";
           // activity = "sleeping";

            Console.WriteLine("The Cat loves to eat " + this.food + ".");
            Console.WriteLine("The Cat loves to eat " + base.food + ".");
            Console.WriteLine("The Cat loves to " + base.activity + ".");

        }

        public override void Eat()
        {
            Console.WriteLine("Cat loves to eat the mouse");
        }

        public override string ToString()
        {
            return "Кошкааааа";
        }
    }
}
