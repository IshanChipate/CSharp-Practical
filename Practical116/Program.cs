using System;

class Vehicle
{
    public virtual void Show()
    {
        Console.WriteLine("This is a vehicle");
    }
}

class Car : Vehicle
{
    public override void Show()
    {
        Console.WriteLine("This is a car");
    }
}

class VirtualOverrideDemo
{
    static void Main()
    {
        Vehicle v = new Vehicle();
        v.Show();

        Vehicle c = new Car();
        c.Show();

        Console.ReadKey();
    }
}