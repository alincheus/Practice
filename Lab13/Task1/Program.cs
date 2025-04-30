using System;

class Program
{
    public delegate double CalcFigure(double R);

    public static double Get_Length(double R)
    {
        return 2 * Math.PI * R;
    }

    public static double Get_Area(double R)
    {
        return Math.PI * R * R;
    }

    public static double Get_Volume(double R)
    {
        return 4.0 / 3.0 * Math.PI * Math.Pow(R, 3);
    }

    static void Main(string[] args)
    {
        CalcFigure CF;

        Console.WriteLine("Введите радиус R:");
        double R = Convert.ToDouble(Console.ReadLine());

        CF = Get_Length;
        Console.WriteLine($"Длина окружности: {CF(R):F2}");

        CF = Get_Area;
        Console.WriteLine($"Площадь круга: {CF(R):F2}");

        CF = Get_Volume;
        Console.WriteLine($"Объем шара: {CF(R):F2}");
    }
}
