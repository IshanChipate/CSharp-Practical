using System;

class CommonElements
{
    static void Main()
    {
        int n1, n2;

        Console.Write("Enter size of first array: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        int[] arr1 = new int[n1];

        Console.WriteLine("Enter first array elements:");
        for (int i = 0; i < n1; i++)
        {
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter size of second array: ");
        n2 = Convert.ToInt32(Console.ReadLine());
        int[] arr2 = new int[n2];

        Console.WriteLine("Enter second array elements:");
        for (int i = 0; i < n2; i++)
        {
            arr2[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Common elements:");

        for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j < n2; j++)
            {
                if (arr1[i] == arr2[j])
                {
                    Console.Write(arr1[i] + " ");
                    break;
                }
            }
        }

        Console.ReadKey();
    }
}