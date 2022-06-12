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
    public partial class FrmIngresarReservas : Form
    {
        private HotelNegocio _hotelNegocio;
        public FrmIngresarReservas()
        {
            InitializeComponent();
            _hotelNegocio = new HotelNegocio();
        }

        private void FrmIngresarConsultarReservas_Load(object sender, EventArgs e)
        {
            CargarListas();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CombinadoraDeControles txtlb1 = new CombinadoraDeControles(_txtCantidadDeHuespedes, _lblCantidadHuespedes);
            CombinadoraDeControles txtlb2 = new CombinadoraDeControles(_txtFechaIngreso, _lblFechaIngreso);
            CombinadoraDeControles txtlb3 = new CombinadoraDeControles(_txtFechaEgreso, _lblFechaIngreso);
            CombinadoraDeControles txtlb4 = new CombinadoraDeControles(_txtId, _lblIdReserva);


        }

        private void CargarListas()
        {
            List<HotelEntidad> listaHoteles = new List<HotelEntidad>();

            listaHoteles = _hotelNegocio.TraerHoteles();
            _cmbNombreHoteles.DataSource = null;
            
            _cmbNombreHoteles.DataSource = listaHoteles;
            _cmbNombreHoteles.DisplayMember = "ComboDisplay";
            _cmbNombreHoteles.ValueMember = "Nombre";

            List<Cliente> listaClientes = new List<Cliente>();
            listaClientes = _hotelNegocio.TraerClientes();
            _cmbClientesPorId.DataSource = listaClientes;
            _cmbClientesPorId.DisplayMember = "ComboDisplay";
            _cmbClientesPorId.ValueMember = "ID";

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void _cmbClientesPorId_SelectedIndexChanged(object sender, EventArgs e)
        {

            


            // MessageBox.Show("pasó");
        }

        private void _cmbClientesPorId_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Cliente cliente = _hotelNegocio.TraerCliente(Convert.ToInt32(_cmbClientesPorId.SelectedValue));

            _txtIdCliente.Text = cliente.ID.ToString();
            _txtNombre.Text = cliente.Nombre;
            _txtApellido.Text = cliente.Apellido;
            //object algo = _cmbClientesPorId.SelectedValue;

            //MessageBox.Show(algo.ToString());
            //Cliente cliente = _hotelNegocio.TraerCliente(Convert.ToInt32(_cmbClientesPorId.SelectedValue));

            //_txtIdCliente.Text = cliente.ID.ToString();
            //_txtNombre.Text = cliente.Nombre;
            //_txtApellido.Text = cliente.Apellido;
        }
    }
}
