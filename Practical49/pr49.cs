using System;

class MathDemo
{
    static void Main()
    {
        int a = 25, b = 10;

        Console.WriteLine("Max: " + Math.Max(a, b));
        Console.WriteLine("Min: " + Math.Min(a, b));
        Console.WriteLine("Square root: " + Math.Sqrt(a));
        Console.WriteLine("Power: " + Math.Pow(2, 3));
        Console.WriteLine("Absolute value: " + Math.Abs(-15));
        Console.WriteLine("Ceiling: " + Math.Ceiling(4.3));
        Console.WriteLine("Floor: " + Math.Floor(4.8));

        Console.ReadKey();
    }
}