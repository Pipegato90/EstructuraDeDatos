using System;
using System.Collections.Generic;

// Clase para representar una Asignatura con su nombre y nota
public class Asignatura
{
    public string Nombre { get; set; }
    public double Nota { get; set; }

    // Constructor para inicializar una asignatura con su nombre
    public Asignatura(string nombre)
    {
        Nombre = nombre;
    }
}

public class Curso
{
    // Ahora, la lista almacenará objetos de tipo Asignatura
    public List<Asignatura> Asignaturas { get; set; }

    // Constructor de la clase Curso
    public Curso()
    {
        Asignaturas = new List<Asignatura>();
    }

    // Método para agregar una asignatura (solo el nombre al inicio)
    public void AgregarAsignatura(string nombreAsignatura)
    {
        Asignaturas.Add(new Asignatura(nombreAsignatura));
    }

    // Método para pedir y almacenar las notas de cada asignatura
    public void PedirNotasAsignaturas()
    {
        Console.WriteLine("\nPor favor, ingresa la nota para cada asignatura:");
        foreach (Asignatura asignatura in Asignaturas)
        {
            double notaIngresada;
            bool entradaValida = false;
            do
            {
                Console.Write($"Introduce la nota de {asignatura.Nombre}: ");
                string input = Console.ReadLine();

                // Intentar convertir la entrada a un número decimal
                // Si la conversión falla o la nota no está entre 0 y 10 (o el rango que consideres)
                if (double.TryParse(input, out notaIngresada) && notaIngresada >= 0 && notaIngresada <= 10) // Asumiendo notas de 0 a 10
                {
                    asignatura.Nota = notaIngresada;
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingresa un número entre 0 y 10.");
                }
            } while (!entradaValida);
        }
    }

    // Método para mostrar las asignaturas con sus notas
    public void MostrarAsignaturasConNotas()
    {
        if (Asignaturas.Count == 0)
        {
            Console.WriteLine("No hay asignaturas en este curso para mostrar notas.");
            return;
        }

        Console.WriteLine("\nResumen de tus notas:");
        foreach (Asignatura asignatura in Asignaturas)
        {
            Console.WriteLine($"En {asignatura.Nombre} has sacado {asignatura.Nota}");
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

        // Pedimos al usuario que ingrese las notas
        miCurso.PedirNotasAsignaturas();

        // Mostramos las asignaturas y sus notas
        miCurso.MostrarAsignaturasConNotas();

        // Esperamos que el usuario presione una tecla antes de cerrar la consola
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}