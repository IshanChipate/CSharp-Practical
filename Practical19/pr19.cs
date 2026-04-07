using System;

class PrimeRange
{
    static void Main()
    {
        int start, end, temp;

        Console.Write("Enter starting number: ");
        start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter ending number: ");
        end = Convert.ToInt32(Console.ReadLine());

        if (start > end)
        {
            temp = start;
            start = end;
            end = temp;
        }

        Console.WriteLine("Prime numbers:");

        for (int i = start; i <= end; i++)
        {
            if (i <= 1)
                continue;

            int count = 0;

            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                    count++;
            }

            if (count == 2)
                Console.Write(i + " ");
        }

        Console.ReadKey();
    }
}