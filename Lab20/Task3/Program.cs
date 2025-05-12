using System;

/// <summary>
/// Класс Matrix представляет матрицу с операциями инициализации, вывода и сложения.
/// </summary>
class Matrix
{
    private int[,] data; 

    /// <summary>
    /// Количество строк в матрице.
    /// </summary>
    public int Rows { get; }

    /// <summary>
    /// Количество столбцов в матрице.
    /// </summary>
    public int Cols { get; }

    /// <summary>
    /// Конструктор для создания матрицы с случайными значениями.
    /// </summary>
    /// <param name="rows">Количество строк.</param>
    /// <param name="cols">Количество столбцов.</param>
    public Matrix(int rows, int cols)
    {
        Rows = rows;
        Cols = cols;
        data = new int[rows, cols];

        Random rand = new Random();
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                data[i, j] = rand.Next(1, 11);
    }

    /// <summary>
    /// Выводит матрицу на экран.
    /// </summary>
    public void Print()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
                Console.Write(data[i, j] + "\t");
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Оператор сложения двух матриц.
    /// </summary>
    /// <param name="m1">Первая матрица.</param>
    /// <param name="m2">Вторая матрица.</param>
    /// <returns>Новая матрица, являющаяся суммой двух матриц.</returns>
    /// <exception cref="InvalidOperationException">Выбрасывается, если размеры матриц не совпадают.</exception>
    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            throw new InvalidOperationException("Матрицы должны быть одинакового размера!");

        Matrix result = new Matrix(m1.Rows, m1.Cols);

        for (int i = 0; i < m1.Rows; i++)
            for (int j = 0; j < m1.Cols; j++)
                result.data[i, j] = m1.data[i, j] + m2.data[i, j];

        return result;
    }
}

/// <summary>
/// Главный класс программы для работы с матрицами.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы. Запрашивает у пользователя размеры матриц, создает их, 
    /// выполняет сложение и выводит результаты.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Введите размер матриц:");
        Console.Write("Количество строк: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Количество столбцов: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        Matrix matrix1 = new Matrix(rows, cols);
        Matrix matrix2 = new Matrix(rows, cols);

        Console.WriteLine("\nПервая матрица:");
        matrix1.Print();

        Console.WriteLine("\nВторая матрица:");
        matrix2.Print();

        try
        {
            Matrix resultMatrix = matrix1 + matrix2;
            Console.WriteLine("\nРезультат сложения матриц:");
            resultMatrix.Print();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}
