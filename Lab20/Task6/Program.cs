using System;

/// <summary>
/// Основной класс программы для вычисления параметров окружности, круга и шара.
/// </summary>
class Program
{
    /// <summary>
    /// Делегат для вычисления различных параметров фигуры на основе радиуса.
    /// </summary>
    /// <param name="R">Радиус фигуры.</param>
    /// <returns>Рассчитанное значение (длина окружности, площадь круга или объем шара).</returns>
    public delegate double CalcFigure(double R);

    /// <summary>
    /// Вычисляет длину окружности.
    /// </summary>
    /// <param name="R">Радиус окружности.</param>
    /// <returns>Длина окружности.</returns>
    public static double Get_Length(double R)
    {
        return 2 * Math.PI * R;
    }

    /// <summary>
    /// Вычисляет площадь круга.
    /// </summary>
    /// <param name="R">Радиус круга.</param>
    /// <returns>Площадь круга.</returns>
    public static double Get_Area(double R)
    {
        return Math.PI * R * R;
    }

    /// <summary>
    /// Вычисляет объем шара.
    /// </summary>
    /// <param name="R">Радиус шара.</param>
    /// <returns>Объем шара.</returns>
    public static double Get_Volume(double R)
    {
        return 4.0 / 3.0 * Math.PI * Math.Pow(R, 3);
    }

    /// <summary>
    /// Главный метод программы. Запрашивает у пользователя радиус, 
    /// выполняет вычисления и выводит результаты.
    /// </summary>
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
