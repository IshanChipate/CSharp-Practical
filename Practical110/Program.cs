using System;

class Student
{
    private int rollNo;
    private string name;

    public int RollNo
    {
        get { return rollNo; }
        set { rollNo = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

class EncapsulationDemo
{
    static void Main()
    {
        Student s = new Student();

        s.RollNo = 101;
        s.Name = "Ishan";

        Console.WriteLine("Roll No: " + s.RollNo);
        Console.WriteLine("Name: " + s.Name);

        Console.ReadKey();
    }
}