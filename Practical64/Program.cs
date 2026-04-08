using System;

class PalindromeString
{
    static void Main()
    {
        string str, reverse = "";

        Console.Write("Enter a string: ");
        str = Console.ReadLine();

        for (int i = str.Length - 1; i >= 0; i--)
        {
            reverse += str[i];
        }

        if (str == reverse)
            Console.WriteLine("String is Palindrome");
        else
            Console.WriteLine("String is Not Palindrome");

        Console.ReadKey();
    }
}