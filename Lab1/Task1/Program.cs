using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое целое число:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе целое число:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int sum = number1 + number2;

        Console.WriteLine("Сумма введенных чисел: " + sum);
    }
}
