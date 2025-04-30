using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество строк массива:");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов массива:");
        int cols = Convert.ToInt32(Console.ReadLine());

        if (cols < 2)
        {
            Console.WriteLine("Ошибка: в массиве должно быть минимум 2 столбца.");
            return;
        }

        int[,] matrix = new int[rows, cols];
        Random rand = new Random();

        Console.WriteLine("\nИсходный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rand.Next(1, 21);
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int product = 1;
        for (int i = 0; i < rows; i++)
        {
            product *= matrix[i, 1]; 
        }

        bool isThreeDigit = product >= 100 && product <= 999;

        Console.WriteLine($"\nПроизведение элементов второго столбца: {product}");
        Console.WriteLine(isThreeDigit ? "Произведение является трехзначным числом." : "Произведение НЕ является трехзначным числом.");
    }
}
