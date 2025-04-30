using System;

class Vector : IComparable<Vector>
{
    private int[] _data;
    private int _lowerBound;
    private int _upperBound;

    public Vector(int lowerBound, int upperBound)
    {
        if (lowerBound > upperBound)
            throw new ArgumentException("Нижняя граница не может быть больше верхней границы.");
        
        _lowerBound = lowerBound;
        _upperBound = upperBound;
        _data = new int[upperBound - lowerBound + 1];
    }

    public int this[int index]
    {
        get
        {
            if (index < _lowerBound || index > _upperBound)
                throw new IndexOutOfRangeException("Индекс вне допустимых границ.");
            return _data[index - _lowerBound];
        }
        set
        {
            if (index < _lowerBound || index > _upperBound)
                throw new IndexOutOfRangeException("Индекс вне допустимых границ.");
            _data[index - _lowerBound] = value;
        }
    }

    public static Vector operator +(Vector v1, Vector v2)
    {
        if (v1._lowerBound != v2._lowerBound || v1._upperBound != v2._upperBound)
            throw new InvalidOperationException("Границы массивов не совпадают.");
        
        Vector result = new Vector(v1._lowerBound, v1._upperBound);
        for (int i = v1._lowerBound; i <= v1._upperBound; i++)
        {
            result[i] = v1[i] + v2[i];
        }
        return result;
    }

    public static Vector operator -(Vector v1, Vector v2)
    {
        if (v1._lowerBound != v2._lowerBound || v1._upperBound != v2._upperBound)
            throw new InvalidOperationException("Границы массивов не совпадают.");
        
        Vector result = new Vector(v1._lowerBound, v1._upperBound);
        for (int i = v1._lowerBound; i <= v1._upperBound; i++)
        {
            result[i] = v1[i] - v2[i];
        }
        return result;
    }

    public void PrintElement(int index)
    {
        Console.WriteLine($"Элемент с индексом {index}: {this[index]}");
    }

    public void PrintVector()
    {
        Console.Write("Массив: ");
        for (int i = _lowerBound; i <= _upperBound; i++)
        {
            Console.Write(this[i] + " ");
        }
        Console.WriteLine();
    }

    public int CompareTo(Vector other)
    {
        int sum1 = 0, sum2 = 0;
        for (int i = _lowerBound; i <= _upperBound; i++) sum1 += this[i];
        for (int i = other._lowerBound; i <= other._upperBound; i++) sum2 += other[i];

        return sum1.CompareTo(sum2);
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Vector vector1 = new Vector(0, 4); 
            Vector vector2 = new Vector(0, 4);

            Console.WriteLine("Заполнение первого вектора:");
            for (int i = 0; i <= 4; i++)
            {
                Console.Write($"Введите значение для индекса {i}: ");
                vector1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Заполнение второго вектора:");
            for (int i = 0; i <= 4; i++)
            {
                Console.Write($"Введите значение для индекса {i}: ");
                vector2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nПервый вектор:");
            vector1.PrintVector();

            Console.WriteLine("\nВторой вектор:");
            vector2.PrintVector();

            Vector sum = vector1 + vector2;
            Console.WriteLine("\nРезультат сложения векторов:");
            sum.PrintVector();

            Vector difference = vector1 - vector2;
            Console.WriteLine("\nРезультат вычитания векторов:");
            difference.PrintVector();

            int comparison = vector1.CompareTo(vector2);
            Console.WriteLine("\nСравнение векторов:");
            if (comparison > 0)
                Console.WriteLine("Первый вектор больше второго.");
            else if (comparison < 0)
                Console.WriteLine("Первый вектор меньше второго.");
            else
                Console.WriteLine("Векторы равны.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
