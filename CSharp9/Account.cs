using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    //делегат для событий класса  Account
    public delegate void AccountAction(Account a, string s);
    public class Account
    {
        //Событие, возникающее при увеличении счета
        public event AccountAction PutAction;
        public string Name { get; set; }
        public int Money { get; set; }
        public void Put(int s)
        {
            Money += s;
            //Вызов события
            PutAction?.Invoke(this, "Зачеслено " + s);
        }
    }
}
