using System;

class Program
{
    static long Factorial(int n)
    {
        if (n <= 1)
            return 1;
        return n * Factorial(n - 1);
    }

    static double ComputeF(int n)
    {
        if (n < 4)
            throw new ArgumentException("Ошибка: n должно быть >= 4 для корректного вычисления!");

        return (double)Factorial(n - 2) / Factorial(n - 4);
    }

    static void Main()
    {
        try
        {
            Console.WriteLine("Введите значение n (n >= 4):");
            int n = Convert.ToInt32(Console.ReadLine());

            double result = ComputeF(n);
            Console.WriteLine($"f({n}) = {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введено некорректное число!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
