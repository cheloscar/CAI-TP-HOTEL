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
    public partial class FormConsultaClientes : Form
    {
        private HotelNegocio _hotelNegocio;
        public FormConsultaClientes()
        {
            InitializeComponent();
        }

        private void _btnBuscarPorIdReserva_Click(object sender, EventArgs e)
        {
            int numero = 0;

            _hotelNegocio = new HotelNegocio();

            try
            {
                numero = Validador.pedirInteger(_txtIdReserva.Text, _lblIDReserva);

                Cliente cli = _hotelNegocio.TraerClientePorNumeroDeReserva(numero);
                //cli = new Cliente(cli.ID, cli.FechaAlta, cli.Activo, cli.Nombre, cli.Apellido, cli.Direccion, cli.Telefono, cli.Email, cli.FechaNacimiento);
                
                _txtId.Text = cli.ID.ToString();
                _txtFechaAlta.Text = cli.FechaAlta.ToString();
                _txtActivo.Text = cli.Activo.ToString();
                _txtNombre.Text = cli.Nombre;
                _txtApellido.Text = cli.Apellido;
                _txtDireccion.Text = cli.Direccion;
                _txtTelefono.Text = cli.Telefono;
                _txtEmail.Text = cli.Email;
                _txtFechaNacimiento.Text = cli.FechaNacimiento.ToString();

                if (cli is null)
                {
                    MessageBox.Show("Cliente inexistente");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("no existe cliente");
            }

            Validador.Vaciar(_txtId);
        }

        private void _btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad no desarrollada aún. Contactar con los desarrolladores");
        }
    }
}
