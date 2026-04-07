using System;

class AsciiValue
{
    static void Main()
    {
        char ch;

        Console.Write("Enter a character: ");
        ch = Convert.ToChar(Console.ReadLine());

        int ascii = (int)ch;

        Console.WriteLine("ASCII value of " + ch + " = " + ascii);

        Console.ReadKey();
    }
}