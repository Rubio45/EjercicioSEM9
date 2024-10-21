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
    internal class Class1
    {


        public static void IngresarVentas(int[] ventas)
        {
            for (int i = 0; i < ventas.Length; i++)
            {
                Console.Write($"Ingresa la venta del día {i + 1}: ");
                ventas[i] = int.Parse(Console.ReadLine());
            }
        }

        public static int CalcularTotalVendido(int[] ventas)
        {
            int total = 0;
            foreach (int venta in ventas)
            {
                total += venta;
            }
            return total;
        }

        public static int EncontrarDiaMayorVenta(int[] ventas)
        {
            int diaMayorVenta = 0; // Asumimos que el primer día es el de mayor venta inicialmente
            int ventaMaxima = ventas[0];

            for (int i = 1; i < ventas.Length; i++)
            {
                if (ventas[i] > ventaMaxima)
                {
                    ventaMaxima = ventas[i];
                    diaMayorVenta = i;
                }
            }

            return diaMayorVenta; // Retornamos el índice del día con mayor venta
        }







    }
}
