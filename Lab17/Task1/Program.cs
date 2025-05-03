using System;
using System.IO;
using System.Linq;
class Program
{
    static void Main()
    {
        string filePath = "/Users/macbookm2/Documents/Practice/Lab17/numbers.txt";


        Console.WriteLine("Введите числа через пробел:");
        string input = Console.ReadLine();

        File.WriteAllText(filePath, input);

        string fileData = File.ReadAllText(filePath);
        int[] numbers = fileData.Split(' ')
                        .Where(n => !string.IsNullOrWhiteSpace(n)) 
                        .Select(n => int.TryParse(n, out int result) ? result : 0) 
                        .ToArray();

        int maxNumber = numbers.Max();

        int negativeCount = numbers.Count(n => n < 0);

        Console.WriteLine($"\nМаксимальное число: {maxNumber}");
        Console.WriteLine($"Количество отрицательных чисел: {negativeCount}");
    }
}
