using System;

class BreakContinueDemo
{
    static void Main()
    {
        Console.WriteLine("Using break:");
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
                break;

            Console.WriteLine(i);
        }

        Console.WriteLine("\nUsing continue:");
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
                continue;

            Console.WriteLine(i);
        }

        Console.ReadKey();
    }
}
