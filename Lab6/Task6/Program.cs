using System;

class Program
{
    static void Main()
    {
        int N = 7;
        int[,] matrix = new int[N, N];

        FillSpiralMatrix(matrix, N);
        PrintMatrix(matrix, N);
    }

    static void FillSpiralMatrix(int[,] matrix, int size)
    {
        int num = 1;
        int left = 0, right = size - 1, top = 0, bottom = size - 1;

        while (num <= size * size)
        {
            for (int i = left; i <= right && num <= size * size; i++)
                matrix[top, i] = num++;

            top++; 

            for (int i = top; i <= bottom && num <= size * size; i++)
                matrix[i, right] = num++;

            right--; 

            for (int i = right; i >= left && num <= size * size; i--)
                matrix[bottom, i] = num++;

            bottom--; 

            for (int i = bottom; i >= top && num <= size * size; i--)
                matrix[i, left] = num++;

            left++; 
        }
    }

    static void PrintMatrix(int[,] matrix, int size)
    {
        Console.WriteLine("\nСпиральная матрица:");
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
                Console.Write(matrix[i, j].ToString().PadLeft(3) + " ");
            Console.WriteLine();
        }
    }
}
