using System;
using System.Text.RegularExpressions;

class RegexDemo
{
    static void Main()
    {
        string input;

        Console.Write("Enter a string: ");
        input = Console.ReadLine();

        string pattern = @"\d+";

        Match match = Regex.Match(input, pattern);

        if (match.Success)
            Console.WriteLine("Number found: " + match.Value);
        else
            Console.WriteLine("No number found");

        Console.ReadKey();
    }
}