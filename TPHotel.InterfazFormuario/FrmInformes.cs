using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPHotel.Entidades;
using TPHotel.Negocio;
using TPHotel.InterfazFormuario.Clase_validadora;

namespace TPHotel.InterfazFormuario
{
    public partial class FrmInformes : Form
    {
        private HotelNegocio _hotelnegocio;
        public FrmInformes()
        {
            InitializeComponent();
            _hotelnegocio = new HotelNegocio();
        }


        private void FrmInformes_Load(object sender, EventArgs e)
        {
            CargarListas();
        }


        private void _btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Reserva reserva =(Reserva)_lstReservas.SelectedValue;
           

            Cliente cliente = _hotelnegocio.TraerClientePorNumeroDeReserva(reserva.Id);
            List<HotelEntidad> listaHoteles = new List<HotelEntidad>();
            List<Habitacion> listaHabitaciones = new List<Habitacion>();
            //listaHabitaciones = _hotelnegocio.TraerHabitaciones(reserva.);

            _txtIdReserva.Text = reserva.Id.ToString();
            _txtNombreYApellido.Text = cliente.Nombre + " " + cliente.Apellido;
            _txtFechaIngreso.Text = reserva.FechaIngreso.ToString();
            _txtEgreso.Text = reserva.FechaEgreso.ToString();
            _txtHabitacion.Text = reserva.IdHabitacion.ToString();

        }

        public void CargarListas()
        {
            List<Cliente> listaDeClientes = new List<Cliente>();
            List<HotelEntidad> listaDeHoteles = new List<HotelEntidad>();

            listaDeClientes = _hotelnegocio.TraerClientes();
            listaDeHoteles = _hotelnegocio.TraerHoteles();

            //_cmbClienteID.DataSource = listaClientes;
            //_cmbClienteID.DisplayMember = "ComboDisplay";
            //_cmbClienteID.ValueMember = "ID";
            _cmbClientes.DataSource = null;
            _cmbClientes.DataSource = listaDeClientes;

            _cmbClientes.DisplayMember = "ComboDisplay";
            //_cmbClientes.ValueMember = "ID";

            _cmbHotel.DataSource = null;
            _cmbHotel.DataSource = listaDeHoteles;

            _cmbHotel.DisplayMember = "ComboDisplay";

        }

        private void _cmbClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<Reserva> listadoDeReservas = new List<Reserva>();
            Cliente cliente = (Cliente)_cmbClientes.SelectedValue;
            //int id = cliente.ID;
            listadoDeReservas = _hotelnegocio.TraerReservaPorIdCliente(cliente.ID);

            if (listadoDeReservas.Count == 0)
            {
                MessageBox.Show("El cliente seleccionado no posee reservas");
            }

            else
            { 
            _lstReservas.DataSource = null;
            _lstReservas.DataSource = listadoDeReservas;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void _cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Habitacion> listaHabitaciones = new List<Habitacion>();
            HotelEntidad htl = (HotelEntidad)_cmbHotel.SelectedValue;

            listaHabitaciones = _hotelnegocio.TraerHabitaciones(htl.ID);

            if (listaHabitaciones.Count == 0)
            {
                MessageBox.Show("El hotel no posee habitaciones");
            }

            else
            {
                _lstHabitaciones.DataSource = null;
                _lstHabitaciones.DataSource = listaHabitaciones;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Habitacion habitacionSeleccionado = (Habitacion)_
        }

        private void _cmbHotel_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
    }
}
