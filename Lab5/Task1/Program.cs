using System;

class Program
{
    static double ComputeExpressionA(double x)
    {
        try
        {
            if (9 * x - 9 == 0)
                throw new DivideByZeroException("Деление на ноль в выражении 1!");

            return Math.Cos(x * x) / (9 * x - 9) + Math.Pow(Math.Sin(x), 3);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
            return double.NaN; 
        }
    }

    static double ComputeExpressionB(double x)
    {
        try
        {
            if (x == 0)
                throw new DivideByZeroException("Деление на ноль в выражении 2!");

            return Math.Pow(Math.Sin(x), 3) / Math.Pow(x, 3);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
            return double.NaN;
        }
    }

    static void Main()
    {
        try
        {
            Console.WriteLine("Введите значение x:");
            double x = Convert.ToDouble(Console.ReadLine());

            double resultA = ComputeExpressionA(x);
            double resultB = ComputeExpressionB(x);

            Console.WriteLine($"Результат выражения 1: {resultA}");
            Console.WriteLine($"Результат выражения 2: {resultB}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Ошибка: введено некорректное число! " + ex.Message);
        }
    }
}
