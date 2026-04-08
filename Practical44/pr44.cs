using System;

class VarDynamicDemo
{
    static void Main()
    {
        var a = 10;
        Console.WriteLine("var integer: " + a);

        var b = "Hello";
        Console.WriteLine("var string: " + b);

        dynamic x = 20;
        Console.WriteLine("dynamic integer: " + x);

        x = "Welcome";
        Console.WriteLine("dynamic string: " + x);

        Console.ReadKey();
    }
}