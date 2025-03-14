using System;
public class MatrixC : Matrix
{
    private readonly int _m, _p;
    public int M { get => _m; }
    public int P { get => _p; }

    public MatrixC(int m, int p) : base(m, p)
    {
        ValidateDimensions(m, p);
        _m = m;
        _p = p;
    }
}

