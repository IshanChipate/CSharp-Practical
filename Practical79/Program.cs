using System;

class NamedArgumentsDemo
{
    static void Display(string name, int age, string city)
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("City: " + city);
    }

    static void Main()
    {
        Display(name: "Ishan", age: 21, city: "Nagpur");

        Console.WriteLine();

        Display(age: 22, city: "Mumbai", name: "Rahul");

        Console.ReadKey();
    }
}