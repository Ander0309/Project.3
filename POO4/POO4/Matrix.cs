using System;

public abstract class Matrix
{
    private readonly int[,] _data;
    public int Rows { get; }
    public int Cols { get; }

    protected Matrix(int rows, int cols)
    {
        ValidateDimensions(rows, cols);
        Rows = rows;
        Cols = cols;
        _data = new int[rows, cols];
    }

    protected static void ValidateDimensions(int rows, int cols)
    {
        if (rows <= 0 || cols <= 0)
            throw new ArgumentException("Las dimensiones de la matriz deben ser mayores que cero.");
    }

    protected int GetValue(int i, int j) => _data[i, j];
    protected void SetValue(int i, int j, int value) => _data[i, j] = value;

    public static MatrixC Multiply(MatrixA A, MatrixB B)
    {
        if (A.Cols != B.Rows)
            throw new InvalidOperationException("No se pueden multiplicar las matrices: dimensiones incompatibles.");

        MatrixC result = new MatrixC(A.Rows, B.Cols);

        for (int i = 0; i < A.Rows; i++)
        {
            for (int j = 0; j < B.Cols; j++)
            {
                int sum = 0;
                for (int k = 0; k < A.Cols; k++)
                {
                    sum += A.GetValue(i, k) * B.GetValue(k, j);
                }
                result.SetValue(i, j, sum);
            }
        }
        return result;
    }

    public void Print(string name)
    {
        Console.WriteLine($"*** {name} ***");
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                Console.Write(GetValue(i, j) + " ");
            }
            Console.WriteLine();
        }
    }
}