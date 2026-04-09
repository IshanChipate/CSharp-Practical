using System;

class Calculator<T> where T : struct
{
    public void Display(T value)
    {
        Console.WriteLine("Value: " + value);
    }
}

class GenericConstraintDemo
{
    static void Main()
    {
        Calculator<int> obj1 = new Calculator<int>();
        obj1.Display(100);

        Calculator<double> obj2 = new Calculator<double>();
        obj2.Display(45.5);

        Console.ReadKey();
    }
}