using System;

abstract class Shape
{
    public abstract void Draw();

    public void Display()
    {
        Console.WriteLine("This is abstract class method");
    }
}

interface IColor
{
    void FillColor();
}

class Circle : Shape, IColor
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }

    public void FillColor()
    {
        Console.WriteLine("Filling Color in Circle");
    }
}

class AbstractVsInterfaceDemo
{
    static void Main()
    {
        Circle c = new Circle();

        c.Display();
        c.Draw();
        c.FillColor();

        Console.ReadKey();
    }
}