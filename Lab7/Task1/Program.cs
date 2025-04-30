using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        int maxCount = 0, currentCount = 0;

        foreach (char c in input)
        {
            if (char.IsDigit(c))
                currentCount++;
            else
            {
                if (currentCount > maxCount)
                    maxCount = currentCount;
                currentCount = 0;
            }
        }


        if (currentCount > maxCount)
            maxCount = currentCount;

        Console.WriteLine($"Наибольшее количество подряд идущих цифр: {maxCount}");
    }
}
