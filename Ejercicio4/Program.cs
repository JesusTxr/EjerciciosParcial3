using System;

class ArregloNumeros
{
    private int[] numeros;

    public ArregloNumeros()
    {
        numeros = new int[5];
    }

    public void IngresarNumeros()
    {
        Console.WriteLine("Ingrese 5 números enteros:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
    }

    public void MostrarArreglo()
    {
        Console.WriteLine("Arreglo original:");
        foreach (int num in numeros)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    public void MostrarArregloInvertido()
    {
        Console.WriteLine("Arreglo invertido:");
        for (int i = numeros.Length - 1; i >= 0; i--)
        {
            Console.Write(numeros[i] + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        ArregloNumeros arreglo = new ArregloNumeros();
        arreglo.IngresarNumeros();
        arreglo.MostrarArreglo();
        arreglo.MostrarArregloInvertido();
    }
}
