using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPHotel.Entidades;
using TPHotel.Negocio;

namespace TPHotel.Consola
{
    internal class Interacciones
    {
        public static Cliente SolicitarDatosCliente()
        {
            Cliente cliente = new Cliente(0 ,DateTime.Now, true, "", "", "", "", "", DateTime.Now);
            
            Console.Clear();
            Console.WriteLine("Menú - Solicitar datos del cliente");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el nomnbre:");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido:");
            cliente.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la dirección:");
            cliente.Direccion = Console.ReadLine();
            Console.WriteLine("Ingrese el teléfono:");
            cliente.Telefono = Console.ReadLine();
            Console.WriteLine("Ingrese el email:");
            cliente.Email = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de nacimiento: (yyyy-mm-dd)");
            cliente.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Fin carga de datos.");
            return cliente;
        }
    }
}
