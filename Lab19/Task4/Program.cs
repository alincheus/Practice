using System;
using System.Collections;
using System.Collections.Generic;

class CDCollection
{
    private Hashtable catalog = new Hashtable();

    public void AddCD(string cdName)
    {
        if (!catalog.ContainsKey(cdName))
        {
            catalog[cdName] = new List<string>();
            Console.WriteLine($"Диск '{cdName}' добавлен.");
        }
        else
        {
            Console.WriteLine($"Диск '{cdName}' уже существует.");
        }
    }

    public void RemoveCD(string cdName)
    {
        if (catalog.ContainsKey(cdName))
        {
            catalog.Remove(cdName);
            Console.WriteLine($"Диск '{cdName}' удален.");
        }
        else
        {
            Console.WriteLine($"Диск '{cdName}' не найден.");
        }
    }

    public void AddSong(string cdName, string song)
    {
        if (catalog.ContainsKey(cdName))
        {
            ((List<string>)catalog[cdName]).Add(song);
            Console.WriteLine($"Песня '{song}' добавлена на диск '{cdName}'.");
        }
        else
        {
            Console.WriteLine($"Диск '{cdName}' не найден.");
        }
    }

    public void RemoveSong(string cdName, string song)
    {
        if (catalog.ContainsKey(cdName))
        {
            var songs = (List<string>)catalog[cdName];
            if (songs.Remove(song))
            {
                Console.WriteLine($"Песня '{song}' удалена с диска '{cdName}'.");
            }
            else
            {
                Console.WriteLine($"Песня '{song}' не найдена на диске '{cdName}'.");
            }
        }
        else
        {
            Console.WriteLine($"Диск '{cdName}' не найден.");
        }
    }

    public void DisplayCatalog()
    {
        Console.WriteLine("\nКаталог музыкальных дисков:");
        foreach (DictionaryEntry entry in catalog)
        {
            Console.WriteLine($"📀 Диск: {entry.Key}");
            foreach (string song in (List<string>)entry.Value)
            {
                Console.WriteLine($"  🎵 {song}");
            }
        }
    }

    public void DisplayCD(string cdName)
    {
        if (catalog.ContainsKey(cdName))
        {
            Console.WriteLine($"\nСодержимое диска '{cdName}':");
            foreach (string song in (List<string>)catalog[cdName])
            {
                Console.WriteLine($"  🎵 {song}");
            }
        }
        else
        {
            Console.WriteLine($"Диск '{cdName}' не найден.");
        }
    }
}

class Program
{
    static void Main()
    {
        CDCollection collection = new CDCollection();

        collection.AddCD("Rock Classics");
        collection.AddCD("Jazz Vibes");

        collection.AddSong("Rock Classics", "Bohemian Rhapsody");
        collection.AddSong("Rock Classics", "Stairway to Heaven");
        collection.AddSong("Jazz Vibes", "Take Five");

        collection.DisplayCatalog();

        collection.RemoveSong("Rock Classics", "Stairway to Heaven");

        collection.DisplayCD("Rock Classics");

        collection.RemoveCD("Jazz Vibes");

        collection.DisplayCatalog();
    }
}
