﻿using System;
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
        
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void _btnIngresarConsultarClientes_Click(object sender, EventArgs e)
        {
            
        }

        private void _btnIngresarConsultarReservas_Click(object sender, EventArgs e)
        {
            FrmIngresarReservas frm = new FrmIngresarReservas();
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaClientes frm = new FrmAltaClientes(this);

            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaClientes frm = new FrmConsultaClientes(this);
            frm.Show();
            this.Hide();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresarReservas frm = new FrmIngresarReservas();
            frm.Show();
        }

        private void habitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaHabitaciones frm = new FrmAltaHabitaciones();

            frm.Show();
        }

        private void hotelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaHoteles frm = new FrmAltaHoteles();
            frm.Show();
        }

        private void reservasPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInformes frm = new FrmInformes();
            frm.Show();
        }
    }
}
