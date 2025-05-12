using System;

/// <summary>
/// Класс Matrix представляет матрицу с операциями инициализации, вывода, изменения размера и доступа к элементам.
/// </summary>
class Matrix
{
    private int[,] data;

    /// <summary>
    /// Количество строк в матрице.
    /// </summary>
    public int Rows { get; private set; }

    /// <summary>
    /// Количество столбцов в матрице.
    /// </summary>
    public int Cols { get; private set; }

    /// <summary>
    /// Конструктор по умолчанию. Создает матрицу 3x3.
    /// </summary>
    public Matrix() : this(3, 3) { }

    /// <summary>
    /// Создает матрицу с заданным количеством строк и столбцов, заполняя случайными значениями.
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
                data[i, j] = rand.Next(1, 101); 
    }

    /// <summary>
    /// Выводит матрицу на экран.
    /// </summary>
    public void PrintMatrix()
    {
        Console.WriteLine("Матрица:");
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
                Console.Write(data[i, j] + "\t");
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Выводит подматрицу заданного размера, начиная с указанной позиции.
    /// </summary>
    /// <param name="startRow">Начальная строка.</param>
    /// <param name="startCol">Начальный столбец.</param>
    /// <param name="subRows">Количество строк в подматрице.</param>
    /// <param name="subCols">Количество столбцов в подматрице.</param>
    public void PrintSubMatrix(int startRow, int startCol, int subRows, int subCols)
    {
        if (startRow + subRows > Rows || startCol + subCols > Cols)
        {
            Console.WriteLine("Ошибка: размеры подматрицы выходят за пределы основной матрицы!");
            return;
        }

        Console.WriteLine("Подматрица:");
        for (int i = startRow; i < startRow + subRows; i++)
        {
            for (int j = startCol; j < startCol + subCols; j++)
                Console.Write(data[i, j] + "\t");
            Console.WriteLine();
        }
    }

    /// <summary>
    /// Индексатор для доступа к элементу матрицы по строке и столбцу.
    /// </summary>
    /// <param name="row">Индекс строки.</param>
    /// <param name="col">Индекс столбца.</param>
    /// <returns>Значение элемента матрицы.</returns>
    /// <exception cref="IndexOutOfRangeException">Выбрасывается при неверных индексах.</exception>
    public int this[int row, int col]
    {
        get
        {
            if (row < 0 || row >= Rows || col < 0 || col >= Cols)
                throw new IndexOutOfRangeException("Некорректные индексы!");
            return data[row, col];
        }
        set
        {
            if (row < 0 || row >= Rows || col < 0 || col >= Cols)
                throw new IndexOutOfRangeException("Некорректные индексы!");
            data[row, col] = value;
        }
    }

    /// <summary>
    /// Изменяет размер матрицы, сохраняя старые данные, если они помещаются в новую структуру.
    /// </summary>
    /// <param name="newRows">Новое количество строк.</param>
    /// <param name="newCols">Новое количество столбцов.</param>
    public void Resize(int newRows, int newCols)
    {
        int[,] newData = new int[newRows, newCols];
        int minRows = Math.Min(Rows, newRows);
        int minCols = Math.Min(Cols, newCols);

        for (int i = 0; i < minRows; i++)
            for (int j = 0; j < minCols; j++)
                newData[i, j] = data[i, j];

        data = newData;
        Rows = newRows;
        Cols = newCols;
    }
}

/// <summary>
/// Основной класс программы для работы с матрицами.
/// </summary>
class Program
{
    /// <summary>
    /// Главный метод программы. Создает матрицу, изменяет её размеры и демонстрирует работу индексатора.
    /// </summary>
    static void Main()
    {
        Matrix matrix = new Matrix(4, 5);

        matrix.PrintMatrix();

        matrix.PrintSubMatrix(1, 1, 2, 2);

        Console.WriteLine($"Элемент [2,3]: {matrix[2, 3]}");
        matrix[2, 3] = 99;
        Console.WriteLine($"Измененный элемент [2,3]: {matrix[2, 3]}");

        matrix.Resize(6, 4);
        Console.WriteLine("\nМатрица после изменения размера:");
        matrix.PrintMatrix();
    }
}
