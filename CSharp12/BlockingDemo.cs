using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp12
{//Сихронизация потоков
    class BlockingDemo
    {
        public int count = 0;
        public object obj = new object();
        public void DoAction()
        {
            //первый способ использование монитора
            Monitor.Enter(obj);
            count = 0;
            for (int i = 0; i < 10; i++)
            {
                count++;
                Console.WriteLine("{0} {1}", Thread.CurrentThread.Name, count);
            }
            Monitor.Exit(obj);

            //вторрой способ использование lock
            lock (this)
            {
                count++;
            }



        }

        Mutex mutext = new Mutex();
        public void DoAction2()
        {
            //третий способ использование мьютекса
            mutext.WaitOne();
            count = 0;
            for (int i = 0; i < 10; i++)
            {
                count++;
                Console.WriteLine("{0} {1}", Thread.CurrentThread.Name, count);
            }

            //lock (this)
            //{
            count++;
            //}


            mutext.ReleaseMutex();
        }
    }
}
