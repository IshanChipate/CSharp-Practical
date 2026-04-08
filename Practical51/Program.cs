using System;

class ArrayDemo
{
    static void Main()
    {
        int n;

        Console.Write("Enter number of elements: ");
        n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter array elements:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Array elements are:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.ReadKey();
    }
}