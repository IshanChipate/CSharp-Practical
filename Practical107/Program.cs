using System;

abstract class Shape
{
    public abstract void Draw();
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Rectangle");
    }
}

class AbstractionDemo
{
    static void Main()
    {
        Shape s;

        s = new Circle();
        s.Draw();

        s = new Rectangle();
        s.Draw();

        Console.ReadKey();
    }
}