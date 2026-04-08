using System;

class RecursionDemo
{
    static int Factorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    static void Main()
    {
        int num;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        int result = Factorial(num);

        Console.WriteLine("Factorial = " + result);

        Console.ReadKey();
    }
}