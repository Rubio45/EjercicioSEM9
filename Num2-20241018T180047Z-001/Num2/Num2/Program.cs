using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Num2
{
    
    internal class Program
    {

       

        static Product[] productos = new Product[0];


        static void Main(string[] args)
        {

            double valor;
            int cant;
            
            bool running = true;
            int op;
            while(running)
            {

                Console.WriteLine("Menu");
                Console.WriteLine("1. Añadir productos");
                Console.WriteLine("2. Actualizar stock");
                Console.WriteLine("3. Calcular inventario");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Digite su opcion");
                op = int.Parse(Console.ReadLine());

                switch(op)
                {
                    //nombre, un precio y una cantidad
                    case 1:

                        
                        Program.AgregarProducto();

                        Console.WriteLine("Lista de productos");
                        Class1.ImprimirProductos(productos);


                        break;

                    case 2:

                        Class1.EditarStock(productos);

                        break;


                    case 3:

                        Console.WriteLine("");
                        valor = Class1.CalcularTotal(productos);
                        Console.WriteLine($"El valor total del inventario es: {valor}");
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

        public static void AgregarProducto()
        {
            Product nuevoproducto = new Product();
            int tam;

            Console.WriteLine("Ingrese cuantos productos quiere agregar");
            tam= int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la siguiente informacion del producto que quiere agregar");

            for (int i = 0; i < tam; i++)
            {
                Console.Write("Nombre: ");
                nuevoproducto._nombre = Console.ReadLine();
                Console.Write("Precio: ");
                nuevoproducto._precio = double.Parse(Console.ReadLine());
                Console.Write("Cantidad: ");
                nuevoproducto._cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine();
                

                Array.Resize(ref productos, productos.Length + 1);

                productos[productos.Length - 1] = nuevoproducto;

            }


            
        }

        

    }

    public struct Product
    {
        public string _nombre;
        public double _precio;
        public int _cantidad;

        public Product(string nombre, double precio, int cantidad)
        {
            _nombre = nombre;
            _precio = precio;
            _cantidad = cantidad;
        }
    }








}
