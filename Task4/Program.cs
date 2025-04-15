using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты первой точки (x1, y1):");
        Console.Write("x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите координаты второй точки (x2, y2):");
        Console.Write("x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine("Расстояние между двумя точками: " + distance);
    }
}
