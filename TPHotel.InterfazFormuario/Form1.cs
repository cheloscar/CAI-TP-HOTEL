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
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void _btnIngresarConsultarClientes_Click(object sender, EventArgs e)
        {
            
        }

        private void _btnIngresarConsultarReservas_Click(object sender, EventArgs e)
        {
            FormIngresarConsultarReservas frm = new FormIngresarConsultarReservas();
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIngresarAltaClientes frm = new FormIngresarAltaClientes();

            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConsultaClientes frm = new FormConsultaClientes();
            frm.Show();
        }
    }
}
