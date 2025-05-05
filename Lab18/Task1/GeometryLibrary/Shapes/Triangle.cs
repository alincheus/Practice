using GeometryLibrary.Base;
using System;

namespace GeometryLibrary.Shapes
{
    public class Triangle : Shape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;

            if (!IsValidTriangle())
                throw new ArgumentException("Треугольник с такими сторонами не может существовать.");
        }

        private bool IsValidTriangle() => 
            SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA;

        public override double GetPerimeter() => SideA + SideB + SideC;

        public override double GetArea()
        {
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public string GetTriangleType()
        {
            if (SideA == SideB && SideB == SideC) return "Равносторонний";
            if (SideA == SideB || SideB == SideC || SideA == SideC) return "Равнобедренный";
            return "Разносторонний";
        }
    }
}
