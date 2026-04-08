using System;

class MultiDimensionalArrayDemo
{
    static void Main()
    {
        int[,] arr = {
            {1, 2, 3},
            {4, 5, 6}
        };

        Console.WriteLine("Multidimensional Array:");

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}