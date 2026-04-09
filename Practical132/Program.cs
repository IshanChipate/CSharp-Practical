using System;
using System.Linq;

class LinqAggregateDemo
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        int sum = numbers.Aggregate((a, b) => a + b);

        Console.WriteLine("Sum using Aggregate = " + sum);

        int product = numbers.Aggregate((a, b) => a * b);

        Console.WriteLine("Product using Aggregate = " + product);

        Console.ReadKey();
    }
}