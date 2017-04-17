using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp7
{
    //класса с индексаторами
    class EmployeeDetails
    {
        private string[] empName = new string[2];
        //индексатор
        public string this[int index]
        {
            get { return empName[index]; }
            set { empName[index] = value; }
        }
        //перегруженный индексатор
        public string this[int index, int ind2]
        {
            get { return empName[index]; }
            set { empName[index] = value; }
        }
        //перегруженный индесатор
        public string this[string index]
        {
            get { return ""; }
          //  set { empName[index] = value; }
        }

    }
}
