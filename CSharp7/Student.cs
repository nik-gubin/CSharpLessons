using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7
{
    class Student
    {
        //поля класса
        string name;
        string lastname;
        string surname;

        //свойства класса
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return DateTime.Now.Subtract(Birthday).Days / 365; }
        }

        public string Lastname
        {
            set { lastname = value; }
        }
        public Student(string name)
        {
            this.name = name;
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                if (value.Length > 10)
                {
                    surname = value;
                    return;
                }
                throw new ArgumentException();
            }
        }

        public DateTime Birthday { get; set; }

        //метод  с генерацией собственного исключения
        public void Add(string name)
        {
            int l = 25;
            if (l == 25)
            {
                throw new StudentException(this, name);
            }
        }
    }
}
