using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5
{

    //класс наследник
    class Cat : Animal
    {
        //конструткор класс, который вызывает конструткор базового класса
        public Cat() : base("food1", "activity1") { }
        //конструткор класс, который вызывает конструткор базового класса
        public Cat(string food,string activity) : base(food, activity) { }

        //поле класса Cat ("перетерное")
        private string food;
        
       
        public void Display() {
            food = "milk";
           // activity = "sleeping";

            //обращение к переменной данного класса (к перетертой)
            Console.WriteLine("The Cat loves to eat " + this.food + ".");
            //обращение к переменной базового класса
            Console.WriteLine("The Cat loves to eat " + base.food + ".");
            //обращение к переменной базового класса
            Console.WriteLine("The Cat loves to " + base.activity + ".");

        }

        //переопределенный метод
        public override void Eat()
        {
            Console.WriteLine("Cat loves to eat the mouse");
        }

        //переопределенный метод
        public override string ToString()
        {
            return "Кошкааааа";
        }
    }
}
