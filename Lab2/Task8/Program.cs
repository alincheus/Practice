using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число N (1 <= N <= 10):");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N >= 1 && N <= 10)
        {
            int sum = 0;

            for (int i = N; i <= 2 * N; i++)
            {
                sum += i * i; 
            }

            Console.WriteLine($"Сумма квадратов от {N} до {2 * N}: {sum}");
        }
        else
        {
            Console.WriteLine("Ошибка: число N должно быть в диапазоне от 1 до 10.");
        }
    }
}
