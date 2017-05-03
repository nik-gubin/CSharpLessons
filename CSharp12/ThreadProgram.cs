using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp12
{
    //Класс для выводов сообщений в нескольких потоках

    class ThreadProgram
    {
        private string _msg;
        private int _sleepTime;
        public ThreadProgram(string _msg, int _sleep)
        {
            this._msg = _msg;
            this._sleepTime = _sleep;
        }
        public void DoStart()
        {
            while (true)
            {
                //Приостановка потока, который выполняет этот код
                Thread.Sleep(_sleepTime);
                Console.WriteLine(_msg);
            }
        }
    }
}
