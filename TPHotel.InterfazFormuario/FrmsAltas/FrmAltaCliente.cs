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
    public partial class FrmAltaCliente : Form
    {
        
        public FrmAltaCliente(Form padre)
        {
            InitializeComponent();
            this.Owner = padre;
        }

        private void FormIngresarConsultarClientes_Load(object sender, EventArgs e)
        {
            _txtFechaAlta.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<CombinadoraDeControles> listaCombinadora = new List<CombinadoraDeControles>();
            string resultado = "";
            int numero = 0;
            DateTime fechaAlta;
            DateTime fechaNacimiento = DateTime.Now;
            bool activo;


                CombinadoraDeControles txtlb4 = new CombinadoraDeControles(_txtNombre, _lblNombre);
                CombinadoraDeControles txtlb5 = new CombinadoraDeControles(_txtApellido, _lblApellido);
                CombinadoraDeControles txtlb6 = new CombinadoraDeControles(_txtDireccion, _lblDireccion);
                CombinadoraDeControles txtlb7 = new CombinadoraDeControles(_txtTelefono, _lblTelefono);
                CombinadoraDeControles txtlb8 = new CombinadoraDeControles(_txtEmail, _lblEmail);
                CombinadoraDeControles txtlb9 = new CombinadoraDeControles(_txtFechaNacimiento, _lblFechaDeNacimiento);

                listaCombinadora.Add(txtlb4);
                listaCombinadora.Add(txtlb5);
                listaCombinadora.Add(txtlb6);
                listaCombinadora.Add(txtlb7);
                listaCombinadora.Add(txtlb8);
                listaCombinadora.Add(txtlb9);


          
            activo = Checked(_chkActivo);
            fechaAlta = DateTime.Now;
            fechaNacimiento = Validador.pedirFecha(txtlb9.CajaDeTexto.Text);

            //MessageBox.Show(fechaAlta.ToString());


            if (txtlb4.ToString() == string.Empty || txtlb5.ToString() == string.Empty || txtlb6.ToString() == string.Empty
                 || txtlb7.ToString() == string.Empty || txtlb8.ToString() == string.Empty || txtlb9.ToString() == string.Empty)
                 
            {

                resultado = Validador.PedirStringLista(listaCombinadora);

                MessageBox.Show(resultado);


            }
            else if (fechaNacimiento.ToString() == "1/1/0001 00:00:00")
            {
                MessageBox.Show("Ingrese fecha válida");
                _txtFechaNacimiento.Text = string.Empty;
            }

            else
            {
                try
                {


                    Cliente cli = new Cliente(numero, DateTime.Now, activo,
                    _txtNombre.Text.ToString(), _txtApellido.Text.ToString(), _txtDireccion.Text.ToString(), _txtTelefono.Text.ToString(),
                    _txtEmail.Text.ToString(), DateTime.Now);


                    Program._hotelNegocio.AgregarCliente(cli);

                    _txtFechaAlta.Enabled = true;
                    _txtFechaAlta.Text = fechaAlta.ToString();

                    MessageBox.Show("Cliente agregado exitosamente");
                    
                    _txtNombre.Text = string.Empty;
                    _txtApellido.Text = string.Empty;
                    _txtDireccion.Text = string.Empty;
                    _txtTelefono.Text = string.Empty;
                    _txtEmail.Text = string.Empty;
                    _txtFechaNacimiento.Text = string.Empty;
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    _lblFechaAlta.BackColor = System.Drawing.Color.White;
                    _lblNombre.BackColor = System.Drawing.Color.White;
                    _lblApellido.BackColor = System.Drawing.Color.White;
                    _lblEmail.BackColor = System.Drawing.Color.White;

                }

                finally
                {
                    //_txtId.Text = string.Empty

                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool Checked(CheckBox chk)
        {
           
            bool resultado;
            if(chk.Checked == true)
            {
               resultado = true;
            }
            
            else
            { 
            resultado = false;
            }

            return resultado;
        }

        private void _txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void _txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void _txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void _txtFechaNacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void _txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void _txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void _txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAltaClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
