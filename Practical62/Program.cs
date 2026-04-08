using System;

class CountVowels
{
    static void Main()
    {
        string str;
        int count = 0;

        Console.Write("Enter a string: ");
        str = Console.ReadLine();

        foreach (char ch in str)
        {
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                count++;
            }
        }

        Console.WriteLine("Number of vowels = " + count);

        Console.ReadKey();
    }
}