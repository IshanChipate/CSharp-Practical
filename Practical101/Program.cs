using System;

class Student
{
    public int rollNo;
    public string name;

    public void Display()
    {
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Name: " + name);
    }
}

class ClassObjectDemo
{
    static void Main()
    {
        Student s1 = new Student();

        s1.rollNo = 101;
        s1.name = "Ishan";

        s1.Display();

        Console.ReadKey();
    }
}