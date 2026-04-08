using System;

class OutRefDemo
{
    static void Add(ref int a)
    {
        a = a + 10;
    }

    static void GetValues(out int x, out int y)
    {
        x = 20;
        y = 30;
    }

    static void Main()
    {
        int num = 5;
        Console.WriteLine("Before ref: " + num);

        Add(ref num);
        Console.WriteLine("After ref: " + num);

        int a, b;
        GetValues(out a, out b);

        Console.WriteLine("Out values:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        Console.ReadKey();
    }
}