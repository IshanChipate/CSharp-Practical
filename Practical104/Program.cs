using System;

class Person
{
    public string name;

    public void ShowName()
    {
        Console.WriteLine("Name: " + name);
    }
}

class Student : Person
{
    public int marks;

    public void ShowMarks()
    {
        Console.WriteLine("Marks: " + marks);
    }
}

class InheritanceDemo
{
    static void Main()
    {
        Student s = new Student();

        s.name = "Ishan";
        s.marks = 95;

        s.ShowName();
        s.ShowMarks();

        Console.ReadKey();
    }
}