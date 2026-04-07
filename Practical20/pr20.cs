using System;

class PrimeNumber
{
    static void Main()
    {
        int num, count = 0;

        Console.Write("Enter a number: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num <= 1)
        {
            Console.WriteLine("Number is Not Prime");
        }
        else
        {
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    count++;
            }

            if (count == 2)
                Console.WriteLine("Number is Prime");
            else
                Console.WriteLine("Number is Not Prime");
        }

        Console.ReadKey();
    }
}