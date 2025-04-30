using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[100];
        Random rand = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(1, 201);
        }

        Array.Sort(numbers);

        Console.Write("Введите число для бинарного поиска: ");
        int k = Convert.ToInt32(Console.ReadLine());

        int index = Array.BinarySearch(numbers, k);
        if (index >= 0)
            Console.WriteLine($"Число {k} найдено в позиции {index}.");
        else
            Console.WriteLine($"Число {k} не найдено.");

        Console.WriteLine("\nОтсортированный массив в обратном порядке:");
        for (int i = numbers.Length - 1, count = 0; i >= 0; i--)
        {
            Console.Write(numbers[i] + "\t");
            count++;

            if (count % 6 == 0)
                Console.WriteLine();
        }
    }
}
