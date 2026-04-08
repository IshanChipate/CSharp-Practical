using System;

class MatrixTranspose
{
    static void Main()
    {
        int rows, cols;

        Console.Write("Enter number of rows: ");
        rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Enter matrix elements:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Transpose of matrix:");

        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Console.Write(matrix[j, i] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}