using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение x:");
        double x = Convert.ToDouble(Console.ReadLine());
        double y;

        if (x >= 1 && x <= 2)
        {
            y = Math.Pow(x, 2) * Math.Log(x);
        }
        else if (x < 1)
        {
            y = 1;
        }
        else // x > 2
        {
            y = Math.Exp(2 * x) * Math.Cos(5 * x);
        }

        Console.WriteLine($"Значение функции y: {y:F6}");
    }
}
