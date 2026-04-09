using System;
using System.Threading;

class MultithreadingDemo
{
    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Number: " + i);
            Thread.Sleep(500);
        }
    }

    static void Main()
    {
        Thread t1 = new Thread(PrintNumbers);

        t1.Start();

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Main Thread: " + i);
            Thread.Sleep(500);
        }

        Console.ReadKey();
    }
}