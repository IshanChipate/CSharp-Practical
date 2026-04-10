using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double BasicSalary { get; set; }

    public double CalculateSalary()
    {
        double hra = BasicSalary * 0.20;
        double da = BasicSalary * 0.10;
        double total = BasicSalary + hra + da;
        return total;
    }
}

class PayrollSystem
{
    static List<Employee> employees = new List<Employee>();

    static void AddEmployee()
    {
        Employee emp = new Employee();

        Console.Write("Enter Employee ID: ");
        emp.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        emp.Name = Console.ReadLine();

        Console.Write("Enter Basic Salary: ");
        emp.BasicSalary = Convert.ToDouble(Console.ReadLine());

        employees.Add(emp);
        Console.WriteLine("Employee added successfully");
    }

    static void ViewEmployees()
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No employees found");
            return;
        }

        foreach (var emp in employees)
        {
            Console.WriteLine($"{emp.Id} | {emp.Name} | {emp.BasicSalary} | {emp.CalculateSalary()}");
        }
    }

    static void SearchEmployee()
    {
        Console.Write("Enter Employee ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var emp = employees.FirstOrDefault(e => e.Id == id);

        if (emp != null)
        {
            Console.WriteLine($"ID: {emp.Id}");
            Console.WriteLine($"Name: {emp.Name}");
            Console.WriteLine($"Basic Salary: {emp.BasicSalary}");
            Console.WriteLine($"Total Salary: {emp.CalculateSalary()}");
        }
        else
        {
            Console.WriteLine("Employee not found");
        }
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== Employee Payroll System =====");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View Employees");
            Console.WriteLine("3. Search Employee");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: AddEmployee(); break;
                case 2: ViewEmployees(); break;
                case 3: SearchEmployee(); break;
                case 0: Console.WriteLine("Exiting..."); break;
                default: Console.WriteLine("Invalid choice"); break;
            }

        } while (choice != 0);
    }
}