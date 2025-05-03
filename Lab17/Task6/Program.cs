using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "/Users/macbookm2/Documents/Practice/Lab17/words.txt";

        if (!File.Exists(filePath))
        {
            Console.WriteLine($"Файл {filePath} не найден.");
            return;
        }

        string[] words = File.ReadAllText(filePath)
                             .Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        Console.Write("\nВведите букву для поиска: ");
        char startLetter = Console.ReadLine()[0];

        Console.WriteLine("\nСлова, начинающиеся с указанной буквы:");
        foreach (var word in words.Where(w => w.StartsWith(startLetter)))
        {
            Console.WriteLine(word);
        }

        Console.Write("\nВведите длину слова для поиска: ");
        int length = int.Parse(Console.ReadLine());

        Console.WriteLine("\nСлова заданной длины:");
        foreach (var word in words.Where(w => w.Length == length))
        {
            Console.WriteLine(word);
        }

        Console.WriteLine("\nСлова, начинающиеся и заканчивающиеся одной буквой:");
        foreach (var word in words.Where(w => w.Length > 1 && w.First() == w.Last()))
        {
            Console.WriteLine(word);
        }

        string lastWord = words.Last();

        Console.WriteLine($"\nСлова, начинающиеся на букву '{lastWord[0]}' (первая буква последнего слова):");
        foreach (var word in words.Where(w => w.StartsWith(lastWord[0])))
        {
            Console.WriteLine(word);
        }
    }
}
