using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    /// <summary>
    /// Вычисляет значение первой функции с задержкой.
    /// </summary>
    /// <returns>Результат вычисления функции 1.</returns>
    static double ComputeFunction1()
    {
        Thread.Sleep(2000); 
        return Math.Sin(Math.PI / 3) + Math.Cos(Math.PI / 4);
    }

    /// <summary>
    /// Вычисляет значение второй функции с задержкой.
    /// </summary>
    /// <returns>Результат вычисления функции 2.</returns>
    static double ComputeFunction2()
    {
        Thread.Sleep(3000); 
        return Math.Tan(Math.PI / 6) * Math.Sqrt(2);
    }

    static void Main()
    {
        Console.WriteLine("Запуск вычислений...");

        Task<double>[] tasks = new Task<double>[]
        {
            Task.Run(() => ComputeFunction1()),
            Task.Run(() => ComputeFunction2())
        };

        Task.WaitAll(tasks);
        Console.WriteLine("\nВсе задачи выполнены!");
        Console.WriteLine($"Результат первой функции: {tasks[0].Result}");
        Console.WriteLine($"Результат второй функции: {tasks[1].Result}");

        tasks = new Task<double>[]
        {
            Task.Run(() => ComputeFunction1()),
            Task.Run(() => ComputeFunction2())
        };

        int completedIndex = Task.WaitAny(tasks);
        Console.WriteLine($"\nЗавершена хотя бы одна задача! Индекс: {completedIndex}");
        Console.WriteLine($"Результат завершенной задачи: {tasks[completedIndex].Result}");
    }
}
