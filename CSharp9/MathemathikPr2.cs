using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    //описание делегата для вызова математических функций
    public delegate int Calculaiton(int a, int b);

    //описание делегата для событий класса Mathemathik
    public delegate void ActionPrint(string opertion);

    /// <summary>
    /// Частичный класс, в котором сгруппированы методы математических операций с низким приоритетом
    /// </summary>
    public partial class Mathemathik
    {
        //описание событий при сложении чисел
        public static event ActionPrint Add;
        //описание событий при вычитании чисел
        public static event ActionPrint Sub;
        public static int Addition(int numOne, int numTwo)
        {
            //генерация события
            Add?.Invoke("сложение");
            return (numOne + numTwo);
        }
        public static int Subtraction(int numOne, int numTwo)
        { 
            //генерация события
            if (Sub != null)
            {
                Sub("вычитание");
            }
            return (numOne - numTwo);
        }
    }
}
