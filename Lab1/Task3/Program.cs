using System;

class Program
{
    static void Main(string[] args)
    {
        double x = 3.5;

        double cosSquared = Math.Pow(Math.Cos(x), 2);
        double sqrtXCube = Math.Sqrt(Math.Pow(x, 3));
        double expLn2X = Math.Exp(Math.Log(2 * x));
        double denominator = Math.Sin(x) + expLn2X;

        double y = cosSquared - (sqrtXCube + 1) / denominator;

        Console.WriteLine("Значение функции y: " + y);
    }
}
