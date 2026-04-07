using System;

class TypeCastingDemo
{
    static void Main()
    {
        int a = 10;
        double b;

        b = a;   // Implicit casting
        Console.WriteLine("Implicit Casting (int to double): " + b);

        double x = 9.78;
        int y;

        y = (int)x;   // Explicit casting
        Console.WriteLine("Explicit Casting (double to int): " + y);

        Console.ReadKey();
    }
}