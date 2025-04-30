using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите коэффициенты A, B и C:");
        Console.Write("A: ");
        double A = Convert.ToDouble(Console.ReadLine());
        Console.Write("B: ");
        double B = Convert.ToDouble(Console.ReadLine());
        Console.Write("C: ");
        double C = Convert.ToDouble(Console.ReadLine());

        double D = Math.Pow(B, 2) - 4 * A * C;

        if (D >= 0)
        {
            Console.WriteLine("Утверждение истинно: уравнение имеет вещественные корни.");
        }
        else
        {
            Console.WriteLine("Утверждение ложно: уравнение не имеет вещественных корней.");
        }
    }
}
