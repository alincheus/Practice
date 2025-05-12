using System;

/// <summary>
/// Класс FunctionTable для вычисления значений функции и построения таблицы.
/// </summary>
class FunctionTable
{
    /// <summary>
    /// Вычисляет значение функции f(x) в зависимости от условий.
    /// </summary>
    /// <param name="x">Значение переменной x.</param>
    /// <param name="a">Параметр a.</param>
    /// <param name="b">Параметр b.</param>
    /// <returns>Значение функции f(x).</returns>
    public static double CalculateFunction(double x, double a, double b)
    {
        if (x >= 0.9)
            return 1 / Math.Pow(b + x, 2);
        else if (x >= 0 && x < 0.9)
            return a * x + 0.1;
        else
            return Math.Pow(x, 2) + b;
    }

    /// <summary>
    /// Строит таблицу значений функции на заданном интервале.
    /// </summary>
    /// <param name="a">Начальное значение диапазона.</param>
    /// <param name="b">Конечное значение диапазона.</param>
    /// <param name="h">Шаг изменения x.</param>
    public static void BuildTable(double a, double b, double h)
    {
        Console.WriteLine("Таблица значений функции:");
        Console.WriteLine("----------------------------");
        Console.WriteLine("|   x   |    f(x)    |");
        Console.WriteLine("----------------------------");

        for (double x = a; x <= b; x += h)
        {
            double y = CalculateFunction(x, a, b);
            Console.WriteLine($"| {x:F2} | {y:F6} |");
        }

        Console.WriteLine("----------------------------");
    }

    /// <summary>
    /// Главный метод программы. Запрашивает у пользователя параметры функции и строит таблицу значений.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Введите значение a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение b:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите шаг h:");
        double h = Convert.ToDouble(Console.ReadLine());

        BuildTable(a, b, h);
    }
}
