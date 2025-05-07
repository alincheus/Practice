using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string filePath = "/Users/macbookm2/Documents/Practice/Lab19/input.txt";

        if (!File.Exists(filePath))
        {
            Console.WriteLine($"Файл {filePath} не найден.");
            return;
        }

        Queue<char> charQueue = new Queue<char>();
        Queue<char> digitQueue = new Queue<char>();

        foreach (char ch in File.ReadAllText(filePath))
        {
            if (char.IsDigit(ch))
                digitQueue.Enqueue(ch); 
            else
                charQueue.Enqueue(ch); 
        }

        Console.WriteLine("\nСимволы (без цифр):");
        while (charQueue.Count > 0)
            Console.Write(charQueue.Dequeue());

        Console.WriteLine("\n\nЦифры:");
        while (digitQueue.Count > 0)
            Console.Write(digitQueue.Dequeue());

        Console.WriteLine("\n\nОбработка завершена!");
    }
}
