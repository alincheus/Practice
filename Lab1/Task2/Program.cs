using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите четырехзначное число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 1000 && number <= 9999)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine("Сумма цифр числа: " + sum);
        }
        else
        {
            Console.WriteLine("Ошибка: необходимо ввести четырехзначное число.");
        }
    }
}
