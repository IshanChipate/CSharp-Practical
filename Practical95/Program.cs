using System;

class MissingNumber
{
    static void Main()
    {
        int n;

        Console.Write("Enter size of array (n-1): ");
        n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int total = (n + 1) * (n + 2) / 2;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }

        int missing = total - sum;

        Console.WriteLine("Missing number = " + missing);

        Console.ReadKey();
    }
}