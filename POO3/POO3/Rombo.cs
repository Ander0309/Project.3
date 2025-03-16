using System;

public class Rombo
{
    private int tamano;

    public Rombo(int tamano)
    {
        this.tamano = tamano;
    }

    public void Imprimir()
    {
        int mitad = tamano / 2;

        for (int i = 0; i <= mitad; i++)
        {
            for (int j = 0; j < mitad - i; j++)
                Console.Write(" ");

            for (int j = 0; j < i * 2 + 1; j++)
            {
                if (j == 0 || j == i * 2)
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

        for (int i = mitad - 1; i >= 0; i--)
        {
            for (int j = 0; j < mitad - i; j++)
                Console.Write(" ");

            for (int j = 0; j < i * 2 + 1; j++)
            {
                if (j == 0 || j == i * 2)
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}