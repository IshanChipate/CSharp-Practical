using System;

class ThrowExceptionDemo
{
    static void CheckNumber(int num)
    {
        if (num < 0)
        {
            throw new Exception("Number cannot be negative");
        }

        Console.WriteLine("Number is: " + num);
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            CheckNumber(number);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: " + ex.Message);
        }

        Console.ReadKey();
    }
}