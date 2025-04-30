using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите расстояние в сантиметрах:");
        int centimeters = Convert.ToInt32(Console.ReadLine());

        int meters = centimeters / 100; 

        Console.WriteLine($"Число полных метров: {meters}");
    }
}
