using System;

/// <summary>
/// Основной класс программы для выполнения операций сложения.
/// </summary>
class Program
{
    /// <summary>
    /// Вычисляет сумму двух целых чисел.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <returns>Сумма двух чисел.</returns>
    static int Sum(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Вычисляет сумму трёх целых чисел.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <param name="c">Третье число.</param>
    /// <returns>Сумма трёх чисел.</returns>
    static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    /// <summary>
    /// Главный метод программы. Запрашивает у пользователя несколько целых чисел, 
    /// выполняет сложение и выводит результат.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Введите значения a1, b1, a2, b2, c2:");
        Console.Write("a1: ");
        int a1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("b1: ");
        int b1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("a2: ");
        int a2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("b2: ");
        int b2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("c2: ");
        int c2 = Convert.ToInt32(Console.ReadLine());

        int result = Sum(a1, b1) + Sum(a2, b2, c2);
        Console.WriteLine($"Результат выражения Sum(a1, b1) + Sum(a2, b2, c2): {result}");
    }
}
