using System;

class Matriz
{
    public int[,] Valores { get; set; }

    public Matriz(int filas, int columnas)
    {
        Valores = new int[filas, columnas];
    }

    public void Mostrar()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(Valores[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public void MultiplicarFila(int multiplicador)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Valores[i, j] *= multiplicador;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Matriz matriz = new Matriz(3, 3);

        Console.WriteLine("Ingresa los valores para la matriz 3x3:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Valor en la posición [{i + 1}, {j + 1}]: ");
                matriz.Valores[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nMatriz original:");
        matriz.Mostrar();

        Console.Write("\nIngresa el número para multiplicar cada fila: ");
        int multiplicador = int.Parse(Console.ReadLine());

        matriz.MultiplicarFila(multiplicador);

        Console.WriteLine("\nMatriz después de la multiplicación:");
        matriz.Mostrar();
    }
}
