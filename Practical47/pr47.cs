using System;

class TupleDemo
{
    static void Main()
    {
        (int id, string name, double marks) student;

        student.id = 101;
        student.name = "Ishan";
        student.marks = 95.5;

        Console.WriteLine("ID: " + student.id);
        Console.WriteLine("Name: " + student.name);
        Console.WriteLine("Marks: " + student.marks);

        Console.ReadKey();
    }
}