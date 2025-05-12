using System;

/// <summary>
/// Основной класс программы для вычисления третьей степени числа.
/// </summary>
class Program
{
    /// <summary>
    /// Вычисляет третью степень числа.
    /// </summary>
    /// <param name="A">Входное число.</param>
    /// <param name="B">Результат возведения в третью степень.</param>
    static void PowerA3(double A, out double B)
    {
        B = Math.Pow(A, 3);
    }

    /// <summary>
    /// Главный метод программы. Запрашивает у пользователя 5 вещественных чисел 
    /// и выводит их третью степень.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Введите 5 вещественных чисел:");
        double[] numbers = new double[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Число {i + 1}: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("\nТретьи степени введенных чисел:");
        for (int i = 0; i < 5; i++)
        {
            double result;
            PowerA3(numbers[i], out result);
            Console.WriteLine($"Число {numbers[i]} в третьей степени: {result}");
        }
    }
}
