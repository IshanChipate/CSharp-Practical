using System;

class StringImmutability
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = str1;

        str1 = str1 + " World";

        Console.WriteLine("str1 = " + str1);
        Console.WriteLine("str2 = " + str2);

        Console.ReadKey();
    }
}