﻿using System;
using System.IO;

class Estudiante
{
    public string Nombre { get; set; }
    public double Calif1 { get; set; }
    public double Calif2 { get; set; }
    public double Calif3 { get; set; }

    public double CalcularPromedio()
    {
        return (Calif1 + Calif2 + Calif3) / 3;
    }
}

class Archivo
{
    private string _rutaArchivo;

    public Archivo(string rutaArchivo)
    {
        _rutaArchivo = rutaArchivo;
    }

    public void GuardarEstudiantes(Estudiante[] estudiantes)
    {
        using (StreamWriter sw = new StreamWriter(_rutaArchivo))
        {
            foreach (var estudiante in estudiantes)
            {
                sw.WriteLine($"{estudiante.Nombre},{estudiante.Calif1},{estudiante.Calif2},{estudiante.Calif3}");
            }
        }

        Console.WriteLine("\nLas notas de los estudiantes han sido guardadas en el archivo 'notas.txt'.");
    }

    public void LeerYCalcularPromedios()
    {
        if (File.Exists(_rutaArchivo))
        {
            string[] lineas = File.ReadAllLines(_rutaArchivo);
            Console.WriteLine("\nPromedios de los estudiantes:");

            foreach (var linea in lineas)
            {
                var datos = linea.Split(',');

                Estudiante estudiante = new Estudiante
                {
                    Nombre = datos[0],
                    Calif1 = Convert.ToDouble(datos[1]),
                    Calif2 = Convert.ToDouble(datos[2]),
                    Calif3 = Convert.ToDouble(datos[3])
                };

                double promedio = estudiante.CalcularPromedio();
                Console.WriteLine($"{estudiante.Nombre}: {promedio:F2}");
            }
        }
        else
        {
            Console.WriteLine("El archivo 'notas.txt' no existe.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        string filePath = "notas.txt";

        Archivo archivo = new Archivo(filePath);

        Estudiante[] estudiantes = ObtenerEstudiantes();

        archivo.GuardarEstudiantes(estudiantes);

        archivo.LeerYCalcularPromedios();
    }

    static Estudiante[] ObtenerEstudiantes()
    {
        Console.Write("¿Cuántos estudiantes desea ingresar? ");
        int cantidadEstudiantes = int.Parse(Console.ReadLine());

        Estudiante[] estudiantes = new Estudiante[cantidadEstudiantes];

        for (int i = 0; i < cantidadEstudiantes; i++)
        {
            Estudiante estudiante = new Estudiante();

            Console.WriteLine($"\nIngresando datos para el estudiante #{i + 1}:");

            Console.Write("Nombre: ");
            estudiante.Nombre = Console.ReadLine();

            Console.Write("Calificación 1: ");
            estudiante.Calif1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Calificación 2: ");
            estudiante.Calif2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Calificación 3: ");
            estudiante.Calif3 = Convert.ToDouble(Console.ReadLine());

            estudiantes[i] = estudiante;
        }

        return estudiantes;
    }
}
