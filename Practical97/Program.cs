using System;

class SpanDemo
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        Span<int> span = numbers.AsSpan(1, 3);

        Console.WriteLine("Span elements:");
        foreach (var num in span)
        {
            Console.Write(num + " ");
        }

        span[0] = 99;

        Console.WriteLine("\nArray after modifying Span:");
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }

        ReadOnlySpan<int> readOnlySpan = numbers;

        Console.WriteLine("\nReadOnlySpan elements:");
        foreach (var num in readOnlySpan)
        {
            Console.Write(num + " ");
        }

        Console.ReadKey();
    }
}