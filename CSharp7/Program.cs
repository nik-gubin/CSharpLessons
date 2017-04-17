using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 133;
            int numTwo = 0;
            int result;
            int[] arr = new int[5];

            try
            {
                object o = new object();
                string s1 = (string)o;
                // arr[5] = 9;
                result = numOne / numTwo;
            }
            catch (DivideByZeroException objDivide)
            {
                Console.WriteLine("Exception caught: {0}", objDivide);
            }
            catch (IndexOutOfRangeException)
            {

                Console.WriteLine("Вышли за пределы массива");
            }
            catch
            {
                Console.WriteLine("Все исключения");
            }
            finally
            {
                Console.WriteLine("Finally excute");
                int c = 0;
                // int i = 1 / c;
                //return 0;
            }

            Student s = new Student("Иван");
            try
            {
                s.Add("группа 1");
            }
            catch (StudentException e)
            {

                Console.WriteLine(e);
            }
            s.Birthday = new DateTime(1990, 1, 1);
            s.Name = "Сергей"; //s.Age = 10;
            s.Lastname = "Сергеев";
            s.Surname = "Сергеевевич121221";
            Console.WriteLine("{0}, {1}, {2}", s.Name, s.Age, s.Surname);


            EmployeeDetails empl = new EmployeeDetails();

            //empl[0] = "Имя 1";
            //empl[1] = "Имя 2";

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(empl[i]);
            }

            List<int> l = new List<int>();
           

        }

        public static int m()
        {
            try
            {
                return 1;
            }
            catch (Exception)
            {
                return 2;
            }
            finally
            {
                int c = 0;
                int i = 1 / c;
            }
        }
    }

    class Student
    {
        string name;

        string lastname;
        string surname;

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
        public void Add(string name)
        {
            int l = 25;
            if (l == 25)
            {
                throw new StudentException(this, name);
            }
        }
    }

    class StudentException : Exception
    {
        public Student s;
        public string name;
        public StudentException(Student s, string name)
        {
            this.s = s;
            this.name = name;
        }

        public override string ToString()
        {
            return string.Format("Невозможно добавить {0} в группу {1} из  превышение лимита", s.Name, name);
        }

    }

    class EmployeeDetails
    {
        private string[] empName = new string[2];
        public string this[int index ]
        {
            get { return empName[index]; }
            set { empName[index] = value; }
        }
    }
}
