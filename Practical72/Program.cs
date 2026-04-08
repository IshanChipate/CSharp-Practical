using System;

class MethodOverloading
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static double Add(double a, double b)
    {
        return a + b;
    }

    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    static void Main()
    {
        Console.WriteLine("Sum of two integers = " + Add(5, 10));
        Console.WriteLine("Sum of two doubles = " + Add(5.5, 2.5));
        Console.WriteLine("Sum of three integers = " + Add(2, 3, 4));

        Console.ReadKey();
    }
}