using System;

class Invoice
{
    public int Amount { get; set; }
}

class InvoicePrinter
{
    public void Print(Invoice invoice)
    {
        Console.WriteLine("Invoice Amount: " + invoice.Amount);
    }
}

interface IDiscount
{
    int ApplyDiscount(int amount);
}

class NoDiscount : IDiscount
{
    public int ApplyDiscount(int amount)
    {
        return amount;
    }
}

class FestivalDiscount : IDiscount
{
    public int ApplyDiscount(int amount)
    {
        return amount - 100;
    }
}

class Billing
{
    private IDiscount discount;

    public Billing(IDiscount d)
    {
        discount = d;
    }

    public void GenerateBill(int amount)
    {
        int finalAmount = discount.ApplyDiscount(amount);
        Console.WriteLine("Final Amount: " + finalAmount);
    }
}

class SOLIDDemo
{
    static void Main()
    {
        Invoice inv = new Invoice { Amount = 1000 };
        InvoicePrinter printer = new InvoicePrinter();
        printer.Print(inv);

        Billing bill = new Billing(new FestivalDiscount());
        bill.GenerateBill(inv.Amount);

        Console.ReadKey();
    }
}