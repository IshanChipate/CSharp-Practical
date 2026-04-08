using System;

class NullableDemo
{
    static void Main()
    {
        int? num = null;

        if (num.HasValue)
            Console.WriteLine("Value = " + num.Value);
        else
            Console.WriteLine("Value is null");

        num = 10;

        Console.WriteLine("After assigning value: " + num);

        Console.ReadKey();
    }
}