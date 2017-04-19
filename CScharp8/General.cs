using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    /// <summary>
    /// Обобщенный класс для храения разнообразных объектов
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class General<T>
    {
        T[] values;
        int _counter = 0;
        public General(int max)
        {
            values = new T[max];
        }
        public void Add(T val)
        {
            if (_counter < values.Length)
            {
                values[_counter] = val;
                _counter++;
            }
        }

        public void Display()
        {
            Console.WriteLine("Constructed Class is of type: " + typeof(T));
            Console.WriteLine("Values stored in the object of   constructed class are : ");
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
        }
    }

    public class StudentGeneral : General<Student>
    {
        public StudentGeneral(int m) : base(m) { }
    }

    public class GeneralClass<T> : General<T> where T : class
    {
        public GeneralClass(int m) : base(m) { }
    }
}
