using System;

class RandomNumbers
{
    static void Main()
    {
        Random rand = new Random();

        Console.WriteLine("Random numbers:");

        for (int i = 1; i <= 5; i++)
        {
            int num = rand.Next(1, 100);
            Console.WriteLine(num);
        }

        Console.ReadKey();
    }
}