using System;
using System.Threading;
using System.Collections.Generic;
using TPHotel.Entidades;
using TPHotel.Negocio;

namespace TPHotel.Consola
{
    public class Menu
    {
        public static void MenuBienvenida()
        {
            Console.WriteLine("***   Welcome to Rich Texan Hotel   ***");
            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para comenzar...");
            Console.WriteLine();
            Console.ReadKey();
        }


        public static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("***   Menú principal del hotel   ***");
            Console.WriteLine();
            Console.WriteLine("1 - Listar todas las reservas");
            Console.WriteLine("2 - Listar todos los clientes");
            Console.WriteLine("3 - Listar todos los hoteles");
            Console.WriteLine("4 - Listar habitaciones del hotel 1");
            Console.WriteLine("5 - Agregar un cliente");
            Console.WriteLine("6 - Salir del sistema");
            Console.WriteLine();
            Console.WriteLine("Su opción:");
        }

        public static bool DeseaContinuar()
        {
            Console.WriteLine("Presione 1 si desea continuar, sino cualquier tecla para salir.");
            if (Console.ReadLine() == "1")
            {
                return true;
            }
            else { return false; }
        }

        public static void Salir()
        {
            Console.Clear();
            Console.WriteLine(@" /\_/\");
            Console.WriteLine(@"(=^.^=)");
            Console.WriteLine("(\") (\")");
            Thread.Sleep(2000);
            Console.Clear();
        }
        
        public static void Pausa()
        {
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para Continuar...");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
