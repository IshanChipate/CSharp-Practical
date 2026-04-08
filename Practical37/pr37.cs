using System;

class PowerOfNumber
{
    static void Main()
    {
        double baseNum, exponent, result;

        Console.Write("Enter base number: ");
        baseNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter exponent: ");
        exponent = Convert.ToDouble(Console.ReadLine());

        result = Math.Pow(baseNum, exponent);

        Console.WriteLine("Result = " + result);

        Console.ReadKey();
    }
}