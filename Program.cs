using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("Menú de Opciones");
            Console.WriteLine("1. Sumar números pares hasta 75 (for)");
            Console.WriteLine("2. Encontrar el número más grande en una lista (foreach)");
            Console.WriteLine("3. Generar tabla de multiplicar (for)");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        SumarNumerosPares();
                        break;
                    case 2:
                        EncontrarNumeroMasGrande();
                        break;
                    case 3:
                        GenerarTablaDeMultiplicar();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
            }
        } while (opcion != 4);
    }

    static void SumarNumerosPares()
    {
        int suma = 0;
        for (int i = 2; i <= 75; i += 2)
        {
            suma += i;
        }
        Console.WriteLine("La suma de los números pares hasta 75 es: " + suma);
    }

    static void EncontrarNumeroMasGrande()
    {
        List<int> numeros = new List<int> { 12, 5, 67, 89, 43, 22, 56, 90, 11 };
        int max = numeros[0];
        foreach (int num in numeros)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine("El número más grande en la lista es: " + max);
    }

    static void GenerarTablaDeMultiplicar()
    {
        Console.Write("Ingrese un número para generar su tabla de multiplicar: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine("Tabla de multiplicar de " + n + " (con suma de 2):");
            for (int i = 1; i <= 12; i++)
            {
                int resultado = n * i + 2;
                Console.WriteLine($"{n} x {i} = {resultado}");
            }
        }
        else
        {
            Console.WriteLine("Número no válido. Intente de nuevo.");
        }
    }
}

