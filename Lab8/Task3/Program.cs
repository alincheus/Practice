using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        string pattern = @"\b([1-9][0-9]?|99)\b";
        Regex regex = new Regex(pattern);

        MatchCollection matches = regex.Matches(input);

        Console.WriteLine("\nНайденные числа от 1 до 99:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }

        if (matches.Count == 0)
        {
            Console.WriteLine("Нет чисел в диапазоне от 1 до 99.");
        }
    }
}
