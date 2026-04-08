using System;

class ValueReferenceDemo
{
    static void Main()
    {
        int a = 10;
        int b = a;
        b = 20;

        Console.WriteLine("Value Type:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = arr1;
        arr2[0] = 99;

        Console.WriteLine("\nReference Type:");
        Console.WriteLine("arr1[0] = " + arr1[0]);
        Console.WriteLine("arr2[0] = " + arr2[0]);

        Console.ReadKey();
    }
}