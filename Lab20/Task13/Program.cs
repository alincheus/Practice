using System;
using System.IO;

/// <summary>
/// Основной класс программы для обработки текстового файла, 
/// заменяя символы '0' на '1' и наоборот.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы. Проверяет существование входного файла, 
    /// выполняет замену символов и записывает результат в новый файл.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Путь к входному файлу.
        /// </summary>
        string inputFile = "/Users/macbookm2/Documents/Practice/Lab20/input.txt";

        /// <summary>
        /// Путь к выходному файлу.
        /// </summary>
        string outputFile = "/Users/macbookm2/Documents/Practice/Lab20/output.txt";

        // Проверка существования входного файла
        if (!File.Exists(inputFile))
        {
            Console.WriteLine($"Файл {inputFile} не найден.");
            return;
        }

        /// <summary>
        /// Чтение строк из файла.
        /// </summary>
        string[] lines = File.ReadAllLines(inputFile);

        /// <summary>
        /// Обрабатывает строки, заменяя '0' на '1' и '1' на '0'.
        /// </summary>
        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = lines[i].Replace('0', 'X').Replace('1', '0').Replace('X', '1');
        }

        /// <summary>
        /// Запись обработанных строк в выходной файл.
        /// </summary>
        File.WriteAllLines(outputFile, lines);

        Console.WriteLine($"Файл {outputFile} успешно создан с замененными символами.");
    }
}
