using System;
using System.Collections.Generic;
using System.Linq;

class Account
{
    public int AccountNumber { get; set; }
    public string Name { get; set; }
    public double Balance { get; set; }
}

class BankingSystem
{
    static List<Account> accounts = new List<Account>();

    static void CreateAccount()
    {
        Account acc = new Account();

        Console.Write("Enter Account Number: ");
        acc.AccountNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        acc.Name = Console.ReadLine();

        Console.Write("Enter Initial Balance: ");
        acc.Balance = Convert.ToDouble(Console.ReadLine());

        accounts.Add(acc);
        Console.WriteLine("Account created successfully");
    }

    static Account FindAccount(int accNo)
    {
        return accounts.FirstOrDefault(a => a.AccountNumber == accNo);
    }

    static void Deposit()
    {
        Console.Write("Enter Account Number: ");
        int accNo = Convert.ToInt32(Console.ReadLine());

        var acc = FindAccount(accNo);

        if (acc != null)
        {
            Console.Write("Enter amount to deposit: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            acc.Balance += amount;
            Console.WriteLine("Deposit successful");
        }
        else
        {
            Console.WriteLine("Account not found");
        }
    }

    static void Withdraw()
    {
        Console.Write("Enter Account Number: ");
        int accNo = Convert.ToInt32(Console.ReadLine());

        var acc = FindAccount(accNo);

        if (acc != null)
        {
            Console.Write("Enter amount to withdraw: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount <= acc.Balance)
            {
                acc.Balance -= amount;
                Console.WriteLine("Withdrawal successful");
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
        else
        {
            Console.WriteLine("Account not found");
        }
    }

    static void CheckBalance()
    {
        Console.Write("Enter Account Number: ");
        int accNo = Convert.ToInt32(Console.ReadLine());

        var acc = FindAccount(accNo);

        if (acc != null)
        {
            Console.WriteLine("Current Balance: " + acc.Balance);
        }
        else
        {
            Console.WriteLine("Account not found");
        }
    }

    static void ViewAccounts()
    {
        if (accounts.Count == 0)
        {
            Console.WriteLine("No accounts available");
            return;
        }

        foreach (var acc in accounts)
        {
            Console.WriteLine($"{acc.AccountNumber} | {acc.Name} | {acc.Balance}");
        }
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== Banking System =====");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Check Balance");
            Console.WriteLine("5. View Accounts");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: CreateAccount(); break;
                case 2: Deposit(); break;
                case 3: Withdraw(); break;
                case 4: CheckBalance(); break;
                case 5: ViewAccounts(); break;
                case 0: Console.WriteLine("Exiting..."); break;
                default: Console.WriteLine("Invalid choice"); break;
            }

        } while (choice != 0);
    }
}