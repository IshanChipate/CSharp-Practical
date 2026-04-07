using System;

class UserDetails
{
    static void Main()
    {
        string name;
        int age;
        string city;

        Console.Write("Enter Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter City: ");
        city = Console.ReadLine();

        Console.WriteLine("\nUser Details:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("City: " + city);

        Console.ReadKey();
    }
}