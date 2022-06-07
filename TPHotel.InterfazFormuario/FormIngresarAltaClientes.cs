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
    public partial class FormIngresarAltaClientes : Form
    {
        private HotelNegocio _hotelNegocio;
        public FormIngresarAltaClientes()
        {
            InitializeComponent();
            _hotelNegocio = new HotelNegocio();
        }

        private void FormIngresarConsultarClientes_Load(object sender, EventArgs e)
        {
           // LlenarGrilla(dataGridView1);
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
 
            try
            {
                CombinadoraDeControles txtlb1 = new CombinadoraDeControles(_txtId, _lblId);
                CombinadoraDeControles txtlb2 = new CombinadoraDeControles(_txtFechaAlta, _lblFechaAlta);
                CombinadoraDeControles txtlb3 = new CombinadoraDeControles(_txtActivo, _lblActivo);
                CombinadoraDeControles txtlb4 = new CombinadoraDeControles(_txtNombre, _lblNombre);
                CombinadoraDeControles txtlb5 = new CombinadoraDeControles(_txtApellido, _lblApellido);
                CombinadoraDeControles txtlb6 = new CombinadoraDeControles(_txtDireccion, _lblDireccion);
                CombinadoraDeControles txtlb7 = new CombinadoraDeControles(_txtTelefono, _lblTelefono);
                CombinadoraDeControles txtlb8 = new CombinadoraDeControles(_txtEmail, _lblEmail);
                CombinadoraDeControles txtlb9 = new CombinadoraDeControles(_txtFechaNacimiento, _lblFechaDeNacimiento);

                listaCombinadora.Add(txtlb1);
                listaCombinadora.Add(txtlb2);
                listaCombinadora.Add(txtlb3);
                listaCombinadora.Add(txtlb4);
                listaCombinadora.Add(txtlb5);
                listaCombinadora.Add(txtlb6);
                listaCombinadora.Add(txtlb7);
                listaCombinadora.Add(txtlb8);
                listaCombinadora.Add(txtlb9);

                if (txtlb1.ToString() == string.Empty || txtlb2.ToString() == string.Empty || txtlb3.ToString() == string.Empty
                 || txtlb4.ToString() == string.Empty || txtlb5.ToString() == string.Empty || txtlb6.ToString() == string.Empty
                 || txtlb7.ToString() == string.Empty || txtlb8.ToString() == string.Empty || txtlb9.ToString() == string.Empty)

                { 
                 resultado = Validador.PedirStringLista(listaCombinadora);
                    _txtId.Text = (Validador.pedirInteger(_txtId.Text, _lblId)).ToString();
                    if ((_txtId.Text = Validador.pedirInteger(_txtId.Text, _lblId).ToString()) == "0")
                    {
                        Validador.Vaciar(_txtId);
                    }
                    _txtActivo.Text = (Validador.pedirBool(_txtActivo.Text, _lblActivo)).ToString();
                }
                Cliente cli = new Cliente(Convert.ToInt32(_txtId.Text), DateTime.Now, Convert.ToBoolean(_txtActivo.Text),
            _txtNombre.Text.ToString(), _txtApellido.Text.ToString(), _txtDireccion.Text.ToString(), _txtTelefono.Text.ToString(),
            _txtEmail.Text.ToString(), DateTime.Now);

                //MessageBox.Show(cli.ID + cli.Direccion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(resultado + " " + "\n" + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
