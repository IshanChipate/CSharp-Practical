using System;

class ReverseString
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

        Console.WriteLine("Reversed string = " + reverse);

        Console.ReadKey();
    }
}