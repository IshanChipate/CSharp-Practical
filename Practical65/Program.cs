using System;

class CountWords
{
    static void Main()
    {
        string str;
        int count;

        Console.Write("Enter a string: ");
        str = Console.ReadLine();

        string[] words = str.Split(' ');

        count = words.Length;

        Console.WriteLine("Number of words = " + count);

        Console.ReadKey();
    }
}