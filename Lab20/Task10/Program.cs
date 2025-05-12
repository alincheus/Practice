using System;
using System.IO;
using System.Linq;

/// <summary>
/// Основной класс программы для обработки числовых данных, записанных в файл.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы. Запрашивает у пользователя ввод чисел, 
    /// записывает их в файл, затем анализирует их, вычисляя максимальное число 
    /// и количество отрицательных значений.
    /// </summary>
    static void Main()
    {
        /// <summary>
        /// Путь к текстовому файлу, содержащему числовые данные.
        /// </summary>
        string filePath = "/Users/macbookm2/Documents/Practice/Lab20/numbers.txt";

        Console.WriteLine("Введите числа через пробел:");
        string input = Console.ReadLine();

        /// <summary>
        /// Записывает введенные пользователем числа в файл.
        /// </summary>
        File.WriteAllText(filePath, input);

        /// <summary>
        /// Считывает данные из файла.
        /// </summary>
        string fileData = File.ReadAllText(filePath);

        /// <summary>
        /// Преобразует данные в массив чисел, игнорируя пустые строки 
        /// и заменяя некорректные значения на 0.
        /// </summary>
        int[] numbers = fileData.Split(' ')
                        .Where(n => !string.IsNullOrWhiteSpace(n)) 
                        .Select(n => int.TryParse(n, out int result) ? result : 0) 
                        .ToArray();

        /// <summary>
        /// Определяет максимальное число в файле.
        /// </summary>
        int maxNumber = numbers.Max();

        /// <summary>
        /// Подсчитывает количество отрицательных чисел.
        /// </summary>
        int negativeCount = numbers.Count(n => n < 0);

        Console.WriteLine($"\nМаксимальное число: {maxNumber}");
        Console.WriteLine($"Количество отрицательных чисел: {negativeCount}");
    }
}
