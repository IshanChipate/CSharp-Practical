using System;

class GenericClass<T>
{
    public void Display(T value)
    {
        Console.WriteLine("Value: " + value);
    }
}

class GenericsDemo
{
    static void Main()
    {
        GenericClass<int> obj1 = new GenericClass<int>();
        obj1.Display(10);

        GenericClass<string> obj2 = new GenericClass<string>();
        obj2.Display("Ishan");

        Console.ReadKey();
    }
}