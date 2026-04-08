using System;

class SplitString
{
    static void Main()
    {
        string str;

        Console.Write("Enter a string: ");
        str = Console.ReadLine();

        string[] words = str.Split(' ');

        Console.WriteLine("Words in string:");

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        Console.ReadKey();
    }
}