using System;

class ReadonlyConstDemo
{
    const double PI = 3.14159;
    readonly int value;

    public ReadonlyConstDemo(int v)
    {
        value = v;
    }

    static void Main()
    {
        Console.WriteLine("Const PI = " + PI);

        ReadonlyConstDemo obj = new ReadonlyConstDemo(100);
        Console.WriteLine("Readonly value = " + obj.value);

        Console.ReadKey();
    }
}