using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    public partial class Mathemathik
    {
        public static int Mul(int numOne, int numTwo)
        {

            Add?.Invoke("умножение");
            return (numOne * numTwo);
        }
        public static int Div(int numOne, int numTwo)
        {
            if (Sub != null)
            {
                Sub("деление");
            }
            return (numOne / numTwo);
        }
    }

}
