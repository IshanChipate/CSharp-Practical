using System;

class StringFormattingDemo
{
    static void Main()
    {
        string name = "Ishan";
        int age = 21;
        double marks = 95.5;

        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Marks: {0:F2}", marks);

        Console.WriteLine("Formatted Output: Name = {0}, Age = {1}, Marks = {2:F1}", name, age, marks);

        Console.ReadKey();
    }
}