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
    public partial class FrmConsultarHabitaciones : Form
    {
        public FrmConsultarHabitaciones(Form padre)
        {
            InitializeComponent();
            this.Owner = padre;
        }
        private void FrmConsultarHoteles_Load(object sender, EventArgs e)
        {
            CargarListas();
        }

        private void _cmbHotel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<Habitacion> listaHabitaciones = new List<Habitacion>();
            HotelEntidad htl = (HotelEntidad)_cmbHotel.SelectedValue;

            listaHabitaciones = Program._hotelNegocio.TraerHabitaciones(htl.ID);

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

        private void FrmConsultarHoteles_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
        public void CargarListas()
        {
            //List<Cliente> listaDeClientes = new List<Cliente>();
            //List<HotelEntidad> listaDeHoteles = new List<HotelEntidad>();

            //listaDeClientes = _hotelnegocio.TraerClientes();
            //listaDeHoteles = _hotelnegocio.TraerHoteles();

            //_cmbClienteID.DataSource = listaClientes;
            //_cmbClienteID.DisplayMember = "ComboDisplay";
            //_cmbClienteID.ValueMember = "ID";

            //_cmbClientes.ValueMember = "ID";

            _cmbHotel.DataSource = null;
            _cmbHotel.DataSource = Program._hotelNegocio.TraerHoteles();

            _cmbHotel.DisplayMember = "ComboDisplay";

        }
    }
}
