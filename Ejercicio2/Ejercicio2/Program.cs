using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Implementa un programa que use un arreglo estático para almacenar las ventas diarias
de un negocio. Crea funciones para: 

ingresar las ventas, 
calcular el total vendido y

encontrar el día con la venta más alta.
- Utilizar funciones con parámetros.
- Implementar ciclos.


arreglo estático
*/
namespace Ejercicio2
{
    internal class Program
    {
        static int[] ventas = new int[7];


        static void Main(string[] args)
        {

             bool running = true;
             int op;
             while (running)
             {

                 Console.WriteLine("Menu");
                 Console.WriteLine("1. Ingresar venta");
                 Console.WriteLine("2. Calcular total de ventas");
                 Console.WriteLine("3. Ver dia con mas ventas");
                 Console.WriteLine("4. Salir");
                 Console.WriteLine("Digite su opcion");
                 op = int.Parse(Console.ReadLine());

                 switch (op)
                 {
                     //nombre, un precio y una cantidad
                     case 1:

                              Class1.IngresarVentas(ventas);
                        Console.WriteLine("Ventas Registradas");
                              

                        break;

                     case 2:

                        int totalVendido = Class1.CalcularTotalVendido(ventas);
                        Console.WriteLine($"Total : {totalVendido}");


                        break;


                     case 3:

                        int diaVentaMaxima = Class1.EncontrarDiaMayorVenta(ventas);
                        Console.WriteLine($" Dia: {diaVentaMaxima + 1} - Ventas:  {ventas[diaVentaMaxima]}");


                        break;

                     case 4:

                          Console.WriteLine("Saliendo del programa...");
                          running = false;

                         break;


                    default:

                     Console.WriteLine("Opcion no valida");
                     break;

                 }


             }
              Console.WriteLine("Programa terminado");

            Console.ReadKey();

        }


        

        

        
    }
}
