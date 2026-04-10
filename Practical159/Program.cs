using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}

class Sale
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}

class MiniERP
{
    static List<Employee> employees = new List<Employee>();
    static List<Product> products = new List<Product>();
    static List<Sale> sales = new List<Sale>();

    static void AddEmployee()
    {
        Employee e = new Employee();

        Console.Write("Employee ID: ");
        e.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Employee Name: ");
        e.Name = Console.ReadLine();

        employees.Add(e);
        Console.WriteLine("Employee Added");
    }

    static void AddProduct()
    {
        Product p = new Product();

        Console.Write("Product ID: ");
        p.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Product Name: ");
        p.Name = Console.ReadLine();

        Console.Write("Price: ");
        p.Price = Convert.ToDouble(Console.ReadLine());

        products.Add(p);
        Console.WriteLine("Product Added");
    }

    static void AddSale()
    {
        Sale s = new Sale();

        Console.Write("Product ID: ");
        s.ProductId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Quantity: ");
        s.Quantity = Convert.ToInt32(Console.ReadLine());

        sales.Add(s);
        Console.WriteLine("Sale Recorded");
    }

    static void ViewEmployees()
    {
        foreach (var e in employees)
            Console.WriteLine($"{e.Id} | {e.Name}");
    }

    static void ViewProducts()
    {
        foreach (var p in products)
            Console.WriteLine($"{p.Id} | {p.Name} | {p.Price}");
    }

    static void ViewSales()
    {
        foreach (var s in sales)
        {
            var product = products.FirstOrDefault(p => p.Id == s.ProductId);

            if (product != null)
            {
                double total = product.Price * s.Quantity;
                Console.WriteLine($"{product.Name} | Qty: {s.Quantity} | Total: {total}");
            }
        }
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- Mini ERP System ---");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Add Product");
            Console.WriteLine("3. Add Sale");
            Console.WriteLine("4. View Employees");
            Console.WriteLine("5. View Products");
            Console.WriteLine("6. View Sales");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: AddEmployee(); break;
                case 2: AddProduct(); break;
                case 3: AddSale(); break;
                case 4: ViewEmployees(); break;
                case 5: ViewProducts(); break;
                case 6: ViewSales(); break;
            }

        } while (choice != 0);
    }
}