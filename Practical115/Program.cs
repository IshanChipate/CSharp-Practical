using System;

partial class Student
{
    public void ShowName()
    {
        Console.WriteLine("Name: Ishan");
    }
}

partial class Student
{
    public void ShowMarks()
    {
        Console.WriteLine("Marks: 95");
    }
}

class PartialClassDemo
{
    static void Main()
    {
        Student s = new Student();

        s.ShowName();
        s.ShowMarks();

        Console.ReadKey();
    }
}