using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPHotel.InterfazFormuario
{
    public partial class FrmDeseaAgregarClienteNuevo : Form
    {
        public FrmDeseaAgregarClienteNuevo()
        {
            InitializeComponent();
        }

        private void _btnSI_Click(object sender, EventArgs e)
        {
            FrmAltaClientes frm = new FrmAltaClientes(this);
            frm.Show();
            
        }

        private void FrmDeseaAgregarClienteNuevo_Load(object sender, EventArgs e)
        {

        }
    }
}
