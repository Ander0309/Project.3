using System;
public class MatrixB : Matrix
{
    private readonly int _n, _p;
    public int N { get => _n; }
    public int P { get => _p; }

    public MatrixB(int n, int p) : base(n, p)
    {
        ValidateDimensions(n, p);
        _n = n;
        _p = p;
        FillMatrix();
    }

    private void FillMatrix()
    {
        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _p; j++)
            {
                SetValue(i, j, (j + 1) * i);
            }
        }
    }
}