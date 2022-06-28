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
using TPHotel.Entidades.Excepciones;
using TPHotel.Negocio;
using TPHotel.InterfazFormuario.Clase_validadora;

namespace TPHotel.InterfazFormuario
{
    public partial class FrmConsultaClientes : Form
    {
        public FrmConsultaClientes(Form padre)
        {
            InitializeComponent();
            this.Owner = padre;
           
        }

        private void _btnBuscarPorIdReserva_Click(object sender, EventArgs e)
        {
                        int numero = 0;
            numero = Validador.pedirInteger(_txtIdReserva, _lblIDReserva);

            if (numero <= -1)
            {
                MessageBox.Show("Ingrese número válido");
                _txtIdReserva.Text = string.Empty;
            }

            else
            {
                try



                {


                    Cliente cli = Program._hotelNegocio.TraerClientePorNumeroDeReserva(numero);

                    _txtId.Text = cli.ID.ToString();
                    _txtFechaAlta.Text = cli.FechaAlta.ToString();
                    _txtActivo.Text = cli.Activo.ToString();
                    _txtNombre.Text = cli.Nombre;
                    _txtApellido.Text = cli.Apellido;
                    _txtDireccion.Text = cli.Direccion;
                    _txtTelefono.Text = cli.Telefono;
                    _txtEmail.Text = cli.Email;
                    _txtFechaNacimiento.Text = cli.FechaNacimiento.ToString();



                }


                catch (Exception ex)
                {
                    MessageBox.Show("NO EXISTE DICHA RESERVA \n \n Mensaje original " + ex.ToString());
                }

                finally
                {
                    Validador.Vaciar(_txtIdReserva);
                }
            }
        }

        private void _btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad no desarrollada aún. Contactar con los desarrolladores");
        }

        private void FrmConsultaClientes_Load(object sender, EventArgs e)
        {

        }

        private void FrmConsultaClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
