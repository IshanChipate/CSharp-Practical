using System;

class ArraySumAverage
{
    static void Main()
    {
        int n;
        int sum = 0;

        Console.Write("Enter number of elements: ");
        n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter array elements:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            sum += arr[i];
        }

        double average = (double)sum / n;

        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Average = " + average);

        Console.ReadKey();
    }
}