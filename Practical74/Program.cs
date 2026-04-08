using System;

class FibonacciRecursion
{
    static int Fibonacci(int n)
    {
        if (n == 0)
            return 0;
        else if (n == 1)
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        int n;

        Console.Write("Enter number of terms: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Fibonacci Series:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }

        Console.ReadKey();
    }
}