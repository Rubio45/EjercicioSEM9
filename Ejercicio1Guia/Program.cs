/*
   Programa que sea capaz de almacenar los datos de 10 personas: nombre, dirección,
   teléfono, edad (usando structs). Deberá ir pidiendo los datos uno por uno, hasta que
   el usuario lo decida. Entonces deberá aparecer un menú que permita:
   • Mostrar la lista de todos los nombres.
   • Mostrar las personas de una cierta edad.
   • Mostrar las personas que coincidan con un nombre. Sea el que el usuario indique.
   • Salir del programa.
   - Cada opción del menú representa una función o procedimiento que se invocará desde
   la clase principal.
   - Utilizar funciones o procedimientos con parámetros.
   */

using System;

namespace Ejercicio1Guia
{
   internal class Program
   {
      
      static Person[] people = new Person[0];
      static void Main(string[] args)
      {
         byte option = Menu();
         
         do
         {
            switch (option)
            {
               case 1:
                  Program.AgregarPersona();
                  break;
               case 2:
                  FunctionsName.SearchByName(people);
                  break;
               case 3:
                  FunctionsName.SearchByAges(people);
                  break;
               case 4:
                  FunctionsName.ShowNames(people);
                  break;
               case 0:
                  break;
               default:
                  Console.WriteLine("Option no valida");
                  break;
            }
            Console.Clear();
            option = Menu();
         } while (option != 0);
      }

      static byte Menu()
      {
         byte option;

         Console.WriteLine("MENU DE OPCIONES: ");
         Console.WriteLine("1. Agregar Persona");
         Console.WriteLine("2. Buscar Persona Por Nombre");
         Console.WriteLine("3. Buscar Persona por Edad");
         Console.WriteLine("4. Mostrar Todas Las Personas");
         Console.WriteLine("0. Salir\n\n");
         Console.Write("Introduce una opcion: ");
         option = byte.Parse(Console.ReadLine());
         
         return option;
      }

      public static void AgregarPersona()
      {
         Person persona = new Person();
         
         Console.Write("Nombre: ");
         persona._name = Console.ReadLine();
         Console.Write("Direccion: ");
         persona._address = Console.ReadLine();
         Console.Write("Edad: ");
         persona._age = byte.Parse(Console.ReadLine());
         Console.Write("Numero de telefono: ");
         persona._phoneNumber = Console.ReadLine();

         Array.Resize(ref people, people.Length + 1);
         
         people[people.Length - 1] = persona;
      }
   }
   
   public struct Person
   {
      public string _name;
      public string _address;
      public string _phoneNumber;
      public byte _age;

      public Person(string name, string address, string phoneNumber, byte age)
      {
         _name = name;
         _address = address;
         _phoneNumber = phoneNumber;
         _age = age;
      }
   }
}
