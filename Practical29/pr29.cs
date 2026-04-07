using System;

class ConditionalDemo
{
    static void Main()
    {
        int num;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
            Console.WriteLine("Using if: Number is positive");

        if (num % 2 == 0)
            Console.WriteLine("Using if: Number is even");
        else
            Console.WriteLine("Using if-else: Number is odd");

        if (num > 0)
            Console.WriteLine("Using else-if: Positive");
        else if (num < 0)
            Console.WriteLine("Using else-if: Negative");
        else
            Console.WriteLine("Using else-if: Zero");

        Console.WriteLine("\nUsing switch:");
        switch (num)
        {
            case 1:
                Console.WriteLine("Number is One");
                break;
            case 2:
                Console.WriteLine("Number is Two");
                break;
            default:
                Console.WriteLine("Number is not 1 or 2");
                break;
        }

        Console.ReadKey();
    }
}