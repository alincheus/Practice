using GeometryLibrary.Base;

namespace GeometryLibrary.Shapes
{
    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetPerimeter() => 2 * (Width + Height);

        public override double GetArea() => Width * Height;
    }
}
