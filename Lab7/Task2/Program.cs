using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine();

        int countA = 0;
        bool commaFound = false;

        foreach (char c in input)
        {
            if (c == ',')
            {
                commaFound = true;
                break;
            }
            if (c == 'a' || c == 'A') 
            {
                countA++;
            }
        }

        if (commaFound)
            Console.WriteLine($"Количество букв 'a' перед первой запятой: {countA}");
        else
            Console.WriteLine("Запятых в предложении нет.");
    }
}
