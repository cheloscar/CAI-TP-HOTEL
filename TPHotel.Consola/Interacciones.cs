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
            return cliente;
        }
        public static Reserva SolicitarDatosReserva()
        {
            Reserva reserva = new Reserva(0, 0, 0, DateTime.Now, DateTime.Now);

            Console.Clear();
            Console.WriteLine("Menú - Solicitar datos de la reserva");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el ID de la habitación:");
            reserva.IdHabitacion = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el ID del cliente:");
            reserva.IdCliente = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de huéspedes:");
            reserva.CantidadHuespedes = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de ingreso: (yyyy-mm-dd)");
            reserva.FechaIngreso = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de egreso: (yyyy-mm-dd)");
            reserva.FechaEgreso = Convert.ToDateTime(Console.ReadLine());
            return reserva;
        }
        public static HotelEntidad SolicitarDatosHotel()
        {
            HotelEntidad hotel = new HotelEntidad(0, "", "", false);

            Console.Clear();
            Console.WriteLine("Menú - Solicitar datos del Hotel");
            Console.WriteLine("");
            Console.WriteLine("Ingrese la categoría (estrellas) del hotel:");
            hotel.Estrellas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del hotel:");
            hotel.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la dirección del hotel:");
            hotel.Direccion = Console.ReadLine();
            Console.WriteLine("¿El hotel posee amenities?");
            Console.WriteLine("Escriba SI o cualquier otra combinación para NO");
                string txt = Console.ReadLine();
                if (txt == "SI") { hotel.Amenities = true; }
                else { hotel.Amenities = false; }
            return hotel;
        }
        public static Habitacion SolicitarDatosHabitacion()
        {
            Habitacion habitacion = new Habitacion(0,0, "", false, 10.0);

            Console.Clear();
            Console.WriteLine("Menú - Solicitar datos de la habitación");
            Console.WriteLine("");
            Console.WriteLine("Ingrese id del hotel:");
            habitacion.IdHotel = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de plazas:");
            habitacion.CantidadPlazas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la categoría:");
            habitacion.Categoria = Console.ReadLine();
            Console.WriteLine("¿La habitación es cancelable?");
            Console.WriteLine("Escriba SI o cualquier otra combinación para NO");
                string txt = Console.ReadLine();
                if (txt == "SI") { habitacion.Cancelable = true; }
                else { habitacion.Cancelable = false; }
            Console.WriteLine("Ingrese el precio de la habitación:");
            habitacion.Precio = Double.Parse(Console.ReadLine());
            return habitacion;
        }
    }
}
