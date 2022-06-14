using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPHotel.AccesoDatos;
using TPHotel.Entidades;
using TPHotel.Entidades.Excepciones;


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
            Cliente cliente = null;
            

            List<Cliente> listadoDeCliente = new List<Cliente>();

            listadoDeCliente = TraerClientes();

            foreach (Cliente cl in listadoDeCliente)
            {
                if (cl.ID == idCliente)

                {
                    cliente = cl;
                }
                else if (cl == null)
                {
                    throw new IdInexistenteException();
                }
            }
            //Cliente cliente = _clienteDatos.TraerClientePorID(idCliente);
            return cliente;
        }
        public Reserva TraerReserva(int idReserva)
        {
            Reserva reserva = _reservaDatos.TraerReservaPorNumeroDeReserva(idReserva);

            return reserva;
        }

        public List<Reserva> TraerReservaPorIdCliente(int idcliente)
        {
            List<Reserva> listadoReservas = TraerReservas();
            List<Reserva> listaReservasEncontradas = new List<Reserva>();

            foreach (Reserva rs in listadoReservas)
            {
                if (rs.IdCliente == idcliente)
                {
                    listaReservasEncontradas.Add(rs);
                }
            }
            return listaReservasEncontradas;
        }
        public Cliente TraerClientePorNumeroDeReserva(int idReserva)
        {
            Reserva reserva = TraerReserva(idReserva);
            Cliente cliente = TraerCliente(reserva.IdCliente);

            return cliente;

        }

        //public Habitacion TraerHabitacionPorIDHabitacion(int idhabitacion)
        //{
        //    List<>
        //}
        #endregion

        #region Métodos para la carga de datos
        public void AgregarCliente(Cliente cliente)
        {
            EvaluarTransactionResult(_clienteDatos.Insertar(cliente));
        }
        public void AgregarHotel(HotelEntidad hotel)
        {
            if (hotel.Estrellas < 0 || hotel.Estrellas > 5)
            {
                throw new EstrellasFueraDeRangoExcepcion();
            }
            else
            {
                EvaluarTransactionResult(_hotelDatos.Insertar(hotel));
            }
        }
        public void AgregarHabitacion(Habitacion habitacion)
        {
            EvaluarTransactionResult(_habitacionDatos.Insertar(habitacion));
        }
        public void AgregarReserva(Reserva reserva)
        {
            if (reserva.CantidadHuespedes < 0 || reserva.CantidadHuespedes > 5)
            {
                throw new CantidadDeHuespedesMayorAlLaPermitidaException();
            }

            else

            { 
                EvaluarTransactionResult(_reservaDatos.Insertar(reserva));
            }
        }

        #endregion

        #region MétodosDeApoyo
        private void EvaluarTransactionResult(TransactionResult tr)
        {
            if (tr.IsOk)
            {
                //Transacción Correcta
            }
            else
            {
                throw new ErrorEnTransaccionExcepcion(tr.Error);
            }
        }

        #endregion
    }
}
