using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    /// <summary>
    /// Класс для описания студетнта
    /// </summary>
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1} ", Name, Group);
        }

        /// <summary>
        /// Реализация логики сортировки студентов в рамках одного множества SortedSet
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Student other)
        {
            int r = this.Group.CompareTo(other.Group);
            if (r == 0)
            {
                return this.Name.CompareTo(other.Name);
            }
            else
            {
                return r * -1;
            }
        }
    }
}
