using GeometryLibrary.Shapes;
using System;

namespace TestApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Тестируем библиотеку GeometryLibrary!");

            Triangle triangle = new Triangle(3, 4, 5);
            Console.WriteLine($"Периметр треугольника: {triangle.GetPerimeter()}");
            Console.WriteLine($"Площадь треугольника: {triangle.GetArea()}");
            Console.WriteLine($"Вид треугольника: {triangle.GetTriangleType()}");

            Rectangle rectangle = new Rectangle(5, 10);
            Console.WriteLine($"Периметр прямоугольника: {rectangle.GetPerimeter()}");
            Console.WriteLine($"Площадь прямоугольника: {rectangle.GetArea()}");
        }
    }
}
