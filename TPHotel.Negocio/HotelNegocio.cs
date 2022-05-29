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
        private HotelDatos _hotelDatos;
        private ClienteDatos _clienteDatos;
        private ReservaDatos _reservaDatos;
        
        public HotelNegocio()
        {
            _hotelDatos = new HotelDatos();
            _clienteDatos = new ClienteDatos();
            _reservaDatos = new ReservaDatos();
        }

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
        public Cliente TraerCliente(int idCliente)
        {
            Cliente cliente = _clienteDatos.TraerClientePorID(idCliente);
            return cliente;
        }

        public List<Reserva> TraerReservas()
        {
            List<Reserva> reservas = _reservaDatos.TraerReservas();
            return reservas;
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
    }
}
