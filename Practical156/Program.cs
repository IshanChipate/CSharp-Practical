using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class FileCrudApp
{
    static string path = "students.txt";

    static void AddRecord()
    {
        Console.Write("Enter ID: ");
        string id = Console.ReadLine();

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Marks: ");
        string marks = Console.ReadLine();

        string record = $"{id},{name},{marks}";
        File.AppendAllText(path, record + Environment.NewLine);

        Console.WriteLine("Record added successfully");
    }

    static void ViewRecords()
    {
        if (!File.Exists(path))
        {
            Console.WriteLine("No records found");
            return;
        }

        var lines = File.ReadAllLines(path);

        foreach (var line in lines)
        {
            var data = line.Split(',');
            Console.WriteLine($"ID: {data[0]}, Name: {data[1]}, Marks: {data[2]}");
        }
    }

    static void UpdateRecord()
    {
        Console.Write("Enter ID to update: ");
        string id = Console.ReadLine();

        var lines = File.ReadAllLines(path).ToList();

        for (int i = 0; i < lines.Count; i++)
        {
            var data = lines[i].Split(',');

            if (data[0] == id)
            {
                Console.Write("Enter new Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter new Marks: ");
                string marks = Console.ReadLine();

                lines[i] = $"{id},{name},{marks}";
                File.WriteAllLines(path, lines);

                Console.WriteLine("Record updated");
                return;
            }
        }

        Console.WriteLine("Record not found");
    }

    static void DeleteRecord()
    {
        Console.Write("Enter ID to delete: ");
        string id = Console.ReadLine();

        var lines = File.ReadAllLines(path).ToList();

        var newLines = lines.Where(line => line.Split(',')[0] != id);

        File.WriteAllLines(path, newLines);

        Console.WriteLine("Record deleted");
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- File CRUD Application ---");
            Console.WriteLine("1. Add Record");
            Console.WriteLine("2. View Records");
            Console.WriteLine("3. Update Record");
            Console.WriteLine("4. Delete Record");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: AddRecord(); break;
                case 2: ViewRecords(); break;
                case 3: UpdateRecord(); break;
                case 4: DeleteRecord(); break;
            }

        } while (choice != 0);
    }
}