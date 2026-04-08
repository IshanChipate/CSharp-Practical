using System;

class RemoveSpecialCharacters
{
    static void Main()
    {
        string str, result = "";

        Console.Write("Enter a string: ");
        str = Console.ReadLine();

        foreach (char ch in str)
        {
            if (char.IsLetterOrDigit(ch) || ch == ' ')
            {
                result += ch;
            }
        }

        Console.WriteLine("String after removing special characters = " + result);

        Console.ReadKey();
    }
}