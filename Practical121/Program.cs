using System;

class AgeException : Exception
{
    public AgeException(string message) : base(message)
    {
    }
}

class CustomExceptionDemo
{
    static void CheckAge(int age)
    {
        if (age < 18)
        {
            throw new AgeException("Age must be 18 or above");
        }
        else
        {
            Console.WriteLine("Eligible");
        }
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            CheckAge(age);
        }
        catch (AgeException ex)
        {
            Console.WriteLine("Custom Exception: " + ex.Message);
        }

        Console.ReadKey();
    }
}