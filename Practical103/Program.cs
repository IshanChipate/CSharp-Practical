using System;

class FileManager
{
    public FileManager()
    {
        Console.WriteLine("File opened");
    }

    ~FileManager()
    {
        Console.WriteLine("File closed");
    }
}

class DestructorExample
{
    static void Main()
    {
        FileManager fm = new FileManager();

        Console.WriteLine("Working with file...");

        fm = null;

        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Program finished");

        Console.ReadKey();
    }
}