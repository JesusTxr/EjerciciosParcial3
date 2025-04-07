using System;
class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int suma = 0;

        Console.WriteLine("Ingresa 10 números enteros:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
            suma += numeros[i];
        }

        double promedio = (double)suma / 10;

        Console.WriteLine("La suma total es: " + suma);
        Console.WriteLine("El promedio es: " + promedio);
    }
}
