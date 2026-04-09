using System;

class Base
{
    private int privateVar = 10;
    protected int protectedVar = 20;
    public int publicVar = 30;

    public void ShowBase()
    {
        Console.WriteLine("Private: " + privateVar);
        Console.WriteLine("Protected: " + protectedVar);
        Console.WriteLine("Public: " + publicVar);
    }
}

class Derived : Base
{
    public void ShowDerived()
    {
        Console.WriteLine("Accessing protected in derived: " + protectedVar);
        Console.WriteLine("Accessing public in derived: " + publicVar);
    }
}

class AccessSpecifierDemo
{
    static void Main()
    {
        Base b = new Base();
        b.ShowBase();

        Console.WriteLine();

        Derived d = new Derived();
        d.ShowDerived();

        Console.ReadKey();
    }
}