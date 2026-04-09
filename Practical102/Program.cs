using System;

class Student
{
    int rollNo;
    string name;

    public Student(int r, string n)
    {
        rollNo = r;
        name = n;
    }

    public void Display()
    {
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Name: " + name);
    }
}

class ConstructorDemo
{
    static void Main()
    {
        Student s1 = new Student(101, "Ishan");
        s1.Display();

        Console.ReadKey();
    }
}