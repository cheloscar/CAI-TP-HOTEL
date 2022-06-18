using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPHotel.Negocio;


namespace TPHotel.InterfazFormuario
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Shown(object sender, EventArgs e)
        {
            Program._hotelNegocio = new HotelNegocio();
            FrmPrincipal frm = new FrmPrincipal(this);
            frm.Show();
            this.Hide();
        }
    }
}
