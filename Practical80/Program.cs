using System;

class StaticMethodDemo
{
    static void DisplayMessage()
    {
        Console.WriteLine("This is a static method");
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        DisplayMessage();

        int result = Add(10, 20);
        Console.WriteLine("Sum = " + result);

        Console.ReadKey();
    }
}