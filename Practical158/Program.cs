using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Marks { get; set; }
}

class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(
        "Server=localhost\\SQLEXPRESS;Database=EFCoreDB;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}

class EFCoreCrud
{
    static void Add()
    {
        using var db = new AppDbContext();

        Student s = new Student();

        Console.Write("Enter Name: ");
        s.Name = Console.ReadLine();

        Console.Write("Enter Marks: ");
        s.Marks = Convert.ToDouble(Console.ReadLine());

        db.Students.Add(s);
        db.SaveChanges();

        Console.WriteLine("Record Added");
    }

    static void View()
    {
        using var db = new AppDbContext();

        var students = db.Students.ToList();

        foreach (var s in students)
        {
            Console.WriteLine($"{s.Id} | {s.Name} | {s.Marks}");
        }
    }

    static void Update()
    {
        using var db = new AppDbContext();

        Console.Write("Enter Id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var student = db.Students.Find(id);

        if (student != null)
        {
            Console.Write("Enter new Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter new Marks: ");
            student.Marks = Convert.ToDouble(Console.ReadLine());

            db.SaveChanges();
            Console.WriteLine("Updated");
        }
    }

    static void Delete()
    {
        using var db = new AppDbContext();

        Console.Write("Enter Id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var student = db.Students.Find(id);

        if (student != null)
        {
            db.Students.Remove(student);
            db.SaveChanges();
            Console.WriteLine("Deleted");
        }
    }

    static void Main()
    {
        using (var db = new AppDbContext())
        {
            db.Database.EnsureCreated();
        }

        int choice;

        do
        {
            Console.WriteLine("\n--- EF Core CRUD ---");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. View");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("0. Exit");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: Add(); break;
                case 2: View(); break;
                case 3: Update(); break;
                case 4: Delete(); break;
            }

        } while (choice != 0);
    }
}