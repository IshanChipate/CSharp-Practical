using System;

class ReplaceSubstring
{
    static void Main()
    {
        string str, oldWord, newWord;

        Console.Write("Enter a string: ");
        str = Console.ReadLine();

        Console.Write("Enter substring to replace: ");
        oldWord = Console.ReadLine();

        Console.Write("Enter new substring: ");
        newWord = Console.ReadLine();

        str = str.Replace(oldWord, newWord);

        Console.WriteLine("Updated string = " + str);

        Console.ReadKey();
    }
}