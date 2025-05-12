using System;
using System.Threading.Tasks;

class Program
{
    /// <summary>
    /// Метод вычисляет первую и последнюю цифру двузначного числа.
    /// </summary>
    /// <param name="number">Двузначное число.</param>
    /// <returns>Кортеж с первой и последней цифрой.</returns>
    static (int firstDigit, int lastDigit) GetDigits(int number)
    {
        if (number < 10 || number > 99)
            throw new ArgumentException("Число должно быть двузначным!");

        int firstDigit = number / 10; 
        int lastDigit = number % 10;  

        return (firstDigit, lastDigit);
    }

    static void Main()
    {
        Console.Write("Введите двузначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Task<(int firstDigit, int lastDigit)> task1 = Task.Run(() => GetDigits(number));

        Task task2 = task1.ContinueWith(t =>
        {
            Console.WriteLine($"\nПервая цифра: {t.Result.firstDigit}");
            Console.WriteLine($"Последняя цифра: {t.Result.lastDigit}");
        });

        task2.Wait(); 
    }
}
