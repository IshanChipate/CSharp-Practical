using System;
using System.Collections.Generic;
using System.Linq;

class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
}

class RoleBasedAuth
{
    static List<User> users = new List<User>
    {
        new User { Username = "admin", Password = "123", Role = "Admin" },
        new User { Username = "ishan", Password = "123", Role = "User" }
    };

    static void AdminMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\n--- Admin Panel ---");
            Console.WriteLine("1. View Users");
            Console.WriteLine("2. Add User");
            Console.WriteLine("0. Logout");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    foreach (var u in users)
                        Console.WriteLine($"{u.Username} | {u.Role}");
                    break;

                case 2:
                    User u1 = new User();

                    Console.Write("Username: ");
                    u1.Username = Console.ReadLine();

                    Console.Write("Password: ");
                    u1.Password = Console.ReadLine();

                    Console.Write("Role (Admin/User): ");
                    u1.Role = Console.ReadLine();

                    users.Add(u1);
                    Console.WriteLine("User added");
                    break;
            }

        } while (choice != 0);
    }

    static void UserMenu(string username)
    {
        Console.WriteLine("\n--- User Panel ---");
        Console.WriteLine("Welcome " + username);
        Console.WriteLine("You have limited access.");
    }

    static void Main()
    {
        Console.Write("Username: ");
        string username = Console.ReadLine();

        Console.Write("Password: ");
        string password = Console.ReadLine();

        var user = users.FirstOrDefault(u =>
            u.Username == username && u.Password == password);

        if (user != null)
        {
            Console.WriteLine("Login successful");

            if (user.Role == "Admin")
                AdminMenu();
            else
                UserMenu(user.Username);
        }
        else
        {
            Console.WriteLine("Invalid credentials");
        }
    }
}