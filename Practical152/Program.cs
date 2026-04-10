using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsIssued { get; set; }
}

class LibraryManagementSystem
{
    static List<Book> books = new List<Book>();

    static void AddBook()
    {
        Book b = new Book();

        Console.Write("Enter Book ID: ");
        b.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Title: ");
        b.Title = Console.ReadLine();

        Console.Write("Enter Author: ");
        b.Author = Console.ReadLine();

        b.IsIssued = false;

        books.Add(b);
        Console.WriteLine("Book added successfully");
    }

    static void ViewBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available");
            return;
        }

        foreach (var b in books)
        {
            Console.WriteLine($"{b.Id} | {b.Title} | {b.Author} | {(b.IsIssued ? "Issued" : "Available")}");
        }
    }

    static void SearchBook()
    {
        Console.Write("Enter Book ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var book = books.FirstOrDefault(b => b.Id == id);

        if (book != null)
            Console.WriteLine($"{book.Id} | {book.Title} | {book.Author} | {(book.IsIssued ? "Issued" : "Available")}");
        else
            Console.WriteLine("Book not found");
    }

    static void IssueBook()
    {
        Console.Write("Enter Book ID to issue: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var book = books.FirstOrDefault(b => b.Id == id);

        if (book != null && !book.IsIssued)
        {
            book.IsIssued = true;
            Console.WriteLine("Book issued successfully");
        }
        else
        {
            Console.WriteLine("Book not available");
        }
    }

    static void ReturnBook()
    {
        Console.Write("Enter Book ID to return: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var book = books.FirstOrDefault(b => b.Id == id);

        if (book != null && book.IsIssued)
        {
            book.IsIssued = false;
            Console.WriteLine("Book returned successfully");
        }
        else
        {
            Console.WriteLine("Invalid return");
        }
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== Library Management System =====");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Search Book");
            Console.WriteLine("4. Issue Book");
            Console.WriteLine("5. Return Book");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: AddBook(); break;
                case 2: ViewBooks(); break;
                case 3: SearchBook(); break;
                case 4: IssueBook(); break;
                case 5: ReturnBook(); break;
                case 0: Console.WriteLine("Exiting..."); break;
                default: Console.WriteLine("Invalid choice"); break;
            }

        } while (choice != 0);
    }
}