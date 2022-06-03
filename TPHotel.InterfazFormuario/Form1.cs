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
            FormIngresarConsultarClientes frm = new FormIngresarConsultarClientes();

            frm.Show();
        }

        private void _btnIngresarConsultarReservas_Click(object sender, EventArgs e)
        {
            FormIngresarConsultarReservas frm = new FormIngresarConsultarReservas();
            frm.Show();
        }
    }
}
