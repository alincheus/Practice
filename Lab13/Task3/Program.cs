using System;

class Program
{
    public delegate string StringOperation(string input);

    public static string ToUpperCase(string input)
    {
        return input.ToUpper();
    }

    public static string ToLowerCase(string input)
    {
        return input.ToLower();
    }

    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static void Main(string[] args)
    {
        StringOperation stringOp;

        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        stringOp = ToUpperCase;
        Console.WriteLine($"Строка в верхнем регистре: {stringOp(input)}");

        stringOp = ToLowerCase;
        Console.WriteLine($"Строка в нижнем регистре: {stringOp(input)}");

        stringOp = ReverseString;
        Console.WriteLine($"Перевернутая строка: {stringOp(input)}");
    }
}
