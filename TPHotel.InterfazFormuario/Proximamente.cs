﻿using System;
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
    public partial class Proximamente : Form
    {
        public Proximamente(Form padre)
        {
            InitializeComponent();
            this.Owner = padre;
        }

        private void CE_Click(object sender, EventArgs e)
        {
           this.Hide();
           Owner.Show();
        }

        private void Proximamente_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
