using System;
using System.IO;
using System.Linq;

/// <summary>
/// Основной класс программы для работы с текстовыми файлами.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы. Создает два файла с отсортированными числами, 
    /// объединяет их содержимое, сохраняя упорядоченность, и записывает результат в третий файл.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Путь к первому файлу, содержащему упорядоченные числа.
        /// </summary>
        string file1 = "/Users/macbookm2/Documents/Practice/Lab20/f1.txt";

        /// <summary>
        /// Путь ко второму файлу, содержащему упорядоченные числа.
        /// </summary>
        string file2 = "/Users/macbookm2/Documents/Practice/Lab20/f2.txt";

        /// <summary>
        /// Путь к третьему файлу, содержащему объединенные и отсортированные числа.
        /// </summary>
        string file3 = "/Users/macbookm2/Documents/Practice/Lab20/f3.txt";

        // Создание файлов с отсортированными числами
        File.WriteAllLines(file1, new[] { "1", "3", "5", "7", "9" });
        File.WriteAllLines(file2, new[] { "2", "4", "6", "8", "10" });

        // Чтение данных из файлов и преобразование в массивы целых чисел
        int[] numbers1 = File.ReadAllLines(file1).Select(int.Parse).ToArray();
        int[] numbers2 = File.ReadAllLines(file2).Select(int.Parse).ToArray();

        /// <summary>
        /// Объединение двух массивов и сортировка чисел по возрастанию.
        /// </summary>
        int[] mergedNumbers = numbers1.Concat(numbers2).OrderBy(n => n).ToArray();

        // Запись объединенного массива чисел в третий файл
        File.WriteAllLines(file3, mergedNumbers.Select(n => n.ToString()));

        Console.WriteLine($"Файл {file3} успешно создан!");
    }
}
