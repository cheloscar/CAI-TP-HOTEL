using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPHotel.Entidades;
using TPHotel.Negocio;

namespace TPHotel.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HotelNegocio _hotel = new HotelNegocio();
            List<Reserva> _reservaList = new List<Reserva>();
            List<Cliente> _clienteList = new List<Cliente>();
            List<HotelEntidad> _hotelList = new List<HotelEntidad>();
            List<Habitacion> _habitacionList = new List<Habitacion>();
            bool _continuar = true;
            int _opcionMenu;

            Menu.MenuBienvenida();

            do
            {
                Menu.MenuPrincipal();
                _opcionMenu = Int32.Parse(Console.ReadLine());

                if (_opcionMenu == 1)
                {
                    _reservaList = _hotel.TraerReservas();
                    foreach (Reserva reserva in _reservaList)
                    {
                        Console.WriteLine(reserva.ToString());
                    }
                    Menu.Pausa();
                }
                else if (_opcionMenu == 2)
                {
                    _clienteList = _hotel.TraerClientes();
                    foreach (Cliente cliente in _clienteList)
                    {
                        Console.WriteLine(cliente.ToString());
                    }
                    Menu.Pausa();
                }
                else if (_opcionMenu == 3)
                {
                    _hotelList = _hotel.TraerHoteles();
                    foreach (HotelEntidad hotel in _hotelList)
                    {
                        Console.WriteLine(hotel.ToString());
                    }
                    Menu.Pausa();
                }
                else if (_opcionMenu == 4)
                {
                    //Las habitaciones están asociadas a un hotel, hay que especificar el hotel
                    _habitacionList = _hotel.TraerHabitaciones(1);
                    foreach (Habitacion habitacion in _habitacionList)
                    {
                        Console.WriteLine(habitacion.ToString());
                    }
                    Menu.Pausa();
                }
                else if (_opcionMenu == 5)
                {
                    
                    _hotel.AgregarCliente(Interacciones.SolicitarDatosCliente());
                }
                else
                {
                    Menu.Salir();
                    _continuar = false; 
                }
            } while (_continuar);

            
            
            /*

            Console.WriteLine("Ingrese número de reserva");
            int id = Convert.ToInt32(Console.ReadLine());


            Cliente cli = _hotel.TraerClientePorNumeroDeReserva(id);

            Console.WriteLine(cli.ToString());
            */

        }
    }
}
