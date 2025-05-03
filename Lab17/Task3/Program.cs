using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "textfile.txt";
        string newFilePath = "modified_textfile.txt";
        string reversedFilePath = "reversed_textfile.txt";

        File.WriteAllLines(filePath, new string[]
        {
            "Первая строка",
            "Очень длинная вторая строка в файле",
            "Третья строка",
            "Четвертая строка",
            "Пятая строка"
        });

        string[] lines = File.ReadAllLines(filePath);

        Console.WriteLine("Содержимое файла:");
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }

        Console.WriteLine($"\nКоличество строк: {lines.Length}");

        Console.WriteLine("\nКоличество символов в каждой строке:");
        for (int i = 0; i < lines.Length; i++)
        {
            Console.WriteLine($"Строка {i + 1}: {lines[i].Length} символов");
        }

        string[] modifiedLines = lines.Take(lines.Length - 1).ToArray();
        File.WriteAllLines(newFilePath, modifiedLines);

        Console.WriteLine("\nПоследняя строка удалена. Записан новый файл.");

        Console.Write("\nВведите диапазон строк (s1 s2): ");
        string[] rangeInput = Console.ReadLine().Split(' ');
        int s1 = int.Parse(rangeInput[0]) - 1;
        int s2 = int.Parse(rangeInput[1]) - 1;

        Console.WriteLine("\nВыбранные строки:");
        for (int i = s1; i <= s2 && i < lines.Length; i++)
        {
            Console.WriteLine(lines[i]);
        }

        string longestLine = lines.OrderByDescending(line => line.Length).First();
        Console.WriteLine($"\nСамая длинная строка: \"{longestLine}\" (длина {longestLine.Length} символов)");

        Console.Write("\nВведите начальную букву: ");
        char startLetter = Console.ReadLine()[0];

        Console.WriteLine("\nСтроки, начинающиеся с указанной буквы:");
        foreach (var line in lines.Where(line => line.StartsWith(startLetter)))
        {
            Console.WriteLine(line);
        }

        File.WriteAllLines(reversedFilePath, lines.Reverse());

        Console.WriteLine("\nФайл с обратным порядком строк записан.");
    }
}
