using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace BackgroundThreads
{
    class PriorityTest
    {
        static void Main()
        {
            Func<string, int> method = Work;
            IAsyncResult cookie = method.BeginInvoke("test", null, null);
            //
            // ... here's where we can do other work in parallel...
            //
            int result = method.EndInvoke(cookie);
            Console.WriteLine("String length is: " + result);
        }

        static int Work(string s) { return s.Length; }

    }
}
