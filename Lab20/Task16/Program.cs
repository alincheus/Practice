using System;
using System.IO;

/// <summary>
/// Основной класс программы для работы с файловой системой: 
/// - получение списка файлов на диске,
/// - создание каталога,
/// - копирование файлов,
/// - установка атрибутов скрытых файлов,
/// - создание файлов-ссылок.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы. Выполняет все операции с файлами и каталогами.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Путь к директории, в которой находятся файлы.
        /// </summary>
        string drivePath = @"/Users/macbookm2/Documents/";
        Console.WriteLine($"Файлы на диске {drivePath}:");

        // Получение списка файлов и их вывод
        foreach (var file in Directory.GetFiles(drivePath, "*.*", SearchOption.AllDirectories))
        {
            Console.WriteLine(file);
        }

        /// <summary>
        /// Путь к создаваемому каталогу.
        /// </summary>
        string targetDir = @"/Users/macbookm2/Documents/Exmple_38tp";

        // Создание каталога
        Directory.CreateDirectory(targetDir);
        Console.WriteLine($"\nКаталог {targetDir} создан.");

        /// <summary>
        /// Путь к исходной папке, содержащей файлы для копирования.
        /// </summary>
        string sourceDir = @"/Users/macbookm2/Documents/псих";

        /// <summary>
        /// Получение списка файлов для копирования (первые 3 файла).
        /// </summary>
        string[] filesToCopy = Directory.GetFiles(sourceDir).Take(3).ToArray();

        // Копирование файлов, установка атрибутов и создание файлов-ссылок
        foreach (var file in filesToCopy)
        {
            /// <summary>
            /// Путь к скопированному файлу.
            /// </summary>
            string destFile = Path.Combine(targetDir, Path.GetFileName(file));
            File.Copy(file, destFile);
            Console.WriteLine($"Файл {file} скопирован в {destFile}");
            
            // Установка атрибута "Скрытый"
            File.SetAttributes(destFile, FileAttributes.Hidden);
            Console.WriteLine($"Файл {Path.GetFileName(file)} сделан скрытым.");
            
            /// <summary>
            /// Путь к создаваемому файлу-ссылке.
            /// </summary>
            string linkFile = Path.Combine(targetDir, Path.GetFileNameWithoutExtension(file) + "_link.txt");
            File.WriteAllText(linkFile, $"Это ссылка на файл: {Path.GetFileName(file)}");
            Console.WriteLine($"Создан файл-ссылка: {linkFile}");
        }

        Console.WriteLine("\nВсе операции выполнены!");
    }
}
