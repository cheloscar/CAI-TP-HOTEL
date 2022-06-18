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
        public FrmConsultaReserva(Form padre)
        {
            InitializeComponent();
            this.Owner = padre;
            _hotelNegocio = new HotelNegocio();
        }

        private void _btnBuscarPorIdReserva_Click(object sender, EventArgs e)
        {
            //int numero = 0;

            //try
            //{ 
            //     numero = Validador.pedirInteger(_txtIdReserva, _lblIDReserva);

            //    Reserva res = _hotelNegocio.
            //}


            //////////////////////////////////////////////////
            //int numero = 0;
            //_hotelNegocio = new HotelNegocio();


            //try
            //{


            //    numero = Validador.pedirInteger(_txtIdReserva, _lblIDReserva);


            //    Cliente cli = _hotelNegocio.TraerClientePorNumeroDeReserva(numero);
            //    //cli = new Cliente(cli.ID, cli.FechaAlta, cli.Activo, cli.Nombre, cli.Apellido, cli.Direccion, cli.Telefono, cli.Email, cli.FechaNacimiento);

            //    _txtId.Text = cli.ID.ToString();
            //    _txtFechaAlta.Text = cli.FechaAlta.ToString();
            //    _txtActivo.Text = cli.Activo.ToString();
            //    _txtNombre.Text = cli.Nombre;
            //    _txtApellido.Text = cli.Apellido;
            //    _txtDireccion.Text = cli.Direccion;
            //    _txtTelefono.Text = cli.Telefono;
            //    _txtEmail.Text = cli.Email;
            //    _txtFechaNacimiento.Text = cli.FechaNacimiento.ToString();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("no existe cliente");
            //}

            //Validador.Vaciar(_txtId);

        }

        private void FrmConsultaReserva_Load(object sender, EventArgs e)
        {

        }

        private void FrmConsultaReserva_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Close();
        }
    }
}
