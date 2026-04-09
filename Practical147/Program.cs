using System;
using System.Text.Json;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class SerializationDemo
{
    static void Main()
    {
        Student s = new Student { Id = 1, Name = "Ishan" };

        string json = JsonSerializer.Serialize(s);
        Console.WriteLine("Serialized JSON:");
        Console.WriteLine(json);

        Student obj = JsonSerializer.Deserialize<Student>(json);

        Console.WriteLine("\nDeserialized Object:");
        Console.WriteLine("Id: " + obj.Id);
        Console.WriteLine("Name: " + obj.Name);

        Console.ReadKey();
    }
}