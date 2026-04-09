using System;
using System.Collections;

class ArrayListDemo
{
    static void Main()
    {
        ArrayList list = new ArrayList();

        list.Add(10);
        list.Add(20);
        list.Add("Ishan");
        list.Add(45.5);

        Console.WriteLine("ArrayList elements:");

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }
}