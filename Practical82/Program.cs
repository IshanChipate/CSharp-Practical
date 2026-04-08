using System;

class SecondLargest
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

        int largest = arr[0];
        int secondLargest = arr[0];

        for (int i = 1; i < n; i++)
        {
            if (arr[i] > largest)
            {
                secondLargest = largest;
                largest = arr[i];
            }
            else if (arr[i] > secondLargest && arr[i] != largest)
            {
                secondLargest = arr[i];
            }
        }

        Console.WriteLine("Second largest element = " + secondLargest);

        Console.ReadKey();
    }
}