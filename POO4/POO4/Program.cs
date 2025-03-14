using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el valor de m: ");
        int m = GetPositiveInt();
        Console.Write("Ingrese el valor de n: ");
        int n = GetPositiveInt();
        Console.Write("Ingrese el valor de p: ");
        int p = GetPositiveInt();

        MatrixA A = new MatrixA(m, n);
        MatrixB B = new MatrixB(A.N, p);
        MatrixC C = Matrix.Multiply(A, B);

        A.Print("A");
        B.Print("B");
        C.Print("C");
    }

    static int GetPositiveInt()
    {
        int value;
        while (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
        {
            Console.Write("Valor inválido. Ingrese un número entero positivo: ");
        }
        return value;
    }
}