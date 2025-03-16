using System;

class Program
{
    static void Main()
    {
        int tamano = ValidateRombus();
        Rombo rombo = new Rombo(tamano);
        rombo.Imprimir(); 
    }

    private static int ValidateRombus()
    {
        int tamano;
        do
        {
            Console.Write("Ingrese un tamaño impar para el rombo: ");
            if (!int.TryParse(Console.ReadLine(), out tamano) || tamano % 2 == 0 || tamano < 1)
            {
                Console.WriteLine("Error: Debe ingresar un número impar positivo.");
                tamano = -1;
            }
        } while (tamano == -1);

        return tamano;
    }
}
