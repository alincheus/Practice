using System;

class Matrix
{
    private int[,] data; 
    public int Rows { get; private set; }
    public int Cols { get; private set; }
    public Matrix() : this(3, 3) { }

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

class Program
{
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
