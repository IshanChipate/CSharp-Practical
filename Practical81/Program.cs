using System;

class ArrayMethodDemo
{
    static void Display(int[] arr)
    {
        Console.WriteLine("Array elements:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }

    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        Display(numbers);

        Console.ReadKey();
    }
}