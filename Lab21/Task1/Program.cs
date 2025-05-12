using System;
using System.Threading.Tasks;

class Program
{
    /// <summary>
    /// Метод для вычисления суммы цифр четырехзначного числа.
    /// </summary>
    /// <param name="number">Четырехзначное число.</param>
    /// <returns>Сумма его цифр.</returns>
    static int SumDigits(int number)
    {
        if (number < 1000 || number > 9999)
            throw new ArgumentException("Число должно быть четырехзначным!");

        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }

    static void Main()
    {
        Console.Write("Введите четырехзначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Task<int> task1 = new Task<int>(() => SumDigits(number));
        task1.Start();
        Console.WriteLine($"Вариант 1 - Сумма цифр: {task1.Result}");

        Task<int> task2 = Task.Factory.StartNew(() => SumDigits(number));
        Console.WriteLine($"Вариант 2 - Сумма цифр: {task2.Result}");

        Task<int> task3 = Task.Run(() => SumDigits(number));
        Console.WriteLine($"Вариант 3 - Сумма цифр: {task3.Result}");
    }
}
