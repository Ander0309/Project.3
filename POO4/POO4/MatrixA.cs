using System;

public class MatrixA : Matrix
{
    private readonly int _m, _n;
    public int M { get => _m; }
    public int N { get => _n; }

    public MatrixA(int m, int n) : base(m, n)
    {
        ValidateDimensions(m, n);
        _m = m;
        _n = n;
        FillMatrix();
    }

    private void FillMatrix()
    {
        for (int i = 0; i < _m; i++)
        {
            for (int j = 0; j < _n; j++)
            {
                _data[i, j] = (i + 1) * j;
            }
        }
    }
}
