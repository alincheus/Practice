using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите размер квадратной матрицы N (N < 10):");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N <= 0 || N >= 10)
        {
            Console.WriteLine("Ошибка: N должно быть в диапазоне от 1 до 9.");
            return;
        }

        Console.WriteLine("Введите диапазон случайных чисел [a, b]:");
        Console.Write("a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("Ошибка: a должно быть меньше или равно b.");
            return;
        }

        int[,] matrix = new int[N, N];
        Random rand = new Random();

        for (int i = 0; i < N; i++)
            for (int j = 0; j < N; j++)
                matrix[i, j] = rand.Next(a, b + 1);

        Console.WriteLine("\nИсходная матрица:");
        PrintMatrix(matrix, N);

        int positiveCount = CountPositiveNumbers(matrix, N);
        Console.WriteLine($"\nКоличество положительных чисел: {positiveCount}");

        Console.WriteLine("\nСумма элементов каждой строки:");
        ComputeRowSums(matrix, N);
    }

    static void PrintMatrix(int[,] matrix, int N)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
                Console.Write(matrix[i, j] + "\t");
            Console.WriteLine();
        }
    }

    static int CountPositiveNumbers(int[,] matrix, int N)
    {
        int count = 0;
        for (int i = 0; i < N; i++)
            for (int j = 0; j < N; j++)
                if (matrix[i, j] > 0)
                    count++;

        return count;
    }

    static void ComputeRowSums(int[,] matrix, int N)
    {
        for (int i = 0; i < N; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < N; j++)
                rowSum += matrix[i, j];

            Console.WriteLine($"Сумма строки {i + 1}: {rowSum}");
        }
    }
}
