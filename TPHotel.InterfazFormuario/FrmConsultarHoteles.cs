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
    public partial class FrmConsultarHoteles : Form
    {
        private HotelNegocio _hotelNegocio;
        public FrmConsultarHoteles()
        {
            InitializeComponent();
            _hotelNegocio = new HotelNegocio();
        }

        private void _btnConsulta_Click(object sender, EventArgs e)
        {
            int numero = 0;

        
            List<Reserva> res = _hotelNegocio.TraerReservas();
            //List<Habitacion> hb = _hotelNegocio.TraerHabitaciones();
            List<HotelEntidad> htl = _hotelNegocio.TraerHoteles();

            List<Habitacion> habitacionesEncontradas = new List<Habitacion>();

            //foreach (Reserva rs in res)
            //{
            //    if(rs.IdHabitacion == )
            //}

            //try
            //{
            //    numero = Validador.pedirInteger(textBox1, label1);

            //    Reserva res = _hotelNegocio.TraerReserva(numero);



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

                //}
            }

        private void FrmConsultarHoteles_Load(object sender, EventArgs e)
        {

        }
    }
}
