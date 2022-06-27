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
             _txtIdHabitacion.Enabled = false;
            _txtHabNmbr.Enabled = false;
            _txtEstrellas.Enabled = false;

            button1.Enabled = false;
        }

        private void _cmbHotel_SelectionChangeCommitted(object sender, EventArgs e)
        {
            List<Habitacion> listaHabitaciones = new List<Habitacion>();
            HotelEntidad htl = (HotelEntidad)_cmbHotel.SelectedValue;

            listaHabitaciones = Program._hotelNegocio.TraerHabitaciones(htl.ID);

            if (listaHabitaciones.Count == 0)
            {
                MessageBox.Show("El hotel no posee habitaciones");
                _lstHabitaciones.DataSource = null;
                _lstHabitaciones.Items.Clear();

                _txtIdHabitacion.Text = string.Empty;
                _txtHabNmbr.Text = string.Empty;
                _txtEstrellas.Text = string.Empty;

                _txtIdHabitacion.Enabled = false;
                _txtHabNmbr.Enabled = false;
                _txtEstrellas.Enabled = false;

                button1.Enabled = false;
            }

            else
            {
                _lstHabitaciones.DataSource = null;
                _lstHabitaciones.DataSource = listaHabitaciones;
                
                _txtIdHabitacion.Enabled = true;
                _txtHabNmbr.Enabled = true;
                _txtEstrellas.Enabled = true;
                button1.Enabled = true;
            }


        }

        private void FrmConsultarHoteles_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
        public void CargarListas()
        {
            _cmbHotel.DataSource = null;
            _cmbHotel.DataSource = Program._hotelNegocio.TraerHoteles();

            _cmbHotel.DisplayMember = "ComboDisplay";
        }
        
          private void button1_Click(object sender, EventArgs e)
        {

            Habitacion habitacionSeleccionada = (Habitacion)_lstHabitaciones.SelectedValue;
            _txtIdHabitacion.Text = habitacionSeleccionada.IdHabitacion.ToString();
            _txtHabNmbr.Text = habitacionSeleccionada.Categoria;
            _txtEstrellas.Text = habitacionSeleccionada.Precio.ToString();
        }
    }
}
