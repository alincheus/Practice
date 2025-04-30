using System;

class Program
{
    public delegate double MathOperation(double a, double b);

    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Деление на ноль невозможно.");
        }
        return a / b;
    }

    static void Main(string[] args)
    {
        MathOperation operation;

        try
        {
            Console.WriteLine("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            operation = Add;
            Console.WriteLine($"Сложение: {operation(num1, num2):F2}");

            operation = Subtract;
            Console.WriteLine($"Вычитание: {operation(num1, num2):F2}");

            operation = Divide;
            Console.WriteLine($"Деление: {operation(num1, num2):F2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Неверный формат ввода числа.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
        }
    }
}
