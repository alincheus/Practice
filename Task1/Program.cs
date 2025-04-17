using System;

class FunctionTable
{
    public static double CalculateFunction(double x, double a, double b)
    {
        if (x >= 0.9)
            return 1 / Math.Pow(b + x, 2);
        else if (x >= 0 && x < 0.9)
            return a * x + 0.1;
        else
            return Math.Pow(x, 2) + b;
    }

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
