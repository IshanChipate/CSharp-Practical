using System;
using System.Collections.Generic;

class ListDemo
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(40);

        Console.WriteLine("List elements:");

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        Console.ReadKey();
    }
}