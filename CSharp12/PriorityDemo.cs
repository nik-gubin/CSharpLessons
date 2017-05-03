using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp12
{
    //Сообщение о приоритете потоков
    class PriorityDemo
    {
        public int count = 0;
        public bool stop = false;
        public void DoAction()
        {
            while (!stop)
            {
                count++;
                Console.WriteLine("Priority of {0} was {1}", Thread.CurrentThread.Name, Thread.CurrentThread.Priority);
                // Thread.CurrentThread.Priority = ThreadPriority.Highest;
                Console.WriteLine("Its priority now is " + Thread.CurrentThread.Priority);
            }
        }
    }
}
