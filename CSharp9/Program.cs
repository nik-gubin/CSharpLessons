using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    class Program
    {

        static void Main(string[] args)
        {
            int x = 13;
            Calculaiton caclAdd = new Calculaiton(Mathemathik.Addition);
            Calculaiton caclSub = Mathemathik.Subtraction;
            Calculaiton caclMul = new Calculaiton(delegate (int a1, int b1) { x = 12; return a1 * b1 + x; });
            Calculaiton caclDiv = delegate (int a1, int b1) { return a1 / b1; };

            Mathemathik.Add += new ActionPrint(Print);
            Mathemathik.Add += new ActionPrint(Print);
            Mathemathik.Add += new ActionPrint(Print);
            Mathemathik.Add += new ActionPrint(Print);
            Mathemathik.Sub += new ActionPrint(Print);

            int c = caclAdd(10, 6);
            Console.WriteLine(c);
            Result(caclSub, 3, 6);
            Console.WriteLine("x = {0}", x);
            Result(caclMul, 3, 6);
            Console.WriteLine("x = {0}", x);

            Account a = new Account { Name = "A" };
            Account b = new Account { Name = "B" };
            SmsResponse response = new SmsResponse();
            a.PutAction += new AccountAction(response.Response);

            a.Put(1000);
            b.Put(1000);

            a.PutAction -= new AccountAction(response.Response);

            int? sum = null;

            if (sum.HasValue)
            {
                a.Put(sum.Value);
            }


            int? d = 10;
            int? f = null;
            int h = (d + f).HasValue ? (d + f).Value : 0;
            int j = (d + f) ??  0;
            Console.WriteLine("c + d = {0}", h);


        }

        public static void Result(Calculaiton calc, int a, int b)
        {
            Console.WriteLine("{0} и {1} = {2}", a, b, calc(a, b));
        }

        public static void Print(string oper)
        {
            Console.WriteLine("Произошла операция {0}", oper);
        }
    }

    public delegate int Calculaiton(int a, int b);
    public delegate void ActionPrint(string opertion);



    delegate void AccountAction(Account a, string s);
    class Account
    {
        public event AccountAction PutAction;
        public string Name { get; set; }
        public int Money { get; set; }
        public void Put(int s)
        {
            Money += s;
            PutAction?.Invoke(this, "Зачеслено " + s);
        }
    }

    class SmsResponse
    {
        public void Response(Account a, string mess)
        {
            Console.WriteLine("Вам {0} на счет {2} Остаток {1}", mess, a.Money, a.Name);
        }

    }
}
