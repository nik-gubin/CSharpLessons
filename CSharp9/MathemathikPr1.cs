using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    /// <summary>
    /// Частичный класс, в котором сгруппированы методы математических операций с высоким приоритетом
    /// </summary>
    public partial class Mathemathik
    {
        public static int Mul(int numOne, int numTwo)
        {
            //генерация события
            Add?.Invoke("умножение");
            return (numOne * numTwo);
        }
        public static int Div(int numOne, int numTwo)
        {
            //генерация события
            if (Sub != null)
            {
                Sub("деление");
            }
            return (numOne / numTwo);
        }
    }

}
