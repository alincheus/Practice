using System;
using System.IO;
using System.Linq;

/// <summary>
/// Основной класс программы для работы с текстовым файлом и анализа слов.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы. Проверяет наличие файла, загружает слова и выполняет их анализ:
    /// - поиск слов по первой букве;
    /// - поиск слов заданной длины;
    /// - поиск слов, начинающихся и заканчивающихся одной буквой;
    /// - поиск слов, начинающихся с той же буквы, что последнее слово в файле.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Путь к текстовому файлу, содержащему список слов.
        /// </summary>
        string filePath = "/Users/macbookm2/Documents/Practice/Lab20/words.txt";

        // Проверяем существование файла
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"Файл {filePath} не найден.");
            return;
        }

        /// <summary>
        /// Читает слова из файла, разделяя их по пробелам и символам новой строки.
        /// </summary>
        string[] words = File.ReadAllText(filePath)
                             .Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        /// <summary>
        /// Поиск слов, начинающихся с указанной буквы.
        /// </summary>
        Console.Write("\nВведите букву для поиска: ");
        char startLetter = Console.ReadLine()[0];

        Console.WriteLine("\nСлова, начинающиеся с указанной буквы:");
        foreach (var word in words.Where(w => w.StartsWith(startLetter)))
        {
            Console.WriteLine(word);
        }

        /// <summary>
        /// Поиск слов заданной длины.
        /// </summary>
        Console.Write("\nВведите длину слова для поиска: ");
        int length = int.Parse(Console.ReadLine());

        Console.WriteLine("\nСлова заданной длины:");
        foreach (var word in words.Where(w => w.Length == length))
        {
            Console.WriteLine(word);
        }

        /// <summary>
        /// Поиск слов, начинающихся и заканчивающихся одной буквой.
        /// </summary>
        Console.WriteLine("\nСлова, начинающиеся и заканчивающиеся одной буквой:");
        foreach (var word in words.Where(w => w.Length > 1 && w.First() == w.Last()))
        {
            Console.WriteLine(word);
        }

        /// <summary>
        /// Поиск слов, начинающихся с той же буквы, что последнее слово в файле.
        /// </summary>
        string lastWord = words.Last();

        Console.WriteLine($"\nСлова, начинающиеся на букву '{lastWord[0]}' (первая буква последнего слова):");
        foreach (var word in words.Where(w => w.StartsWith(lastWord[0])))
        {
            Console.WriteLine(word);
        }
    }
}
