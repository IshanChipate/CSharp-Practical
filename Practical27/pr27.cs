using System;

class ConstantReadonly
{
    const double PI = 3.14159;
    readonly int value;

    public ConstantReadonly(int v)
    {
        value = v;
    }

    static void Main()
    {
        Console.WriteLine("Constant PI = " + PI);

        ConstantReadonly obj = new ConstantReadonly(100);
        Console.WriteLine("Readonly value = " + obj.value);

        Console.ReadKey();
    }
}