using System;
using System.Text.RegularExpressions;

class PasswordValidation
{
    static void Main()
    {
        string password;

        Console.Write("Enter password: ");
        password = Console.ReadLine();

        string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&]).{8,}$";

        if (Regex.IsMatch(password, pattern))
            Console.WriteLine("Strong Password");
        else
            Console.WriteLine("Weak Password");

        Console.ReadKey();
    }
}