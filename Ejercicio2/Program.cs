using System;

class Program
{
    static void Main()
    {
        string[] nombres = new string[5];

        Console.WriteLine("Ingresa 5 nombres:");
        for (int i = 0; i < 5; i++)
        {
            nombres[i] = Console.ReadLine();
        }

        Console.WriteLine("Ingresa un nombre para buscar:");
        string nombreBuscado = Console.ReadLine();

        for (int i = 0; i < 5; i++)
        {
            if (nombres[i] == nombreBuscado)
            {
                Console.WriteLine("El nombre está en la posición " + i);
                return;
            }
        }

        Console.WriteLine("El nombre no está en la lista.");
    }
}
