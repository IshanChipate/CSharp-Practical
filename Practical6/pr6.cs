using System;

class PositiveNegative
{
    static void Main()
    {
        int num;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
            Console.WriteLine("Number is Positive");
        else if (num < 0)
            Console.WriteLine("Number is Negative");
        else
            Console.WriteLine("Number is Zero");

        Console.ReadKey();
    }
}