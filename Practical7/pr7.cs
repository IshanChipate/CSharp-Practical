using System;

class SimpleInterest
{
    static void Main()
    {
        double principal, rate, time, interest;

        do
        {
            Console.Write("Enter Principal amount: ");
            principal = Convert.ToDouble(Console.ReadLine());

            if (principal < 0)
                Console.WriteLine("Principal cannot be negative. Try again.");
        }
        while (principal < 0);

        do
        {
            Console.Write("Enter Rate of Interest: ");
            rate = Convert.ToDouble(Console.ReadLine());

            if (rate < 0)
                Console.WriteLine("Rate cannot be negative. Try again.");
        }
        while (rate < 0);

        do
        {
            Console.Write("Enter Time (in years): ");
            time = Convert.ToDouble(Console.ReadLine());

            if (time < 0)
                Console.WriteLine("Time cannot be negative. Try again.");
        }
        while (time < 0);

        interest = (principal * rate * time) / 100;

        Console.WriteLine("Simple Interest = " + interest);

        Console.ReadKey();
    }
}