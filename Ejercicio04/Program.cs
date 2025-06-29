using System;
using System.Collections.Generic;
using System.Linq; // Necesario para el método Reverse y Join

public class NumerosSecuenciales
{
    // Propiedad para almacenar los números
    public List<int> Numeros { get; set; }

    // Constructor de la clase NumerosSecuenciales
    public NumerosSecuenciales()
    {
        Numeros = new List<int>();
    }

    // Método para generar y almacenar números en la lista
    public void GenerarNumeros(int inicio, int fin)
    {
        if (inicio > fin)
        {
            Console.WriteLine("El número de inicio no puede ser mayor que el número final.");
            return;
        }

        for (int i = inicio; i <= fin; i++)
        {
            Numeros.Add(i);
        }
    }

    // Método para mostrar los números en orden inverso, separados por comas
    public void MostrarNumerosInversosSeparadosPorComas()
    {
        if (Numeros.Count == 0)
        {
            Console.WriteLine("La lista de números está vacía.");
            return;
        }

        // Obtener la lista en orden inverso
        // El método Reverse() de List<T> invierte la lista en su lugar.
        // Si no quieres modificar la original, puedes usar Numeros.AsEnumerable().Reverse().ToList();
        Numeros.Reverse();

        // Unir los números en una sola cadena, separados por comas
        // string.Join() es muy eficiente para esto.
        string numerosInversos = string.Join(", ", Numeros);

        Console.WriteLine($"Los números en orden inverso son: {numerosInversos}");

        // Opcional: Revertir la lista a su orden original si es necesario para futuras operaciones
        // Numeros.Reverse();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Creamos una instancia de la clase NumerosSecuenciales
        NumerosSecuenciales misNumeros = new NumerosSecuenciales();

        // Generamos los números del 1 al 10 y los almacenamos
        misNumeros.GenerarNumeros(1, 10);

        // Mostramos los números en orden inverso y separados por comas
        misNumeros.MostrarNumerosInversosSeparadosPorComas();

        // Esperamos que el usuario presione una tecla antes de cerrar la consola
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}