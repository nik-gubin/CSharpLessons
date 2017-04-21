using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{

    /// <summary>
    /// Класса-подписчик на события класса Аккаунт
    /// </summary>
    public class SmsResponse
    {
        public void Response(Account a, string mess)
        {
            Console.WriteLine("Вам {0} на счет {2} Остаток {1}", mess, a.Money, a.Name);
        }
    }
}
