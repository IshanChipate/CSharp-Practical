using System;
using System.Collections.Generic;

class HashSetDemo
{
    static void Main()
    {
        HashSet<int> numbers = new HashSet<int>();

        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(20);
        numbers.Add(40);

        Console.WriteLine("HashSet elements:");

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        Console.ReadKey();
    }
}