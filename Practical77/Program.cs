using System;

class ParamsDemo
{
    static int Add(params int[] numbers)
    {
        int sum = 0;

        foreach (int n in numbers)
        {
            sum += n;
        }

        return sum;
    }

    static void Main()
    {
        Console.WriteLine("Sum = " + Add(1, 2));
        Console.WriteLine("Sum = " + Add(1, 2, 3, 4));
        Console.WriteLine("Sum = " + Add(5, 10, 15));

        Console.ReadKey();
    }
}