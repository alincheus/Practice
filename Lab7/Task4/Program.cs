using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите фамилию:");
        string lastName = Console.ReadLine().ToUpper();
        
        Console.WriteLine("Введите имя:");
        string firstName = Console.ReadLine().ToUpper();
        
        Console.WriteLine("Введите отчество:");
        string middleName = Console.ReadLine().ToUpper();

        string fullName = lastName + firstName + middleName;
        int sum = 0;

        foreach (char c in fullName)
        {
            if (char.IsLetter(c))
                sum += GetAlphabetPosition(c);
        }

        int personalityCode = ReduceToSingleDigit(sum);

        Console.WriteLine($"\nСумма порядковых номеров букв: {sum}");
        Console.WriteLine($"Ваш код личности: {personalityCode}");
    }

    static int GetAlphabetPosition(char c)
    {
        string alphabet = "АБВГДЕЁЖЗИКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        return alphabet.IndexOf(c) + 1;
    }

    static int ReduceToSingleDigit(int num)
    {
        while (num >= 10)
        {
            int tempSum = 0;
            while (num > 0)
            {
                tempSum += num % 10;
                num /= 10;
            }
            num = tempSum;
        }
        return num;
    }
}
