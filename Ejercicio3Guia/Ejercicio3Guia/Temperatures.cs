namespace Ejercicio3Guia;

public class Temperatures
{
    public static void AddTemperature(List<double> celsiusTemperatures)
    {
        Console.Write("Ingrese una temperatura en Celsius: ");
        double temp = double.Parse(Console.ReadLine());
        celsiusTemperatures.Add(temp);
        Console.WriteLine("Temperatura agregada.");
    }

    public static void ConvertTemperatures(List<double> celsiusTemps, List<double> fahrenheitTemps, List<double> kelvinTemps)
    {
        fahrenheitTemps.Clear();
        kelvinTemps.Clear();

        foreach (var tempCelsius in celsiusTemps)
        {
            fahrenheitTemps.Add(CelsiusToFahrenheit(tempCelsius));
            kelvinTemps.Add(CelsiusToKelvin(tempCelsius));
        }

        Console.WriteLine("Temperaturas convertidas a Fahrenheit y Kelvin.");
    }

    public static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double CelsiusToKelvin(double celsius)
    {
        return celsius + 273.15;
    }

    public static void ShowTemperatures(List<double> fahrenheitTemps, List<double> kelvinTemps)
    {
        Console.WriteLine("\nTemperaturas en Fahrenheit:");
        for (int i = 0; i < fahrenheitTemps.Count; i++)
        {
            Console.WriteLine($"Fahrenheit [{i}]: {fahrenheitTemps[i]}");
        }

        Console.WriteLine("\nTemperaturas en Kelvin:");
        for (int i = 0; i < kelvinTemps.Count; i++)
        {
            Console.WriteLine($"Kelvin [{i}]: {kelvinTemps[i]}");
        }
    }

    public static void RemoveConvertedTemperature(List<double> fahrenheitTemps, List<double> kelvinTemps)
    {
        Console.WriteLine("\nSeleccione de cual lista desea eliminar una temperatura:");
        Console.WriteLine("1. Fahrenheit");
        Console.WriteLine("2. Kelvin");
        Console.Write("Seleccione una opción: ");
        int choice = int.Parse(Console.ReadLine());

        List<double> selectedList = null;
        string unit = "";

        if (choice == 1)
        {
            selectedList = fahrenheitTemps;
            unit = "Fahrenheit";
        }
        else if (choice == 2)
        {
            selectedList = kelvinTemps;
            unit = "Kelvin";
        }
        else
        {
            Console.WriteLine("Opción no válida.");
            return;
        }

        if (selectedList.Count > 0)
        {
            Console.WriteLine($"\nSeleccione el índice de la temperatura en {unit} que desea eliminar:");
            for (int i = 0; i < selectedList.Count; i++)
            {
                Console.WriteLine($"{i}: {selectedList[i]}");
            }

            int index = int.Parse(Console.ReadLine());
            if (index >= 0 && index < selectedList.Count)
            {
                selectedList.RemoveAt(index);
                Console.WriteLine($"Temperatura eliminada de la lista de {unit}.");
            }
            else
            {
                Console.WriteLine("Índice no válido.");
            }
        }
        else
        {
            Console.WriteLine($"No hay temperaturas en la lista de {unit}.");
        }
    }
}
