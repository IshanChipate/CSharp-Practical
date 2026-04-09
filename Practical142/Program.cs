using System;
using System.Threading.Tasks;

class AsyncAwaitDemo
{
    static async Task ShowMessage()
    {
        Console.WriteLine("Processing...");
        await Task.Delay(2000);
        Console.WriteLine("Process Completed");
    }

    static async Task Main()
    {
        await ShowMessage();
        Console.WriteLine("End of Program");

        Console.ReadKey();
    }
}