using System;

struct Student
{
    public int rollNo;
    public string name;
}

class StructDemo
{
    static void Main()
    {
        Student s;

        s.rollNo = 100;
        s.name = "Ishan";

        Console.WriteLine("Roll No: " + s.rollNo);
        Console.WriteLine("Name: " + s.name);

        Console.ReadKey();
    }
}