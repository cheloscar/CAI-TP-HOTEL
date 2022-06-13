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
    public partial class FrmConsultaReserva : Form
    {
        private HotelNegocio _hotelNegocio;
        public FrmConsultaReserva()
        {
            InitializeComponent();
            _hotelNegocio = new HotelNegocio();
        }

        private void _btnBuscarPorIdReserva_Click(object sender, EventArgs e)
        {
            //int numero = 0;
            //try
            //{
            //    //numero = Validador.pedirInteger()
            //}

        }
    }
}
