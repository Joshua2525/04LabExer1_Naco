using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Naco_Threads
{

    class MyThreadClass
    {
        
          public static void Thread1()
        {
            for (int th = 0; th <= 5; th++)
            {

                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + th);
                Thread.Sleep(5000);
            }
        }
    }
}


