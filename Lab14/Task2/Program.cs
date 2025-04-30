using System;

class Program
{
    public delegate double MathOperation(double a, double b);

    public static void PerformOperation(MathOperation operation, double a, double b)
    {
        try
        {
            double result = operation(a, b); 
            Console.WriteLine($"Результат операции: {result:F2}");
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
        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Выберите операцию: Add, Subtract, Divide");
        string operation = Console.ReadLine();

        switch (operation.ToLower())
        {
            case "add":
                PerformOperation(Add, num1, num2);
                break;
            case "subtract":
                PerformOperation(Subtract, num1, num2);
                break;
            case "divide":
                PerformOperation(Divide, num1, num2);
                break;
            default:
                Console.WriteLine("Ошибка: Неверная операция.");
                break;
        }
    }
}
