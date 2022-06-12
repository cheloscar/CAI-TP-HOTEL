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
            Cliente cliente = null;
            //Por problemas con la API se debe hacer esto.

            List<Cliente> listadoDeCliente = new List<Cliente>();

            listadoDeCliente = TraerClientes();

            foreach (Cliente cl in listadoDeCliente)
            {
                if (cl.ID == idCliente)

                {
                    cliente = cl;
                    break;
                }
                else if (cl == null)
                {
                    throw new Exception("Cliente inexistente");
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
            if (cliente.ID <= 0)
            {
                throw new Exception("El id no puede ser menor o igual que cero o contener cadenas de texto");
                //Puede ser una exception personalizada de "idInválidoException"
            }

            else
            { 
            _clienteDatos.Insertar(cliente);
                //Incluir TransactionResultException

            }

        }

        public void AgregarHotel(HotelEntidad hotel)
        {
            if (hotel.Estrellas < 0 || hotel.Estrellas > 5)
            {
                throw new Exception("Debe ser entre 1 y 5 estrellas"); //personalizar exception
            }
            else if (hotel.ID <= 0)
            {
                throw new Exception("El id no puede ser menor o igual que cero o contener cadenas de texto"); //personalizar exception
                //Puede ser una exception personalizada de "idInválidoException"            
            }

            else
            {
                //_desarrollar agregar hotel.
                //Incluir TransactionResultException
            }
        }

        public void AgregarHabitacion(Habitacion habitacion)
        {
            if (habitacion.IdHabitacion <= 0)
            {
                throw new Exception("El id no puede ser menor o igual que cero o contener cadenas de texto"); //personalizar exception
                //Puede ser una exception personalizada de "idInválidoException"
            }

            else
            {
                //_desarrollar agregar habitacion.
                //Incluir TransactionResultException
            }
        }

        public void AgregarReserva(Reserva reserva)
        {
            if (reserva.Id <= 0)
            {
                throw new Exception("El id no puede ser menor o igual que cero o contener cadenas de texto");
                //Puede ser una exception personalizada de "idInválidoException"
            }
            else
            {
                //desarrollar agregar Reserva
                //Incluir TransactionResultException
            }
        }

        #endregion
    }
}
