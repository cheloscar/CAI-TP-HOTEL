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
    
    public partial class FrmPrincipal : Form
    {
        
        public FrmPrincipal(Form padre)
        {
            InitializeComponent();
            this.Owner = padre;
            
        }

        #region Opciones del menú Tira ALTAS
        private void Cliente_MenuTiraAltas_Click(object sender, EventArgs e)
        {
            FrmAltaCliente frm = new FrmAltaCliente(this);
            frm.Show();
            this.Hide();
        }
        

        private void Reserva_MenuTiraAltas_Click(object sender, EventArgs e)
        {
            FrmAltaReserva frm = new FrmAltaReserva(this);
            frm.Show();
            this.Hide();
        }

        private void Habitacion_MenuTiraAltas_Click(object sender, EventArgs e)
        {
            FrmAltaHabitacion frm = new FrmAltaHabitacion(this);
            frm.Show();
            this.Hide();
        }

        private void Hotel_MenuTiraAltas_Click(object sender, EventArgs e)
        {
            FrmAltaHotel frm = new FrmAltaHotel(this);
            frm.Show();
            this.Hide();
        }
        #endregion

        #region Opciones del menú Tira CONSULTAS
        private void Informes_MenuTiraConsultas_Click(object sender, EventArgs e)
        {
            FrmInformes frm = new FrmInformes(this);
            frm.Show();
            this.Hide();
        }

        private void Hoteles_MenuTiraConsultas_Click(object sender, EventArgs e)
        {
            Proximamente frm = new Proximamente();
            frm.Show();
            this.Hide();
        }

        private void Habitaciones_MenuTiraConsultas_Click(object sender, EventArgs e)
        {
            FrmConsultarHabitaciones frm = new FrmConsultarHabitaciones(this);
            frm.Show();
            this.Hide();
        }
        private void Clientes_MenuTiraConsultas_Click(object sender, EventArgs e)
        {
            FrmConsultaClientes frm = new FrmConsultaClientes(this);
            frm.Show();
            this.Hide();
        }

        #endregion

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
