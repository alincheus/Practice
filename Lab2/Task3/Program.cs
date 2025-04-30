using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите два целых числа K и N (1 <= K, N <= 100):");

        Console.Write("K: ");
        int K = Convert.ToInt32(Console.ReadLine());

        Console.Write("N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        if (K >= 1 && K <= 100 && N >= 1 && N <= 100)
        {
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(K);
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Числа K и N должны быть в диапазоне от 1 до 100.");
        }
    }
}
