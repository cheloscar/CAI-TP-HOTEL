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
    public partial class FrmAltaClientes : Form
    {
        private HotelNegocio _hotelNegocio;
        
        public FrmAltaClientes(Form padre)
        {
            InitializeComponent();
            _hotelNegocio = new HotelNegocio();
            this.Owner = padre;
        }

        private void FormIngresarConsultarClientes_Load(object sender, EventArgs e)
        {
            // LlenarGrilla(dataGridView1);
            //_cmbActivo.Items.Add("SI");
            //_cmbActivo.Items.Add("NO");
            _txtFechaAlta.Enabled = false;
        }

        private void LlenarGrilla(DataGridView grilla)
        {
            List<Cliente> lst = new List<Cliente>();
            lst = _hotelNegocio.TraerClientes();

            grilla.DataSource = lst;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<CombinadoraDeControles> listaCombinadora = new List<CombinadoraDeControles>();
            string resultado = "";
            int numero = 0;
            DateTime fechaAlta;
            DateTime fechaNacimiento = DateTime.Now;
            bool activo;

                CombinadoraDeControles txtlb1 = new CombinadoraDeControles(_txtId, _lblId);
                //CombinadoraDeControles txtlb2 = new CombinadoraDeControles(_txtFechaAlta, _lblFechaAlta);
                //CombinadoraDeControles txtlb3 = new CombinadoraDeControles(_txtActivo, _lblActivo);
                CombinadoraDeControles txtlb4 = new CombinadoraDeControles(_txtNombre, _lblNombre);
                CombinadoraDeControles txtlb5 = new CombinadoraDeControles(_txtApellido, _lblApellido);
                CombinadoraDeControles txtlb6 = new CombinadoraDeControles(_txtDireccion, _lblDireccion);
                CombinadoraDeControles txtlb7 = new CombinadoraDeControles(_txtTelefono, _lblTelefono);
                CombinadoraDeControles txtlb8 = new CombinadoraDeControles(_txtEmail, _lblEmail);
                CombinadoraDeControles txtlb9 = new CombinadoraDeControles(_txtFechaNacimiento, _lblFechaDeNacimiento);

                listaCombinadora.Add(txtlb1);
                //listaCombinadora.Add(txtlb2);
               // listaCombinadora.Add(txtlb3);
                listaCombinadora.Add(txtlb4);
                listaCombinadora.Add(txtlb5);
                listaCombinadora.Add(txtlb6);
                listaCombinadora.Add(txtlb7);
                listaCombinadora.Add(txtlb8);
                listaCombinadora.Add(txtlb9);


          
            numero = Validador.pedirInteger(_txtId, _lblId);
            activo = Checked(_chkActivo);
            fechaAlta = DateTime.Now;
            fechaNacimiento = Validador.pedirFecha(txtlb9.CajaDeTexto.Text);

            //MessageBox.Show(fechaAlta.ToString());


            if (txtlb1.ToString() == string.Empty || txtlb4.ToString() == string.Empty || txtlb5.ToString() == string.Empty || txtlb6.ToString() == string.Empty
                 || txtlb7.ToString() == string.Empty || txtlb8.ToString() == string.Empty || txtlb9.ToString() == string.Empty)
            //|| fechaAlta      
            {

                resultado = Validador.PedirStringLista(listaCombinadora);

                MessageBox.Show(resultado);


            }
            else if (fechaNacimiento.ToString() == "1/1/0001 00:00:00")
            {
                //da de alta cliente abriendo try catch
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


                    _hotelNegocio.AgregarCliente(cli);

                    _txtFechaAlta.Enabled = true;
                    _txtFechaAlta.Text = fechaAlta.ToString();
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    _lblId.BackColor = System.Drawing.Color.White;
                    _lblFechaAlta.BackColor = System.Drawing.Color.White;
                    //_lblActivo.BackColor = System.Drawing.Color.White;
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
    }
}
