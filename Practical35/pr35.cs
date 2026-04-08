using System;

class StarPattern
{
    static void Main()
    {
        int n;

        Console.Write("Enter number of rows: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}