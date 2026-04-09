using System;
using System.Threading;

class LockDemo
{
    static int counter = 0;
    static object lockObj = new object();

    static void Increment()
    {
        for (int i = 0; i < 5; i++)
        {
            lock (lockObj)
            {
                counter++;
                Console.WriteLine("Counter: " + counter);
            }

            Thread.Sleep(200);
        }
    }

    static void Main()
    {
        Thread t1 = new Thread(Increment);
        Thread t2 = new Thread(Increment);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Final Counter = " + counter);

        Console.ReadKey();
    }
}