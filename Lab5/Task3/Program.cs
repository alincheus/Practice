using System;

class Program
{
    static void PowerA3(double A, out double B)
    {
        if (A < 0)
            throw new ArgumentException("Ошибка: число A не должно быть отрицательным!");

        B = Math.Pow(A, 3);
    }

    static void Main()
    {
        double[] numbers = new double[5];

        Console.WriteLine("Введите 5 вещественных чисел:");

        for (int i = 0; i < 5; i++)
        {
            try
            {
                Console.Write($"Число {i + 1}: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());

                if (numbers[i] == 0)
                    throw new DivideByZeroException("Ошибка: ввод нуля приведет к некорректному вычислению!");

            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено некорректное число! Попробуйте снова.");
                i--; 
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                i--; 
            }
        }

        Console.WriteLine("\nТретьи степени введенных чисел:");
        for (int i = 0; i < 5; i++)
        {
            try
            {
                double result;
                PowerA3(numbers[i], out result);
                Console.WriteLine($"Число {numbers[i]} в третьей степени: {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка при вычислении для {numbers[i]}: {ex.Message}");
            }
        }
    }
}
