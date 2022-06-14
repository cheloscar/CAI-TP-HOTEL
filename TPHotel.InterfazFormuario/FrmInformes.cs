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

            _txtIdReserva.Text = reserva.Id.ToString();
            _txtNombreYApellido.Text = cliente.Nombre + " " + cliente.Apellido;
            _txtFechaIngreso.Text = reserva.FechaIngreso.ToString();
            _txtEgreso.Text = reserva.FechaEgreso.ToString();

        }

        public void CargarListas()
        {
            List<Cliente> listaDeClientes = new List<Cliente>();

            listaDeClientes = _hotelnegocio.TraerClientes();

            //_cmbClienteID.DataSource = listaClientes;
            //_cmbClienteID.DisplayMember = "ComboDisplay";
            //_cmbClienteID.ValueMember = "ID";
            _cmbClientes.DataSource = null;
            _cmbClientes.DataSource = listaDeClientes;

            _cmbClientes.DisplayMember = "ComboDisplay";
            //_cmbClientes.ValueMember = "ID";

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
    }
}
