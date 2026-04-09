using System;

delegate void Display(string message);

class AnonymousMethodDemo
{
    static void Main()
    {
        Display show = delegate (string msg)
        {
            Console.WriteLine("Message: " + msg);
        };

        show("Hello Ishan");

        Console.ReadKey();
    }
}