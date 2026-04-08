using System;

class CompareStrings
{
    static void Main()
    {
        string str1, str2;

        Console.Write("Enter first string: ");
        str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        str2 = Console.ReadLine();

        if (str1 == str2)
            Console.WriteLine("Strings are equal");
        else
            Console.WriteLine("Strings are not equal");

        Console.ReadKey();
    }
}