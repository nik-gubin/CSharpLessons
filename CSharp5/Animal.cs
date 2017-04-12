using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp5
{

    //базовый класс
    class Animal 
    {
        //зактрытые поля базового класса (доступны ткажа в классах наследниках)
        protected string food = "mouse";
        protected string activity;

        //коструктор базового класса
        public Animal(string food, string activity)
        {
            this.activity = activity;
            this.food = food;
        }

        //виртуальный метод (можно переопределять)
        public virtual void Eat() { Console.WriteLine("Every animal eats something"); }

        //невиртуальный метод (нельзя переопределять)
        protected void DoSomething() { Console.WriteLine("Every animal does something"); }

        //переопределенный метод класса родителя
        public override string ToString()
        {
            return string.Format("Животное Любимая еда {0} Любимое занятие {1}", food, activity);
        }
    }
}
