using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7
{
    //реализация собственного исключения
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
}
