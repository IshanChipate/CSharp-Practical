using System;

static class StringExtension
{
    public static string ToUpperCaseFirst(this string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;

        return char.ToUpper(str[0]) + str.Substring(1);
    }
}

class ExtensionMethodDemo
{
    static void Main()
    {
        string name = "ishan";

        string result = name.ToUpperCaseFirst();

        Console.WriteLine("Result: " + result);

        Console.ReadKey();
    }
}