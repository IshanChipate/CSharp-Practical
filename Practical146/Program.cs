using System;
using System.IO;

class FileHandlingDemo
{
    static void Main()
    {
        string path = "sample.txt";

        File.WriteAllText(path, "Hello Ishan\nWelcome to C# File Handling");

        Console.WriteLine("Data written to file.");

        string content = File.ReadAllText(path);

        Console.WriteLine("\nFile Content:");
        Console.WriteLine(content);

        Console.ReadKey();
    }
}