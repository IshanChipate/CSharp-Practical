using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
}

class InventorySystem
{
    static List<Product> products = new List<Product>();

    static void AddProduct()
    {
        Product p = new Product();

        Console.Write("Enter Product ID: ");
        p.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Product Name: ");
        p.Name = Console.ReadLine();

        Console.Write("Enter Quantity: ");
        p.Quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Price: ");
        p.Price = Convert.ToDouble(Console.ReadLine());

        products.Add(p);
        Console.WriteLine("Product added successfully");
    }

    static void ViewProducts()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No products available");
            return;
        }

        foreach (var p in products)
        {
            Console.WriteLine($"{p.Id} | {p.Name} | Qty: {p.Quantity} | Price: {p.Price}");
        }
    }

    static void UpdateQuantity()
    {
        Console.Write("Enter Product ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var product = products.FirstOrDefault(p => p.Id == id);

        if (product != null)
        {
            Console.Write("Enter new quantity: ");
            product.Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quantity updated");
        }
        else
        {
            Console.WriteLine("Product not found");
        }
    }

    static void SearchProduct()
    {
        Console.Write("Enter Product ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var product = products.FirstOrDefault(p => p.Id == id);

        if (product != null)
        {
            Console.WriteLine($"{product.Id} | {product.Name} | Qty: {product.Quantity} | Price: {product.Price}");
        }
        else
        {
            Console.WriteLine("Product not found");
        }
    }

    static void DeleteProduct()
    {
        Console.Write("Enter Product ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var product = products.FirstOrDefault(p => p.Id == id);

        if (product != null)
        {
            products.Remove(product);
            Console.WriteLine("Product deleted");
        }
        else
        {
            Console.WriteLine("Product not found");
        }
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== Inventory Management System =====");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View Products");
            Console.WriteLine("3. Update Quantity");
            Console.WriteLine("4. Search Product");
            Console.WriteLine("5. Delete Product");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: AddProduct(); break;
                case 2: ViewProducts(); break;
                case 3: UpdateQuantity(); break;
                case 4: SearchProduct(); break;
                case 5: DeleteProduct(); break;
                case 0: Console.WriteLine("Exiting..."); break;
                default: Console.WriteLine("Invalid choice"); break;
            }

        } while (choice != 0);
    }
}