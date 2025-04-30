using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        string pattern = @"\b\w*[бвгджзйклмнпрстфхцчшщ]{4,}\w*\b";
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
        
        MatchCollection matches = regex.Matches(input);

        Console.WriteLine("\nНайденные слова с более чем тремя подряд согласными:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }

        if (matches.Count == 0)
        {
            Console.WriteLine("Нет слов, соответствующих заданным условиям.");
        }
    }
}
