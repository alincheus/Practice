using System;

class Program
{
    static void Main(string[] args)
    {
        double A = 0;
        double B = Math.PI / 2;
        int M = 10;

        double H = (B - A) / M;
        Console.WriteLine("Таблица значений функции:");

        for (int i = 0; i <= M; i++)
        {
            double x = A + i * H;
            double y = x - Math.Sin(x);

            Console.WriteLine($"x = {x:F4}, y = {y:F6}");
        }
    }
}
