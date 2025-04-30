using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        string pattern = @"#\w+";
        Regex regex = new Regex(pattern);

        MatchCollection matches = regex.Matches(input);

        Console.WriteLine("\nНайденные хэштеги:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }

        if (matches.Count == 0)
        {
            Console.WriteLine("Хэштегов не найдено.");
        }
    }
}
