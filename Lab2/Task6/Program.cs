using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество баллов (от 0 до 100):");
        int score = Convert.ToInt32(Console.ReadLine());

        if (score < 0 || score > 100)
        {
            Console.WriteLine("Ошибка: баллы должны быть в диапазоне от 0 до 100.");
        }
        else
        {
            switch (score)
            {
                case >= 90:
                    Console.WriteLine("Оценка: отлично");
                    break;
                case >= 70:
                    Console.WriteLine("Оценка: хорошо");
                    break;
                case >= 50:
                    Console.WriteLine("Оценка: удовлетворительно");
                    break;
                default:
                    Console.WriteLine("Оценка: неудовлетворительно");
                    break;
            }
        }
    }
}
