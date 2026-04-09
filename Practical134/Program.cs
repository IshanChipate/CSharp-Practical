using System;

delegate int Operation(int a, int b);

class DelegateDemo
{
    static int Add(int x, int y)
    {
        return x + y;
    }

    static int Multiply(int x, int y)
    {
        return x * y;
    }

    static void Main()
    {
        Operation op;

        op = Add;
        Console.WriteLine("Addition = " + op(10, 20));

        op = Multiply;
        Console.WriteLine("Multiplication = " + op(5, 4));

        Console.ReadKey();
    }
}