using System;
using System.IO;

class Program
{
    static void Main()
    {
        string drivePath = @"/Users/macbookm2/Documents/";
        Console.WriteLine($"Файлы на диске {drivePath}:");
        foreach (var file in Directory.GetFiles(drivePath, "*.*", SearchOption.AllDirectories))
        {
            Console.WriteLine(file);
        }

        string targetDir = @"/Users/macbookm2/Documents//Exmple_38tp";
        Directory.CreateDirectory(targetDir);
        Console.WriteLine($"\nКаталог {targetDir} создан.");

        string sourceDir = @"/Users/macbookm2/Documents/псих"; 
        string[] filesToCopy = Directory.GetFiles(sourceDir).Take(3).ToArray();

        foreach (var file in filesToCopy)
        {
            string destFile = Path.Combine(targetDir, Path.GetFileName(file));
            File.Copy(file, destFile);
            Console.WriteLine($"Файл {file} скопирован в {destFile}");
            
            File.SetAttributes(destFile, FileAttributes.Hidden);
            Console.WriteLine($"Файл {Path.GetFileName(file)} сделан скрытым.");
            
            string linkFile = Path.Combine(targetDir, Path.GetFileNameWithoutExtension(file) + "_link.txt");
            File.WriteAllText(linkFile, $"Это ссылка на файл: {Path.GetFileName(file)}");
            Console.WriteLine($"Создан файл-ссылка: {linkFile}");
        }

        Console.WriteLine("\nВсе операции выполнены!");
    }
}
