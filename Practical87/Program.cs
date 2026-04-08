using System;
using System.Text.RegularExpressions;

class ValidateEmail
{
    static void Main()
    {
        string email;

        Console.Write("Enter email: ");
        email = Console.ReadLine();

        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        if (Regex.IsMatch(email, pattern))
            Console.WriteLine("Valid Email");
        else
            Console.WriteLine("Invalid Email");

        Console.ReadKey();
    }
}