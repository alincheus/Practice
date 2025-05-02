using System;
using System.Threading;

class Program
{
    static AutoResetEvent firstThreadEvent = new AutoResetEvent(true); 
    static AutoResetEvent secondThreadEvent = new AutoResetEvent(false); 
    static AutoResetEvent thirdThreadEvent = new AutoResetEvent(false); 

    static void PrintNumbers(int start, int end, AutoResetEvent currentEvent, AutoResetEvent nextEvent)
    {
        for (int i = start; i <= end; i++)
        {
            currentEvent.WaitOne(); 
            Console.WriteLine($"Поток {Thread.CurrentThread.Name}: {i}");
            Thread.Sleep(500); 
            nextEvent.Set(); 
        }
    }

    static void Main()
    {
        Thread thread1 = new Thread(() => PrintNumbers(0, 9, firstThreadEvent, secondThreadEvent))
        {
            Name = "Первый",
            Priority = ThreadPriority.Highest
        };

        Thread thread2 = new Thread(() => PrintNumbers(10, 19, secondThreadEvent, thirdThreadEvent))
        {
            Name = "Второй",
            Priority = ThreadPriority.Normal
        };

        Thread thread3 = new Thread(() => PrintNumbers(20, 29, thirdThreadEvent, firstThreadEvent))
        {
            Name = "Третий",
            Priority = ThreadPriority.Lowest
        };

        thread1.Start();
        thread2.Start();
        thread3.Start();

        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine("Все потоки завершены!");
    }
}
