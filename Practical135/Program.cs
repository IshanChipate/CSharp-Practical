using System;

delegate void ShowMessage();

class MulticastDelegateDemo
{
    static void Message1()
    {
        Console.WriteLine("Hello");
    }

    static void Message2()
    {
        Console.WriteLine("Welcome");
    }

    static void Message3()
    {
        Console.WriteLine("C# Programming");
    }

    static void Main()
    {
        ShowMessage del;

        del = Message1;
        del += Message2;
        del += Message3;

        del();

        Console.ReadKey();
    }
}