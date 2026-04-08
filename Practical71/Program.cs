using System;

class MethodWithParameters
{
    static void Add(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine("Sum = " + sum);
    }

    static void Main()
    {
        int x, y;

        Console.Write("Enter first number: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        y = Convert.ToInt32(Console.ReadLine());

        Add(x, y);

        Console.ReadKey();
    }
}