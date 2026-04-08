using System;

class OptionalParametersDemo
{
    static void Display(string name, int age = 18)
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    static void Main()
    {
        Display("Ishan");
        Console.WriteLine();

        Display("Rahul", 21);

        Console.ReadKey();
    }
}