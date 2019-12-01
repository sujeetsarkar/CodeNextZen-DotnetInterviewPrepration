using System;
using System.Threading;

namespace CodeNextZen_Threading
{

    // BackGround Thread: These threads stops(dies-off) executing if main(parent) thread exit.
    // Foreground Thread (Default): These thread keeps executing even if main(parent) thread exit (dies).
    class Program
    {
        static void Main(string[] args)
        {
            // created 2 thread
            Thread thread1 = new Thread(Function1);
            Thread thread2 = new Thread(Function2);
            Thread thread3 = new Thread(BackgroundThreadFunction);
            thread3.IsBackground = true;
            // invoked these thread
            thread1.Start();
            thread2.Start();
            //comment above two line to properly visualize the background thread and do Ctrl+F5
            thread3.Start();
            Console.WriteLine("Main Application/Thread has exited");
        }
        static void BackgroundThreadFunction()
        {
            Console.WriteLine("BackgroundThreadFunction is entered");
            Console.ReadLine();
            Console.WriteLine("BackgroundThreadFunction is exited");
        }
        static void Function1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 1 executed" + i);
                // wait for 4 sec
                Thread.Sleep(4000);
            }
        }
        static void Function2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 2 executed" + i);
                // wait for 4 sec
                Thread.Sleep(4000);
            }
        }
    }
}
