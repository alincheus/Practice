using System;

class Program
{
    static void PowerA3(double A, out double B)
    {
        B = Math.Pow(A, 3);
    }

    static void Main()
    {
        Console.WriteLine("Введите 5 вещественных чисел:");
        double[] numbers = new double[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Число {i + 1}: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("\nТретьи степени введенных чисел:");
        for (int i = 0; i < 5; i++)
        {
            double result;
            PowerA3(numbers[i], out result);
            Console.WriteLine($"Число {numbers[i]} в третьей степени: {result}");
        }
    }
}
