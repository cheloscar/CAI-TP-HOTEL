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
        private List<HotelEntidad> _hoteles = new List<HotelEntidad>();
        private List<Cliente> _clientes = new List<Cliente>();
        private List<Reserva> _reservas = new List<Reserva>();
        private List<Habitacion> _habitaciones = new List<Habitacion>();
        
        //Consturctor de la clase Hotel Negocio
        public HotelNegocio()
        {
            _hotelDatos = new HotelDatos();
            _clienteDatos = new ClienteDatos();
            _reservaDatos = new ReservaDatos();
            _habitacionDatos = new HabitacionDatos();

            //Carga de datos
            _hoteles = CargarHoteles();
            _clientes = CargarClientes();
            _reservas = CargarReservas();
            _habitaciones = CargarHabitaciones();
        }

        #region Métodos para listar totales
        public List<HotelEntidad> TraerHoteles()
        {
            return this._hoteles;
        }
        public List<Cliente> TraerClientes()
        {
            return this._clientes;
        }
        public List<Reserva> TraerReservas()
        {
            return this._reservas;
        }
        public List<Habitacion> TraerHabitaciones(int idHotel)
        {
            List<Habitacion> lst = new List<Habitacion> ();
            foreach(Habitacion habitacion in _habitaciones)
            {
                if(habitacion.IdHotel == idHotel) { lst.Add(habitacion); }
            }
            return lst;
        }
        #endregion

        #region Métodos para traer datos puntuales
        public Cliente TraerCliente(int idCliente)
        {
            Cliente cliente = null;

            foreach (Cliente cl in _clientes)
            {
                if (cl.ID == idCliente)

                {
                    cliente = cl;
                    return cliente;
                }
                else if (cl == null)
                {
                    throw new IdNoPositivoExcepcion();
                }
            }
            //Cliente cliente = _clienteDatos.TraerClientePorID(idCliente);
            return cliente;
        }
        public Reserva TraerReserva(int idReserva)
        {
            Reserva _reserva = null;

            foreach (Reserva reserva in _reservas)
            {
                if(reserva.Id == idReserva)
                { 
                    _reserva = reserva;
                    return _reserva;
                }
            }

            if (_reserva == null)
                throw new ReservaInexistenteExcepcion();

            return _reserva;
        }

        public List<Reserva> TraerReservaPorIdCliente(int idcliente)
        {
            List<Reserva> reservaList = new List<Reserva>();
            foreach (Reserva rs in _reservas)
            {
                if (rs.IdCliente == idcliente)
                {
                    reservaList.Add(rs);
                }
            }
            return reservaList;
        }
        public Cliente TraerClientePorNumeroDeReserva(int idReserva)
        {
            Reserva reserva = TraerReserva(idReserva);
            Cliente cliente = TraerCliente(reserva.IdCliente);

            if (reserva == null || cliente == null)
            {
                throw new ReservaInexistenteExcepcion();
            }

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
            _clientes = CargarClientes();
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
                _hoteles = CargarHoteles();
            }
        }
        public void AgregarHabitacion(Habitacion habitacion)
        {
            EvaluarTransactionResult(_habitacionDatos.Insertar(habitacion));
            _habitaciones = CargarHabitaciones();
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
                _reservas = CargarReservas();
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
        internal List<HotelEntidad> CargarHoteles()
        {
            List<HotelEntidad> lst = _hotelDatos.TraerHoteles();

            return lst;
        }
        internal List<Cliente> CargarClientes()
        {
            List<Cliente> lst = _clienteDatos.TraerTodosLosClientes();

            return lst;
        }
        internal List<Reserva> CargarReservas()
        {
            List<Reserva> lst = _reservaDatos.TraerReservas();
            return lst;
        }
        internal List<Habitacion> CargarHabitaciones()
        {
            List<Habitacion> lst = new List<Habitacion>();
            foreach(HotelEntidad hotel in _hoteles)
            {
                lst.AddRange(BuscarHabitaciones(hotel.ID));
            }
            return lst;
        }
        internal List<Habitacion> BuscarHabitaciones(int hotel)
        {
            List<Habitacion> lst = new List<Habitacion>();
            lst = _habitacionDatos.TraerTodasPorHotel(hotel);
            return lst;
        }
        #endregion
    }
}
