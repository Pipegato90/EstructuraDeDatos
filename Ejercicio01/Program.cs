using System;
using System.Collections.Generic;

public class Curso
{
    // Propiedad para almacenar las asignaturas
    public List<string> Asignaturas { get; set; }

    // Constructor de la clase Curso
    public Curso()
    {
        // Inicializamos la lista de asignaturas
        Asignaturas = new List<string>();
    }

    // Método para agregar una asignatura a la lista
    public void AgregarAsignatura(string asignatura)
    {
        Asignaturas.Add(asignatura);
    }

    // Método para mostrar todas las asignaturas
    public void MostrarAsignaturas()
    {
        if (Asignaturas.Count == 0)
        {
            Console.WriteLine("No hay asignaturas en este curso.");
            return;
        }

        Console.WriteLine("Asignaturas del curso:");
        foreach (string asignatura in Asignaturas)
        {
            Console.WriteLine($"- {asignatura}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Creamos una instancia de la clase Curso
        Curso miCurso = new Curso();

        // Agregamos las asignaturas al curso
        miCurso.AgregarAsignatura("Matemáticas");
        miCurso.AgregarAsignatura("Física");
        miCurso.AgregarAsignatura("Química");
        miCurso.AgregarAsignatura("Historia");
        miCurso.AgregarAsignatura("Lengua");

        // Mostramos las asignaturas por pantalla
        miCurso.MostrarAsignaturas();

        // Esperamos que el usuario presione una tecla antes de cerrar la consola
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}