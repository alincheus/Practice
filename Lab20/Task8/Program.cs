using System;

/// <summary>
/// Основной класс программы для обработки строковых данных с использованием делегатов.
/// </summary>
class Program
{
    /// <summary>
    /// Делегат для выполнения операций над строкой.
    /// </summary>
    /// <param name="input">Входная строка.</param>
    /// <returns>Преобразованная строка.</returns>
    public delegate string StringOperation(string input);

    /// <summary>
    /// Преобразует строку в верхний регистр.
    /// </summary>
    /// <param name="input">Исходная строка.</param>
    /// <returns>Строка в верхнем регистре.</returns>
    public static string ToUpperCase(string input)
    {
        return input.ToUpper();
    }

    /// <summary>
    /// Преобразует строку в нижний регистр.
    /// </summary>
    /// <param name="input">Исходная строка.</param>
    /// <returns>Строка в нижнем регистре.</returns>
    public static string ToLowerCase(string input)
    {
        return input.ToLower();
    }

    /// <summary>
    /// Переворачивает строку задом наперед.
    /// </summary>
    /// <param name="input">Исходная строка.</param>
    /// <returns>Перевернутая строка.</returns>
    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    /// <summary>
    /// Главный метод программы. Запрашивает у пользователя строку, выполняет преобразования и выводит результаты.
    /// </summary>
    /// <param name="args">Аргументы командной строки (не используются).</param>
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
