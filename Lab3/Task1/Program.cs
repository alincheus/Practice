using System;

class A
{
    public int a { get; private set; }
    public int b { get; private set; }

    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public int Sum()
    {
        return a + b;
    }

    public double CalculateExpression()
    {
        return Math.Sin(b) / (3 * a);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Значение a: {a}");
        Console.WriteLine($"Значение b: {b}");
        Console.WriteLine($"Сумма a и b: {Sum()}");
        Console.WriteLine($"Значение выражения: {CalculateExpression():F6}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значения a и b:");
        Console.Write("a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        A obj = new A(a, b);

        obj.DisplayInfo();
    }
}
