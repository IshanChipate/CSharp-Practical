using System;

static class MathUtility
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

class StaticClassDemo
{
    static void Main()
    {
        int sum = MathUtility.Add(10, 20);
        int product = MathUtility.Multiply(5, 4);

        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Product = " + product);

        Console.ReadKey();
    }
}