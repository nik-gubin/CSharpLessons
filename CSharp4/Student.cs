using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp4
{

    //создание класса
    public class Student
    {
        //поля класса
        //доступное везде
        public string _studName = "James Anderson";
        //доступно внутри класса
        private int _studAge;
        //внутри сборки(проекта) и в классах наследниках
        protected internal string _groupName = "Group Develop";
        //внутри сборки
        internal int degree = 5;
        //внутри класса и классах-наследниках
        protected string school;

        //public Student(string name, int age):this()
        //{

        //    this._studAge = age;
        //    this._studName = name;
        //}

        //public Student(string name, int age, string groupName, int d, string school) 
        //    : this(name, age)
        //{
        //    this._groupName = groupName;
        //    this.degree = d;
        //    this.school = school;
        //}

        //public Student()
        //{
        //    Console.WriteLine("Загрузить все оценки из БД");
        //}

            //конструктор без параметров
        public Student() : this("Ivan", 18, null, 0, null)
        {

        }

        //1-я перегрузка конструктора
        public Student(string name, int age, string groupName, int d, string school)
        {
            this._studAge = age;
            this._studName = name;
            this._groupName = groupName;
            this.degree = d;
            this.school = school;
        }

        //2-я перегрузка конструктора
        public Student(string name, int age) : this(name, age, "Group Develop", 0, null)
        {


        }

        //деструктор
        ~Student()
        {
            Console.WriteLine("{0} удален из памяти", _studName);

        }

        //статический конструктор (вызовается при первом обращении к классу)
        static Student()
        {
            Console.WriteLine("Load class student");
        }

        //метод класс
        public void Display()
        {
            Console.WriteLine("Имя студента {0}", _studName);
            Console.WriteLine("Возраст студента {0}", _studAge);
            Console.WriteLine("Группа студента {0}", _groupName);
        }
        //метод класс
        public void PervodGroup(string group)
        {
            Console.WriteLine("Студен переведен из {0} в {1}", _groupName, group);
            _groupName = group;

        }
        //метод класс
        public float AvgDegree()
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            return rand.Next(0, 51) / 10f;
        }

    }


}
