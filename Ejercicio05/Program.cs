using System;
using System.Collections.Generic;
using System.Linq; // Necesario para el método Zip y Sum

public class Vector
{
    // Propiedad para almacenar los componentes del vector
    public List<int> Componentes { get; set; }

    // Constructor que permite inicializar el vector con una lista de componentes
    public Vector(params int[] componentes) // 'params' permite pasar un número variable de argumentos
    {
        Componentes = new List<int>(componentes);
    }

    // Método para calcular el producto escalar con otro vector
    public double CalcularProductoEscalar(Vector otroVector)
    {
        // Verificar que los vectores tengan la misma dimensión
        if (this.Componentes.Count != otroVector.Componentes.Count)
        {
            throw new ArgumentException("Los vectores deben tener la misma dimensión para calcular el producto escalar.");
        }

        // El producto escalar se calcula multiplicando componente a componente
        // y sumando los resultados.
        // Usamos Zip para emparejar los componentes de ambos vectores
        // y Sum para sumar los productos de cada par.
        return this.Componentes.Zip(otroVector.Componentes, (a, b) => a * b).Sum();
    }

    // Método para mostrar el vector por pantalla
    public void MostrarVector()
    {
        Console.WriteLine($"({string.Join(", ", Componentes)})");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // 1. Almacenar los vectores en dos instancias de la clase Vector
        Vector vectorA = new Vector(1, 2, 3);
        Vector vectorB = new Vector(-1, 0, 2);

        Console.Write("Vector A: ");
        vectorA.MostrarVector();

        Console.Write("Vector B: ");
        vectorB.MostrarVector();

        // 2. Calcular el producto escalar
        try
        {
            double productoEscalar = vectorA.CalcularProductoEscalar(vectorB);

            // 3. Mostrar el producto escalar por pantalla
            Console.WriteLine($"\nEl producto escalar de los vectores es: {productoEscalar}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        // Esperamos que el usuario presione una tecla antes de cerrar la consola
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}