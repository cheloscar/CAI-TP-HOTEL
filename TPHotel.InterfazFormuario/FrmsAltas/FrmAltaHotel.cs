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
    public partial class FrmAltaHotel : Form
    {
        public FrmAltaHotel(Form padre)
        {
            InitializeComponent();
            this.Owner = padre;
        }

        private void _btnAlta_Click(object sender, EventArgs e)
        {
            List<CombinadoraDeControles> listaCombinadora = new List<CombinadoraDeControles>();
            string resultado = "";
            int numeroEstrellas = 0;
            int numeroID = 0;
            bool amenities;

            CombinadoraDeControles txtlb1 = new CombinadoraDeControles(_txtEstrellas, _lblEstrellas);
            CombinadoraDeControles txtlb2 = new CombinadoraDeControles(_txtNombre, _lblNombre);
            CombinadoraDeControles txtlb3 = new CombinadoraDeControles(_txtDireccion, _lblDireccion);
            CombinadoraDeControles txtlb5 = new CombinadoraDeControles(_txtId, _lblId);

            listaCombinadora.Add(txtlb1);
            listaCombinadora.Add(txtlb2);
            listaCombinadora.Add(txtlb3);
            listaCombinadora.Add(txtlb5);

            numeroEstrellas = Validador.pedirInteger(_txtEstrellas, _lblEstrellas);
            numeroID = Validador.pedirInteger(_txtId, _lblId); //ya no corre, dado que la API lo hace automático.
            amenities = Checked(_chkAmenities);

            if (_txtId.Text == string.Empty || _txtNombre.Text == string.Empty || _txtEstrellas.Text == string.Empty
                || _txtDireccion.Text == string.Empty )
            {
                resultado = Validador.PedirStringLista(listaCombinadora);
                MessageBox.Show(resultado);
            }
            else
            {
                try
                {
                    HotelEntidad hotel = new HotelEntidad(numeroEstrellas,
                        _txtNombre.Text, _txtDireccion.Text, amenities);
                    Program._hotelNegocio.AgregarHotel(hotel);

                    MessageBox.Show("Hotel agregado exitosamente");
                    
                    _txtNombre.Text = string.Empty;
                    _txtId.Text = string.Empty;
                    _txtDireccion.Text = string.Empty;
                    _txtEstrellas.Text = string.Empty;
                    
                    _lblAmenities.BackColor = System.Drawing.Color.Transparent;
                    _lblDireccion.BackColor = System.Drawing.Color.Transparent;
                    _lblEstrellas.BackColor = System.Drawing.Color.Transparent;
                    _lblId.BackColor = System.Drawing.Color.Transparent;
                    _lblNombre.BackColor = System.Drawing.Color.Transparent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }
        }

        private void FrmHoteles_Load(object sender, EventArgs e)
        {
            _txtId.Enabled = false;
            _txtId.Text = "Automático";
        }
        private bool Checked(CheckBox chk)
        {

            bool resultado;
            if (chk.Checked == true)
            {
                resultado = true;
            }

            else
            {
                resultado = false;
            }

            return resultado;
        }

        private void FrmAltaHoteles_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
