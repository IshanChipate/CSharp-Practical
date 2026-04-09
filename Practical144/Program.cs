using System;
using System.Threading.Tasks;

class TPLDemo
{
    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Task: " + i);
            Task.Delay(500).Wait();
        }
    }

    static void Main()
    {
        Task task = Task.Run(() => PrintNumbers());

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Main: " + i);
            Task.Delay(500).Wait();
        }

        task.Wait();

        Console.ReadKey();
    }
}