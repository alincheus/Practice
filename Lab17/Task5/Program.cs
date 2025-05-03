using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string file1 = "/Users/macbookm2/Documents/Practice/Lab17/f1.txt";
        string file2 = "/Users/macbookm2/Documents/Practice/Lab17/f2.txt";
        string file3 = "/Users/macbookm2/Documents/Practice/Lab17/f3.txt";

        File.WriteAllLines(file1, new[] { "1", "3", "5", "7", "9" });
        File.WriteAllLines(file2, new[] { "2", "4", "6", "8", "10" });

        int[] numbers1 = File.ReadAllLines(file1).Select(int.Parse).ToArray();
        int[] numbers2 = File.ReadAllLines(file2).Select(int.Parse).ToArray();
        int[] mergedNumbers = numbers1.Concat(numbers2).OrderBy(n => n).ToArray();

        File.WriteAllLines(file3, mergedNumbers.Select(n => n.ToString()));

        Console.WriteLine($"Файл {file3} успешно создан!");
    }
}
