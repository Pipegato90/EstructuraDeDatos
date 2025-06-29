using System;
using System.Collections.Generic;
using System.Linq; // Necesario para el método OrderBy

public class Loteria
{
    // Propiedad para almacenar los números ganadores
    public List<int> NumerosGanadores { get; set; }

    // Constructor de la clase Loteria
    public Loteria()
    {
        NumerosGanadores = new List<int>();
    }

    // Método para pedir al usuario que ingrese los números de la lotería
    public void PedirNumerosGanadores(int cantidadNumeros)
    {
        Console.WriteLine($"\nPor favor, ingresa los {cantidadNumeros} números ganadores de la lotería primitiva:");

        for (int i = 0; i < cantidadNumeros; i++)
        {
            int numeroIngresado;
            bool entradaValida = false;
            do
            {
                Console.Write($"Ingresa el número {i + 1}: ");
                string input = Console.ReadLine();

                // Intentar convertir la entrada a un número entero
                // Validar que sea un número y que no se repita
                if (int.TryParse(input, out numeroIngresado) && numeroIngresado > 0 && numeroIngresado <= 49) // Asumiendo números de 1 a 49 para la primitiva
                {
                    if (NumerosGanadores.Contains(numeroIngresado))
                    {
                        Console.WriteLine("Este número ya fue ingresado. Por favor, ingresa un número diferente.");
                    }
                    else
                    {
                        NumerosGanadores.Add(numeroIngresado);
                        entradaValida = true;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingresa un número entero entre 1 y 49.");
                }
            } while (!entradaValida);
        }
    }

    // Método para mostrar los números ganadores ordenados de menor a mayor
    public void MostrarNumerosOrdenados()
    {
        if (NumerosGanadores.Count == 0)
        {
            Console.WriteLine("No se han ingresado números ganadores.");
            return;
        }

        // Ordenar la lista de números de menor a mayor
        // Usamos OrderBy de LINQ para ordenar la lista.
        // ToList() crea una nueva lista ordenada sin modificar la original.
        List<int> numerosOrdenados = NumerosGanadores.OrderBy(n => n).ToList();

        Console.WriteLine("\nLos números ganadores de la lotería (ordenados de menor a mayor) son:");
        foreach (int numero in numerosOrdenados)
        {
            Console.Write($"{numero} ");
        }
        Console.WriteLine(); // Para una nueva línea al final
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Creamos una instancia de la clase Loteria
        Loteria miLoteria = new Loteria();

        // Definimos cuántos números se deben ingresar para la lotería (ej. 6 para la Primitiva)
        const int CANTIDAD_NUMEROS_LOTERIA = 6;

        // Pedimos al usuario que ingrese los números ganadores
        miLoteria.PedirNumerosGanadores(CANTIDAD_NUMEROS_LOTERIA);

        // Mostramos los números ordenados
        miLoteria.MostrarNumerosOrdenados();

        // Esperamos que el usuario presione una tecla antes de cerrar la consola
        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}