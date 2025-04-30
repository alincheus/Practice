using System;

class Counter
{
    private int value;  
    private int min;    
    private int max;    

    public Counter() : this(0, 100, 0) { }

    public Counter(int min, int max, int startValue)
    {
        if (min > max || startValue < min || startValue > max)
        {
            throw new ArgumentException("Некорректные значения диапазона!");
        }

        this.min = min;
        this.max = max;
        this.value = startValue;
    }
    
    public void Increase()
    {
        if (value < max)
        {
            value++;
        }
        else
        {
            Console.WriteLine("Достигнуто максимальное значение.");
        }
    }

    public void Decrease()
    {
        if (value > min)
        {
            value--;
        }
        else
        {
            Console.WriteLine("Достигнуто минимальное значение.");
        }
    }

    public int CurrentValue => value;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите минимальное и максимальное значения счетчика:");
        Console.Write("Минимальное значение: ");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.Write("Максимальное значение: ");
        int max = Convert.ToInt32(Console.ReadLine());
        Console.Write("Начальное значение: ");
        int start = Convert.ToInt32(Console.ReadLine());

        try
        {
            Counter counter = new Counter(min, max, start);

            Console.WriteLine("Текущее значение счетчика: " + counter.CurrentValue);
            Console.WriteLine("Увеличиваем счетчик...");
            counter.Increase();
            Console.WriteLine("Текущее значение: " + counter.CurrentValue);
            Console.WriteLine("Уменьшаем счетчик...");
            counter.Decrease();
            Console.WriteLine("Текущее значение: " + counter.CurrentValue);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}
