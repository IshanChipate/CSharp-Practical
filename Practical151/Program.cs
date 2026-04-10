using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Marks { get; set; }
}

class StudentManagementSystem
{
    static List<Student> students = new List<Student>();

    static void AddStudent()
    {
        Student s = new Student();

        Console.Write("Enter ID: ");
        s.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        s.Name = Console.ReadLine();

        Console.Write("Enter Marks: ");
        s.Marks = Convert.ToDouble(Console.ReadLine());

        students.Add(s);
        Console.WriteLine("Student Added Successfully");
    }

    static void ViewStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No records found");
            return;
        }

        foreach (var s in students)
        {
            Console.WriteLine($"{s.Id} - {s.Name} - {s.Marks}");
        }
    }

    static void SearchStudent()
    {
        Console.Write("Enter ID to search: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var student = students.FirstOrDefault(s => s.Id == id);

        if (student != null)
            Console.WriteLine($"{student.Id} - {student.Name} - {student.Marks}");
        else
            Console.WriteLine("Student not found");
    }

    static void UpdateStudent()
    {
        Console.Write("Enter ID to update: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var student = students.FirstOrDefault(s => s.Id == id);

        if (student != null)
        {
            Console.Write("Enter new Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter new Marks: ");
            student.Marks = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Updated successfully");
        }
        else
        {
            Console.WriteLine("Student not found");
        }
    }

    static void DeleteStudent()
    {
        Console.Write("Enter ID to delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var student = students.FirstOrDefault(s => s.Id == id);

        if (student != null)
        {
            students.Remove(student);
            Console.WriteLine("Deleted successfully");
        }
        else
        {
            Console.WriteLine("Student not found");
        }
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== Student Management System =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: AddStudent(); break;
                case 2: ViewStudents(); break;
                case 3: SearchStudent(); break;
                case 4: UpdateStudent(); break;
                case 5: DeleteStudent(); break;
                case 0: Console.WriteLine("Exiting..."); break;
                default: Console.WriteLine("Invalid choice"); break;
            }

        } while (choice != 0);
    }
}