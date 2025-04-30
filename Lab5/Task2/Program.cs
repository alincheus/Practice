using System;

class Program
{
    static double ComputeFunction(double x)
    {
        if (x <= -3 || x > 3)
            throw new ArgumentOutOfRangeException(nameof(x), "Ошибка: x выходит за допустимый диапазон (-3; 3]");

        if (x > -1 && x < 3 && x == 0)
            throw new DivideByZeroException("Ошибка: деление на ноль!");

        if (x > -1 && x < 3)
            return -2 / x;
        else if (x > -3 && x <= -1)
            return 2 * x;
        else
            return x;
    }

    static void Main()
    {
        try
        {
            Console.WriteLine("Введите значение x:");
            double x = Convert.ToDouble(Console.ReadLine());

            double result = ComputeFunction(x);
            Console.WriteLine($"Результат f({x}) = {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введено некорректное число!");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
