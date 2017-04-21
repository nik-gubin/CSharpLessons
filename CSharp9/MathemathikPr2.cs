using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    public partial class Mathemathik
    {
        public static event ActionPrint Add;
        public static event ActionPrint Sub;
        public static int Addition(int numOne, int numTwo)
        {

            Add?.Invoke("сложение");
            return (numOne + numTwo);
        }
        public static int Subtraction(int numOne, int numTwo)
        {
            if (Sub != null)
            {
                Sub("вычитание");
            }
            return (numOne - numTwo);
        }
    }
}
