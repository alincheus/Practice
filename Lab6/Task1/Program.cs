using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[15];
        Random rand = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(1, 101);
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(numbers);

        int maxIndex = 0;
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > numbers[maxIndex])
            {
                maxIndex = i;
            }
        }

        int temp = numbers[0];
        numbers[0] = numbers[maxIndex];
        numbers[maxIndex] = temp;

        Console.WriteLine("\nМассив после перестановки:");
        PrintArray(numbers);
    }

    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
