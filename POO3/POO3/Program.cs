using System;

class Program
{
    static void Main()
    {
        int tamano = ValidateRombus(); // Llamamos a la función de validación
        Rombo rombo = new Rombo(tamano); // Creamos un objeto de la clase Rombo
        rombo.Imprimir(); // Imprimimos el rombo
    }

    // Método de validación dentro de Program
    private static int ValidateRombus()
    {
        int tamano;
        do
        {
            Console.Write("Ingrese un tamaño impar para el rombo: ");
            if (!int.TryParse(Console.ReadLine(), out tamano) || tamano % 2 == 0 || tamano < 1)
            {
                Console.WriteLine("Error: Debe ingresar un número impar positivo.");
                tamano = -1; // Valor inválido para repetir el bucle
            }
        } while (tamano == -1);

        return tamano;
    }
}
