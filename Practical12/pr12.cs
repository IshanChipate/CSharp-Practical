using System;

class Fibonacci
{
    static void Main()
    {
        int n, a = 0, b = 1, c;

        Console.Write("Enter number of terms: ");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Fibonacci Series: ");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;
        }

        Console.ReadKey();
    }
}