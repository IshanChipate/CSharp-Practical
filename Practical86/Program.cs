using System;

class StringCaseConversion
{
    static void Main()
    {
        string str;

        Console.Write("Enter a string: ");
        str = Console.ReadLine();

        Console.WriteLine("Uppercase: " + str.ToUpper());
        Console.WriteLine("Lowercase: " + str.ToLower());

        Console.ReadKey();
    }
}