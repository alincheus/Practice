using System;
using System.Threading;

class Program
{
    static int A, N;

    static void SumMethod()
    {
        int sum = A;
        for (int i = 1; i <= N; i++)
        {
            sum += A + i;
        }
        Console.WriteLine($"Поток {Thread.CurrentThread.Name}: Сумма = {sum}");
    }

    static void ProductMethod()
    {
        int product = A;
        for (int i = 1; i <= N; i++)
        {
            product *= A + i;
        }
        Console.WriteLine($"Поток {Thread.CurrentThread.Name}: Произведение = {product}");
    }

    static void Main()
    {
        Console.Write("Введите значение A: ");
        A = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        N = int.Parse(Console.ReadLine());

        Thread thread1 = new Thread(SumMethod) { Name = "Сумма 1" };
        Thread thread2 = new Thread(SumMethod) { Name = "Сумма 2" };

        Thread thread3 = new Thread(ProductMethod) { Name = "Произведение" };

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        thread3.Start();
        thread3.Join();

        Console.WriteLine("Все потоки завершены!");
    }
}
