using System;

interface IShape
{
    void Draw();
}

class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Rectangle");
    }
}

class InterfaceDemo
{
    static void Main()
    {
        IShape s;

        s = new Circle();
        s.Draw();

        s = new Rectangle();
        s.Draw();

        Console.ReadKey();
    }
}