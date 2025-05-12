using System;
using System.IO;
using System.Linq;

/// <summary>
/// Основной класс программы для работы с текстовыми файлами.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы. Создает, читает, анализирует текстовый файл, выполняет удаление последней строки,
    /// выбор строк по диапазону, поиск самой длинной строки, выбор строк по первой букве и запись в обратном порядке.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Путь к основному текстовому файлу.
        /// </summary>
        string filePath = "textfile.txt";

        /// <summary>
        /// Путь к новому файлу после удаления последней строки.
        /// </summary>
        string newFilePath = "modified_textfile.txt";

        /// <summary>
        /// Путь к файлу с обратным порядком строк.
        /// </summary>
        string reversedFilePath = "reversed_textfile.txt";

        /// <summary>
        /// Записывает строки в основной файл.
        /// </summary>
        File.WriteAllLines(filePath, new string[]
        {
            "Первая строка",
            "Очень длинная вторая строка в файле",
            "Третья строка",
            "Четвертая строка",
            "Пятая строка"
        });

        /// <summary>
        /// Считывает строки из файла.
        /// </summary>
        string[] lines = File.ReadAllLines(filePath);

        Console.WriteLine("Содержимое файла:");
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }

        /// <summary>
        /// Вывод количества строк в файле.
        /// </summary>
        Console.WriteLine($"\nКоличество строк: {lines.Length}");

        /// <summary>
        /// Вывод количества символов в каждой строке.
        /// </summary>
        Console.WriteLine("\nКоличество символов в каждой строке:");
        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine($"Строка {i + 1}: {lines[i].Length} символов");
        }

        /// <summary>
        /// Удаление последней строки и запись в новый файл.
        /// </summary>
        string[] modifiedLines = lines.Take(lines.Length - 1).ToArray();
        File.WriteAllLines(newFilePath, modifiedLines);
        Console.WriteLine("\nПоследняя строка удалена. Записан новый файл.");

        /// <summary>
        /// Выбор строк по диапазону.
        /// </summary>
        Console.Write("\nВведите диапазон строк (s1 s2): ");
        string[] rangeInput = Console.ReadLine().Split(' ');
        int s1 = int.Parse(rangeInput[0]) - 1;
        int s2 = int.Parse(rangeInput[1]) - 1;

        Console.WriteLine("\nВыбранные строки:");
        for (int i = s1; i <= s2 && i < lines.Length; i++)
        {
            Console.WriteLine(lines[i]);
        }

        /// <summary>
        /// Поиск самой длинной строки.
        /// </summary>
        string longestLine = lines.OrderByDescending(line => line.Length).First();
        Console.WriteLine($"\nСамая длинная строка: \"{longestLine}\" (длина {longestLine.Length} символов)");

        /// <summary>
        /// Выбор строк, начинающихся с указанной буквы.
        /// </summary>
        Console.Write("\nВведите начальную букву: ");
        char startLetter = Console.ReadLine()[0];

        Console.WriteLine("\nСтроки, начинающиеся с указанной буквы:");
        foreach (var line in lines.Where(line => line.StartsWith(startLetter)))
        {
            Console.WriteLine(line);
        }

        /// <summary>
        /// Запись строк в новый файл в обратном порядке.
        /// </summary>
        File.WriteAllLines(reversedFilePath, lines.Reverse());

        Console.WriteLine("\nФайл с обратным порядком строк записан.");
    }
}
