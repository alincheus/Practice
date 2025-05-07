using System;
using System.Collections.Generic;

class Program
{
    static string ProcessText(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in input)
        {
            if (ch == '#')
            {
                if (stack.Count > 0)
                    stack.Pop(); 
            }
            else
            {
                stack.Push(ch); 
            }
        }

        char[] resultArray = stack.ToArray();
        Array.Reverse(resultArray);
        return new string(resultArray);
    }

    static void Main()
    {
        Console.Write("Введите строку с символами #: ");
        string input = Console.ReadLine();

        string processedText = ProcessText(input);
        Console.WriteLine($"Результат обработки: {processedText}");
    }
}
