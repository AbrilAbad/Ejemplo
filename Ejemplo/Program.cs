using Microsoft.VisualBasic;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese frases. Escriba 'fin' para terminar.");

        // Ciclo para permitir el ingreso de frases hasta que se ingrese "fin"
        while (true)
        {
            // Solicitar al usuario que ingrese una frase
            string frase = Console.ReadLine();

            // Verificar si se ingresó "fin" para terminar el ciclo
            if (frase.ToLower() == "fin")
            {
                Console.WriteLine("Terminando el ingreso de frases...");
                break; // Salir del ciclo
            }

            // Mostrar la frase ingresada por el usuario
            Console.WriteLine("Frase ingresada: " + frase);
        }

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();

    }

    }


