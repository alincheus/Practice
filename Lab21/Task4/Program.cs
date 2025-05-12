using System;
using System.Threading.Tasks;

class Program
{
    /// <summary>
    /// Вычисляет значение функции f(x) = x - sin(x).
    /// </summary>
    /// <param name="x">Значение переменной x.</param>
    /// <returns>Результат функции f(x).</returns>
    static double ComputeFunction(double x)
    {
        return x - Math.Sin(x);
    }

    static void Main()
    {
        double A = 0, B = 10;
        double step = 0.1; 

        Console.WriteLine($"Вычисление функции f(x) = x - sin(x) на интервале [{A}, {B}]");

        Parallel.For(0, (int)((B - A) / step) + 1, i =>
        {
            double x = A + i * step;
            double result = ComputeFunction(x);
            Console.WriteLine($"f({x:F2}) = {result:F6}");
        });

        Console.WriteLine("Параллельное вычисление завершено!");
    }
}
