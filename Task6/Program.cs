using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите двузначное число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 10 && number <= 99)
        {
            int firstDigit = number / 10; // Первая цифра
            int lastDigit = number % 10;  // Последняя цифра

            Console.WriteLine("Первая цифра: " + firstDigit);
            Console.WriteLine("Последняя цифра: " + lastDigit);
        }
        else
        {
            Console.WriteLine("Ошибка: необходимо ввести двузначное число.");
        }
    }
}
