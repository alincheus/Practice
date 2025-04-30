using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        string pattern = @"\b\w*(\w)\1\w*\b";
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

        MatchCollection matches = regex.Matches(input);

        Console.WriteLine("\nНайденные слова с двумя подряд одинаковыми буквами:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }

        if (matches.Count == 0)
        {
            Console.WriteLine("Нет слов, содержащих две подряд одинаковые буквы.");
        }
    }
}
