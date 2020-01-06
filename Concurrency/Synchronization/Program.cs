using System;
using System.Threading;

namespace Synchronization
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(ThreadUnsafe.Go);
            Thread thread2=new Thread(ThreadUnsafe.Go);

            thread1.Start();
            thread2.Start();
        }
    }


    class ThreadUnsafe
    {
        static int _val1 = 1, _val2 = 1;
        static readonly object _locker = new object();
        public static void Go()
        {
            bool lockTaken = false;
            try
            {
                Monitor.Enter(_locker,ref lockTaken);
            }
            finally
            {
                if (lockTaken)
                {
                    Monitor.Exit(_locker);
                }
            }
        }
    }
}
