using System;
using System.Threading;
using System.Threading.Tasks;

namespace LearningThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread myThread = new Thread(new ThreadStart(Work));
                myThread.Start();

                Task.Run(() =>
                {
                    Console.WriteLine("starting task in thread: " + Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(3000);
                    Console.WriteLine("Task complete");
                });
            }

        }
        static void Work()
        {
            Console.WriteLine("starting in thread: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            Console.WriteLine("Work complete");
        }
    }
}
