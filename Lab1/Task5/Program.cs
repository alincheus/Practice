using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите радиус круга (в сантиметрах):");
        double radius = Convert.ToDouble(Console.ReadLine());
        double circleArea = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"Площадь круга: {circleArea:F2} кв. см.");

        Console.WriteLine("\nВведите длину прямоугольника (в сантиметрах):");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите ширину прямоугольника (в сантиметрах):");
        double width = Convert.ToDouble(Console.ReadLine());
        double rectangleArea = length * width;
        Console.WriteLine($"Площадь прямоугольника: {rectangleArea:F2} кв. см.");
    }
}
