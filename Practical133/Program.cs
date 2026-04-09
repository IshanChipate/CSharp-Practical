using System;
using System.Linq;

class LambdaDemo
{
    static void Main()
    {
        Func<int, int, int> add = (a, b) => a + b;

        int result = add(10, 20);
        Console.WriteLine("Sum = " + result);

        int[] numbers = { 1, 2, 3, 4, 5 };

        var even = numbers.Where(n => n % 2 == 0);

        Console.WriteLine("Even numbers:");
        foreach (var n in even)
        {
            Console.WriteLine(n);
        }

        Console.ReadKey();
    }
}