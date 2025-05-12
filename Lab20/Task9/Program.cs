using System;

/// <summary>
/// Основной класс программы для генерации случайных значений и их обработки через делегаты.
/// </summary>
class Program
{
    /// <summary>
    /// Делегат для генерации случайного целого числа.
    /// </summary>
    /// <returns>Случайное целое число.</returns>
    public delegate int RandomValueDelegate();

    /// <summary>
    /// Главный метод программы. Создает массив делегатов, генерирующих случайные числа, 
    /// вычисляет их среднее арифметическое и выводит результат.
    /// </summary>
    /// <param name="args">Аргументы командной строки (не используются).</param>
    static void Main(string[] args)
    {
        RandomValueDelegate[] delegateArray = new RandomValueDelegate[5];

        Random random = new Random();

        /// <summary>
        /// Инициализирует массив делегатов для генерации случайных значений.
        /// </summary>
        for (int i = 0; i < delegateArray.Length; i++)
        {
            delegateArray[i] = () => random.Next(1, 101);
        }

        /// <summary>
        /// Функция для вычисления среднего арифметического значений, полученных через делегаты.
        /// </summary>
        /// <param name="delegates">Массив делегатов, генерирующих случайные значения.</param>
        /// <returns>Среднее арифметическое случайных значений.</returns>
        Func<RandomValueDelegate[], double> calculateAverage = (delegates) =>
        {
            int sum = 0;
            foreach (var del in delegates)
            {
                sum += del();
            }
            return (double)sum / delegates.Length;
        };

        double average = calculateAverage(delegateArray);

        Console.WriteLine($"Среднее арифметическое значений: {average:F2}");
    }
}
