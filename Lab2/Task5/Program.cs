using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите два различных вещественных числа:");

        Console.Write("Первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num1 != num2)
        {
            double max = Math.Max(num1, num2);
            Console.WriteLine($"Максимальное значение: {max}");
        }
        else
        {
            Console.WriteLine("Ошибка: числа должны быть различными.");
        }
    }
}
