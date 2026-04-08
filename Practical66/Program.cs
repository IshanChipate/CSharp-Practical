using System;

class CharacterFrequency
{
    static void Main()
    {
        string str;

        Console.Write("Enter a string: ");
        str = Console.ReadLine();

        for (int i = 0; i < str.Length; i++)
        {
            int count = 1;

            if (str[i] == ' ')
                continue;

            for (int j = i + 1; j < str.Length; j++)
            {
                if (str[i] == str[j])
                {
                    count++;
                }
            }

            bool alreadyCounted = false;

            for (int k = 0; k < i; k++)
            {
                if (str[i] == str[k])
                {
                    alreadyCounted = true;
                    break;
                }
            }

            if (!alreadyCounted)
                Console.WriteLine(str[i] + " : " + count);
        }

        Console.ReadKey();
    }
}