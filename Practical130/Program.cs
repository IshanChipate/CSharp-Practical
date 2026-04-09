using System;
using System.Linq;

class LinqGroupByDemo
{
    static void Main()
    {
        string[] names = { "Ishan", "Rahul", "Amit", "Ankit", "Ravi" };

        var grouped = names.GroupBy(name => name[0]);

        foreach (var group in grouped)
        {
            Console.WriteLine("Group: " + group.Key);

            foreach (var name in group)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
        }

        Console.ReadKey();
    }
}