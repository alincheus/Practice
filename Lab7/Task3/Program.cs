using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        if (words.Length < 3)
        {
            Console.WriteLine("Ошибка: предложение должно содержать как минимум три слова.");
            return;
        }

        string temp = words[0];
        words[0] = words[words.Length - 1];
        words[words.Length - 1] = temp;

        Console.WriteLine("\nПредложение после замены первого и последнего слова:");
        Console.WriteLine(string.Join(" ", words));

        string mergedWords = words[1] + words[2];
        Console.WriteLine("\nСклеенное второе и третье слово:");
        Console.WriteLine(mergedWords);

        char[] reversedWord = words[2].ToCharArray();
        Array.Reverse(reversedWord);
        Console.WriteLine("\nТретье слово в обратном порядке:");
        Console.WriteLine(new string(reversedWord));
        
        if (words[0].Length > 2)
        {
            string trimmedFirstWord = words[0].Substring(2);
            Console.WriteLine("\nПервое слово после удаления первых двух букв:");
            Console.WriteLine(trimmedFirstWord);
        }
        else
        {
            Console.WriteLine("\nПервое слово содержит менее двух букв, удаление невозможно.");
        }
    }
}
