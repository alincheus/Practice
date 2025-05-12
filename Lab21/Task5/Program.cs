using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 5, 8, 40, 70 };
        int sumLimit = 535;
        int productLimit = 535;

        Console.WriteLine("Запуск параллельных вычислений...");

        Parallel.ForEach(numbers, (N, state) =>
        {
            int sum = 0;
            int product = 1;

            for (int i = 1; i <= N; i++)
            {
                sum += i;
                product *= i;

                if (sum > sumLimit || product > productLimit)
                {
                    Console.WriteLine($"Прерывание при N={N}: сумма={sum}, произведение={product}");
                    state.Break();
                    break;
                }
            }

            Console.WriteLine($"Для N={N}: сумма={sum}, произведение={product}");
        });

        Console.WriteLine("Параллельные вычисления завершены!");
    }
}
