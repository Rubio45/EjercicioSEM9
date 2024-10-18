using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

/*Crea un programa que administre un inventario de productos.Cada producto tiene un nombre, un precio y una cantidad en stock. 
El programa debe permitir:
✓ Añadir nuevos productos al inventario.
✓ Actualizar la cantidad en stock de un producto
existente.
✓ Calcular el valor total del inventario (sumando el valor de cada producto: precio × cantidad en stock).
*/
namespace Num2
{
    internal class Class1
    {
        
        public static void ImprimirProductos(Product[] productos )
        {

            byte counter = 1;

            foreach (var producto in productos)
            {
                Console.WriteLine($"{counter}- {producto._nombre}- {producto._precio}- {producto._cantidad}");
                Console.WriteLine("  ");

                counter += 1;
            }


        }

        
        public static double CalcularTotal(Product[] productos)
        {

            double total =0;
            double suma = 0;

            

            for (int indice = 0; indice < productos.Length; indice++)
            {

                total = productos[indice]._precio * productos[indice]._cantidad;
                suma = suma + total;


            }

            return suma;
  
        }

        public static void EditarStock(Product[] productos)
        {
            Console.WriteLine("Ingrese el nombre del producto:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del producto:");
            double precio = double.Parse(Console.ReadLine());

            for (int i = 0;i < productos.Length; i++)
            {
                if (productos[i]._nombre == nombre && productos[i]._precio == precio)
                {
                    Console.WriteLine($"Cantidad actual: {productos[i]._cantidad}");
                    Console.WriteLine("Ingresa la cantidad actualizada del producto: ");
                    productos[i]._cantidad = int.Parse(Console.ReadLine());

                }
                else
                {

                    Console.WriteLine("El producto no se encuentra registrado");
                }

            }


        }

    }
}
