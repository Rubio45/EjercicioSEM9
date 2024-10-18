
/*
 * Mostrar la lista de todos los nombres.
   • Mostrar las personas de una cierta edad.
   • Mostrar las personas que coincidan con un nombre. Sea el que el usuario indique.
   • Salir del programa.
   - Cada opción del menú representa una función o procedimiento que se invocará desde
   la clase principal.
   - Utilizar funciones o procedimientos con parámetros.
   
   STRUCT
   nombre, dirección,
   teléfono, edad (usando structs).
 */
using System;

namespace Ejercicio1Guia;
public class FunctionsName
{

    public static void ShowNames(Person[] people)
    {
        Console.WriteLine("NOMBRES DE LAS PERSONAS:\n----------------------------");
        byte counter = 1;
        foreach (var person in people)
        {
            Console.WriteLine($"{counter}- {person._name}");
            counter += 1;
        }

        Console.ReadKey();
    }

    public static void SearchByAges(Person[] people)
    {
        Console.Write("EDAD DE LAS PERSONAS A BUSCAR: ");
        byte age = byte.Parse(Console.ReadLine());
        byte counter = 0;
        foreach (var person in people)
        {
            if (person._age == age)
            {
                Console.WriteLine($"{age} - {person._name}");
                counter += 1;
            }
        }

        if (counter == 0)
        {
            Console.WriteLine("Nadie tiene esta edad");
        }

        Console.ReadKey();
    }

    // Mostrar las personas que coincidan con un nombre. Sea el que el usuario indique.

    public static void SearchByName(Person[] people)
    {
        Console.Write("NOMBRE DE LA PERSONA A BUSCAR: ");
        string name = Console.ReadLine();

        foreach (var person in people)
        {
            if (person._name == name)
            {
                Console.WriteLine($"{person._name} - {person._age} años - {person._phoneNumber}");
            }

            Console.ReadKey();
        }
    }
}
