using System;

class A
{
    private int a; 
    private int b; 

    public int C
    {
        get { return a + b; }
    }

    public A()
    {
        a = 5; 
        b = 10; 
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Класс A: a = {a}, b = {b}, c = {C}");
    }
}

class B : A
{
    private int d; 

    public int C2
    {
        get
        {
            int sum = 0;
            int temp = d;
            do
            {
                sum += temp;
                temp--;
            } while (temp > 0);
            return C + sum;
        }
    }

    public B() : base()
    {
        d = 3; 
    }

    public B(int dValue) : base()
    {
        d = dValue;
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Класс B: d = {d}, c2 = {C2}");
    }
}

class Program
{
    static void Main()
    {
        A objA = new A();
        Console.WriteLine("Объект класса A:");
        objA.DisplayInfo();

        B objB1 = new B();
        Console.WriteLine("\nОбъект класса B (наследуемый конструктор):");
        objB1.DisplayInfo();

        B objB2 = new B(5);
        Console.WriteLine("\nОбъект класса B (собственный конструктор):");
        objB2.DisplayInfo();
    }
}
