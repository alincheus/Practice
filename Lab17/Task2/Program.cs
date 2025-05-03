using System;
using System.IO;

class Program
{
    static void Main()
    {
        string folderPath = "/Users/macbookm2/Documents/Practice/Lab17/New_folder";   
        Directory.CreateDirectory(folderPath);

        Console.WriteLine($"Папка '{folderPath}' успешно создана!");
    }
}
