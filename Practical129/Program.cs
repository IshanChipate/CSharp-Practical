using System;
using System.Linq;

class LinqDemo
{
    static void Main()
    {
        int[] numbers = { 10, 15, 20, 25, 30 };

        var evenNumbers = numbers.Where(n => n % 2 == 0);

        Console.WriteLine("Even Numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        var squares = numbers.Select(n => n * n);

        Console.WriteLine("\nSquares:");
        foreach (var sq in squares)
        {
            Console.WriteLine(sq);
        }

        Console.ReadKey();
    }
}