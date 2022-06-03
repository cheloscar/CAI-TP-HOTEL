using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPHotel.AccesoDatos;
using TPHotel.Entidades;

namespace TPHotel.Negocio
{
    public class HotelNegocio
    {
        //Variables privadas de la clase
        private HotelDatos _hotelDatos;
        private ClienteDatos _clienteDatos;
        private ReservaDatos _reservaDatos;
        private HabitacionDatos _habitacionDatos;
        
        //Consturctor de la clase Hotel Negocio
        public HotelNegocio()
        {
            _hotelDatos = new HotelDatos();
            _clienteDatos = new ClienteDatos();
            _reservaDatos = new ReservaDatos();
            _habitacionDatos = new HabitacionDatos();
        }

        #region Métodos para listar totales
        public List<HotelEntidad> TraerHoteles()
        {
            List <HotelEntidad> lst= _hotelDatos.TraerHoteles();

            return lst;
        }
        public List<Cliente> TraerClientes()
        {
            List<Cliente> lst = _clienteDatos.TraerTodosLosClientes();

            return lst;
        }
        public List<Reserva> TraerReservas()
        {
            List<Reserva> reservas = _reservaDatos.TraerReservas();
            return reservas;
        }
        public List<Habitacion> TraerHabitaciones(int hotel)
        {
            List<Habitacion> lst = new List<Habitacion>();
            lst = _habitacionDatos.TraerTodasPorHotel(hotel);
            return lst;
        }
        #endregion

        #region Métodos para traer datos puntuales
        public Cliente TraerCliente(int idCliente)
        {
            Cliente cliente = _clienteDatos.TraerClientePorID(idCliente);
            return cliente;
        }
        public Reserva TraerReserva(int idReserva)
        {
            Reserva reserva = _reservaDatos.TraerReservaPorNumeroDeReserva(idReserva);

            return reserva;
        }
        public Cliente TraerClientePorNumeroDeReserva(int idReserva)
        {
            Reserva reserva = TraerReserva(idReserva);
            Cliente cliente = TraerCliente(reserva.IdCliente);

            return cliente;

        }
        #endregion

        #region Métodos para la carga de datos
        public void AgregarCliente(Cliente cliente)
        { 
            _clienteDatos.Insertar(cliente);
        }

        #endregion
    }
}
