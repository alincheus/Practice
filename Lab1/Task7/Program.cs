using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите угол α (в радианах):");
        double alpha = Convert.ToDouble(Console.ReadLine());

        double z1 = Math.Sin(Math.PI / 2 + 3 * alpha) / 
                    (1 - Math.Sin(3 * alpha - Math.PI));

        double z2 = 1 / Math.Tan((5 * Math.PI / 4) + (3 * alpha / 2));

        Console.WriteLine($"Результат по первой формуле (z1): {z1:F6}");
        Console.WriteLine($"Результат по второй формуле (z2): {z2:F6}");

        if (Math.Abs(z1 - z2) < 1e-6)
        {
            Console.WriteLine("Результаты совпадают.");
        }
        else
        {
            Console.WriteLine("Результаты не совпадают.");
        }
    }
}
