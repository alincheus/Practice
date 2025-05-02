using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void CalculateSum()
    {
        Stopwatch stopwatch = Stopwatch.StartNew(); 
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
        }
        stopwatch.Stop(); 
        Console.WriteLine($"Поток {Thread.CurrentThread.Name}: Сумма = {sum}, Время выполнения = {stopwatch.ElapsedMilliseconds} мс");
    }

    static void Main()
    {
        Thread thread1 = new Thread(CalculateSum) { Name = "Первый" };
        Thread thread2 = new Thread(CalculateSum) { Name = "Второй" };

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        Console.WriteLine("Оба потока завершены!");
    }
}
