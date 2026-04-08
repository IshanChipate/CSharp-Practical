using System;

class RemoveWhiteSpaces
{
    static void Main()
    {
        string str, result = "";

        Console.Write("Enter a string: ");
        str = Console.ReadLine();

        foreach (char ch in str)
        {
            if (ch != ' ')
                result += ch;
        }

        Console.WriteLine("String after removing spaces = " + result);

        Console.ReadKey();
    }
}