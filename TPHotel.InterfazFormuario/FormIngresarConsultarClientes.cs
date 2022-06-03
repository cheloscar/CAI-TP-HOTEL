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

namespace TPHotel.InterfazFormuario
{
    public partial class FormIngresarConsultarClientes : Form
    {
        private HotelNegocio _hotelNegocio;
        public FormIngresarConsultarClientes()
        {
            InitializeComponent();
            _hotelNegocio = new HotelNegocio();
        }

        private void FormIngresarConsultarClientes_Load(object sender, EventArgs e)
        {
            LlenarGrilla(dataGridView1);
        }

        private void LlenarGrilla(DataGridView grilla)
        {
            List<Cliente> lst = new List<Cliente>();
            lst = _hotelNegocio.TraerClientes();

            grilla.DataSource = lst;

        }
    }
}
