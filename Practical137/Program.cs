using System;

class FuncActionPredicateDemo
{
    static void Main()
    {
        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine("Func (Sum) = " + add(10, 20));

        Action<string> greet = name => Console.WriteLine("Hello " + name);
        greet("Ishan");

        Predicate<int> isEven = n => n % 2 == 0;

        int number = 4;
        Console.WriteLine("Predicate (Is Even) = " + isEven(number));

        Console.ReadKey();
    }
}