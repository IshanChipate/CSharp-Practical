using System;
using System.Collections.Generic;

class DictionaryDemo
{
    static void Main()
    {
        Dictionary<int, string> students = new Dictionary<int, string>();

        students.Add(1, "Ishan");
        students.Add(2, "Rahul");
        students.Add(3, "Amit");

        Console.WriteLine("Dictionary elements:");

        foreach (KeyValuePair<int, string> item in students)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }

        Console.ReadKey();
    }
}