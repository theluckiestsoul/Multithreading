using System;
using System.Threading;

namespace Thread1
{
    class ThreadTest
    {
        static void Main()
        {
            Main2();
            for (int i = 0; i < 10; i++)
            {
                var temp = i;
                new Thread(() => Console.WriteLine(temp)).Start();
            }
            string text = "t1";
            Thread t1 = new Thread(() => Console.WriteLine(text));

            text = "t2";
            Thread t2 = new Thread(() => { Console.WriteLine(text);

                Main2();
            });

            t1.Start();
            t2.Start();
        }
        static void Main2()
        {
            Thread.CurrentThread.Name = "main";
            Thread worker = new Thread(Go);
            worker.Name = "worker";
            worker.Start();
            Go();
        }

        static void Go()
        {
            Console.WriteLine("Hello from " + Thread.CurrentThread.Name);
        }

        //static void PrintData(object message)


    }
}
