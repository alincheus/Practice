using System;

interface Ix
{
    void IxF0(double w);
    void IxF1();
}

interface Iy
{
    void F0(double w);
    void F1();
}

interface Iz
{
    void F0(double w);
    void F1();
}

class TestClass : Ix, Iy, Iz
{
    private double w;

    public TestClass(double value)
    {
        w = value;
    }

    public void IxF0(double w)
    {
        Console.WriteLine($"IxF0: {Math.Pow(w, 2)}");
    }

    public void IxF1()
    {
        Console.WriteLine($"IxF1: {Math.Pow(w, 2)}");
    }

    public void F0(double w)
    {
        Console.WriteLine($"Iy.F0: {Math.Sqrt(w)}");
    }

    public void F1()
    {
        Console.WriteLine($"Iy.F1: {Math.Sqrt(w)}");
    }

    void Iz.F0(double w)
    {
        Console.WriteLine($"Iz.F0: {Math.Pow(w, 2) + 5}");
    }

    void Iz.F1()
    {
        Console.WriteLine($"Iz.F1: {Math.Pow(w, 2) + 5}");
    }
}

class Program
{
    static void Main()
    {
        double value = 4.0; 

        TestClass test = new TestClass(value);

        Console.WriteLine("Реализация Ix:");
        test.IxF0(value);
        test.IxF1();

        Console.WriteLine("\nНеявная реализация Iy:");
        test.F0(value);
        test.F1();

        Console.WriteLine("\nЯвная реализация Iz через приведение:");
        ((Iz)test).F0(value);
        ((Iz)test).F1();

        Console.WriteLine("\nВызов через интерфейсную ссылку Iz:");
        Iz iz = test;
        iz.F0(value);
        iz.F1();
    }
}
