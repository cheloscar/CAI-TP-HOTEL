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
    public partial class FrmAltaHabitacion : Form
    {

        public FrmAltaHabitacion(Form padre)
        {
            InitializeComponent();
            this.Owner = padre;

            CargarListas();
        }

        private void _btnAlta_Click(object sender, EventArgs e)
        {
            List<CombinadoraDeControles> listaCombinadora = new List<CombinadoraDeControles>();

            string resultado = "";
            int idHabitacion = 0;
            int CantidadPlazas = 0;
            string categoria = "";
            double precio = 0;
            bool cancelable;

            
            CombinadoraDeControles txtlb2 = new CombinadoraDeControles(_txtCantidadPlazas, _lblCantidadPlazas);
            CombinadoraDeControles txtlb3 = new CombinadoraDeControles(_txtPrecio, _lblPrecio);
            CombinadoraDeControles txtlb4 = new CombinadoraDeControles(_txtCategoria, _lblCategoria);
            
        
            listaCombinadora.Add(txtlb2);
            listaCombinadora.Add(txtlb3);
            listaCombinadora.Add(txtlb4);


            
            cancelable = Checked(_chkCancelable);
            CantidadPlazas = Validador.pedirInteger(_txtCantidadPlazas, _lblCantidadPlazas);
            precio = Validador.pedirDouble(_txtPrecio, _lblPrecio);

            if ( _txtCantidadPlazas.Text == string.Empty || _txtPrecio.Text == string.Empty || _txtCategoria.Text == string.Empty)

            {
                resultado = Validador.PedirStringLista(listaCombinadora);

                MessageBox.Show(resultado);
            }
            else if (CantidadPlazas == -1)
            {
                MessageBox.Show("Ingrese numero válido de número de plazas");
            }

            else if (precio == -1)
            {
                MessageBox.Show("Ingrese un precio válido");

            }
            else
            {
                try
                {
                    Habitacion habitacion = new Habitacion(idHabitacion, CantidadPlazas, _txtCategoria.Text, cancelable, precio);
                    Program._hotelNegocio.AgregarHabitacion(habitacion);

                    MessageBox.Show("Habitación agregada con éxito");

                    _txtCantidadPlazas.Text = string.Empty;
                    _txtCategoria.Text = string.Empty;
                    _txtPrecio.Text = string.Empty;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
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

        private void CargarListas()
        {
            List<HotelEntidad> listaHoteles = new List<HotelEntidad>();

            listaHoteles = Program._hotelNegocio.TraerHoteles();
            _cmbIdHotel.DataSource = null;

            _cmbIdHotel.DataSource = listaHoteles;
            _cmbIdHotel.DisplayMember = "ComboDisplay";
            _cmbIdHotel.ValueMember = "Id";
        }

        private void FrmAltaHabitaciones_Load(object sender, EventArgs e)
        {
            CargarListas();
        }

        private void FrmAltaHabitaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
