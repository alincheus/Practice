using System;
using System.Threading;

class Program
{
    static int[] numbers; 
    static int totalSum = 0; 
    static object locker = new object(); 

    static void CalculatePartialSum(object obj)
    {
        int threadIndex = (int)obj;
        int partialSum = 0;

        for (int i = threadIndex; i < numbers.Length; i += 2) 
        {
            if (numbers[i] % 2 == 0) 
                partialSum += numbers[i];
        }

        lock (locker) 
        {
            totalSum += partialSum;
        }

        Console.WriteLine($"Поток {threadIndex}: частичная сумма = {partialSum}");
    }

    static void Main()
    {
        Console.Write("Введите количество элементов массива: ");
        int size = int.Parse(Console.ReadLine());

        numbers = new int[size];
        Random rand = new Random();

        Console.WriteLine("\nИсходный массив:");
        for (int i = 0; i < size; i++)
        {
            numbers[i] = rand.Next(1, 101);
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        int threadCount = 2; 
        Thread[] threads = new Thread[threadCount];

        for (int i = 0; i < threadCount; i++)
        {
            threads[i] = new Thread(CalculatePartialSum);
            threads[i].Start(i);
        }

        foreach (Thread thread in threads)
        {
            thread.Join();
        }

        Console.WriteLine($"\nОбщая сумма четных чисел: {totalSum}");
    }
}
