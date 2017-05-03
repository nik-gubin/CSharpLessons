using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp12
{
    public class ThreadTest
    {
        public static void Main(string[] args)
        {
            //CreateThreadMethod();
            // ProirityMethod();

            BlockingMethod();

            //вызов метода каждую секунду
            Timer timer = new Timer(TimerMethod, null, 5000, 1000);
            Console.ReadLine();
        }

        //метод для создания трех потоков
        private static void CreateThreadMethod()
        {
            ThreadProgram objProgram1 = new ThreadProgram("Hi", 100);
            ThreadProgram objProgram2 = new ThreadProgram("Hello", 150);
            ThreadProgram objProgram3 = new ThreadProgram("How are you?", 200);
            Thread objThread1 = new Thread(new ThreadStart(objProgram1.DoStart));
            objThread1.Start();
            Thread objThread2 = new Thread(new ThreadStart(objProgram2.DoStart));
            objThread2.Start();
            Thread objThread3 = new Thread(new ThreadStart(objProgram3.DoStart));
            objThread3.Start();
            while (true)
            {
                Thread.Sleep(500);
                Console.WriteLine("\n////////////// {0} {1} {2}", objThread1.ThreadState, objThread2.ThreadState, objThread3.ThreadState);
            }
        }

        //демострация работы потоков с разными приоритетами
        private static void ProirityMethod()
        {
            PriorityDemo objPriority1 = new PriorityDemo();
            PriorityDemo objPriority2 = new PriorityDemo();
            PriorityDemo objPriority3 = new PriorityDemo();
            Thread objThread1 = new Thread(new ThreadStart(objPriority1.DoAction));
            Thread objThread2 = new Thread(new ThreadStart(objPriority2.DoAction));
            Thread objThread3 = new Thread(new ThreadStart(objPriority3.DoAction));
            objThread1.Name = "Thread" + 1;
            objThread2.Name = "Thread" + 2;
            objThread3.Name = "Thread" + 3;
            objThread1.Priority = ThreadPriority.Lowest;

            objThread3.Priority = ThreadPriority.Highest;

            objThread1.Start();
            objThread2.Start();
            objThread3.Start();
            string str = string.Empty;
            while (str != "end")
            {
                str = Console.ReadLine();

            }
            objPriority1.stop = true;
            objPriority2.stop = true;
            objPriority3.stop = true;

            Console.WriteLine("{0} {1} {2}", objPriority1.count, objPriority2.count, objPriority3.count);
        }


        //Постоки с общим доступом к данным
        private static void BlockingMethod()
        {
            BlockingDemo t = new BlockingDemo();
            Thread t1 = new Thread(t.DoAction);
            t1.Name = "Thread 1";
            Thread t2 = new Thread(t.DoAction);
            t2.Name = "Thread 2";
            Thread t3 = new Thread(t.DoAction);
            t3.Name = "Thread 3";
            Thread t4 = new Thread(t.DoAction);
            t4.Name = "Thread 4";
            Thread t5 = new Thread(t.DoAction);
            t5.Name = "Thread 5";
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();
            t5.Join();
            Console.WriteLine();
            Console.WriteLine(t.count);
        }

        //мтод для таймера
        public static void TimerMethod(object o)
        {
            Console.WriteLine(DateTime.Now);
        }

    }
}






