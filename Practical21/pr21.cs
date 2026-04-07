using System;

class GcdLcm
{
    static void Main()
    {
        int a, b, gcd, lcm;

        Console.Write("Enter first number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        b = Convert.ToInt32(Console.ReadLine());

        int x = a;
        int y = b;

        while (y != 0)
        {
            int temp = y;
            y = x % y;
            x = temp;
        }

        gcd = x;
        lcm = (a * b) / gcd;

        Console.WriteLine("GCD = " + gcd);
        Console.WriteLine("LCM = " + lcm);

        Console.ReadKey();
    }
}