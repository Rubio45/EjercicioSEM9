// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

namespace Ejercicio3Guia
{
    class Program
    {
        static void Main()
        {
            List<double> celsiusTemperatures = new List<double>();
            List<double> fahrenheitTemperatures = new List<double>();
            List<double> kelvinTemperatures = new List<double>();

            bool continueProgram = true;

            while (continueProgram)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Agregar temperatura en Celsius.");
                Console.WriteLine("2. Convertir temperaturas a Fahrenheit y Kelvin.");
                Console.WriteLine("3. Mostrar todas las temperaturas convertidas.");
                Console.WriteLine("4. Eliminar temperatura convertida.");
                Console.WriteLine("0. Salir.");
                Console.Write("Seleccione una opcion: ");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Temperatures.AddTemperature(celsiusTemperatures);
                        break;

                    case 2:
                        Temperatures.ConvertTemperatures(celsiusTemperatures, fahrenheitTemperatures, kelvinTemperatures);
                        break;

                    case 3:
                        Temperatures.ShowTemperatures(fahrenheitTemperatures, kelvinTemperatures);
                        break;

                    case 4:
                        Temperatures.RemoveConvertedTemperature(fahrenheitTemperatures, kelvinTemperatures);
                        break;

                    case 0:
                        continueProgram = false;
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opcion no válida. Repite.");
                        break;
                }
            }
        }
    }
}
