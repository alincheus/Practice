using System;

/// <summary>
/// Основной класс программы, выполняющий простые арифметические операции с использованием делегатов.
/// </summary>
class Program
{
    /// <summary>
    /// Делегат для выполнения математических операций с двумя числами.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <returns>Результат выполнения операции.</returns>
    static void Main(string[] args)
    {
        /// <summary>
        /// Выполняет сложение двух чисел.
        /// </summary>
        Func<double, double, double> Add = (a, b) => a + b;

        /// <summary>
        /// Выполняет вычитание двух чисел.
        /// </summary>
        Func<double, double, double> Sub = (a, b) => a - b;

        /// <summary>
        /// Выполняет умножение двух чисел.
        /// </summary>
        Func<double, double, double> Mul = (a, b) => a * b;

        /// <summary>
        /// Выполняет деление двух чисел, проверяя деление на ноль.
        /// </summary>
        /// <param name="b">Делитель. Если равно нулю, возвращает NaN.</param>
        Func<double, double, double> Div = (a, b) => 
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: Деление на ноль невозможно.");
                return double.NaN; 
            }
            return a / b;
        };

        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Выберите операцию: Add, Sub, Mul, Div");
        string operation = Console.ReadLine();

        switch (operation.ToLower())
        {
            case "add":
                Console.WriteLine($"Результат сложения: {Add(num1, num2)}");
                break;
            case "sub":
                Console.WriteLine($"Результат вычитания: {Sub(num1, num2)}");
                break;
            case "mul":
                Console.WriteLine($"Результат умножения: {Mul(num1, num2)}");
                break;
            case "div":
                Console.WriteLine($"Результат деления: {Div(num1, num2)}");
                break;
            default:
                Console.WriteLine("Ошибка: Неверная операция.");
                break;
        }
    }
}
