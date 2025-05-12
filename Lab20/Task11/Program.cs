using System;
using System.IO;

/// <summary>
/// Основной класс программы для создания папки в указанном месте.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы. Создаёт каталог по заданному пути.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Путь к создаваемой папке.
        /// </summary>
        string folderPath = "/Users/macbookm2/Documents/Practice/Lab20/New_folder";

        /// <summary>
        /// Создаёт папку, если она не существует.
        /// </summary>
        Directory.CreateDirectory(folderPath);

        Console.WriteLine($"Папка '{folderPath}' успешно создана!");
    }
}
