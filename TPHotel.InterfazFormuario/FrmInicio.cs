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
        internal int _contadorActivado = 0;
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Shown(object sender, EventArgs e)
        {
            
            FrmPrincipal frm = new FrmPrincipal(this);
            frm.Show();
            this.Hide();
        }

        private void FrmInicio_Activated(object sender, EventArgs e)
        {
            if (_contadorActivado == 0)
            {
                Program._hotelNegocio = new HotelNegocio();
                _contadorActivado++;
            }
            else { this.Close(); }
        }
    }
}
