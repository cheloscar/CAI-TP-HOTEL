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
    public partial class FrmAltaReserva : Form
    {
        private Cliente _cliente;
        public FrmAltaReserva(Form padre)
        {
            InitializeComponent();
            this.Owner = padre;
        }


        private void FrmIngresarConsultarReservas_Load(object sender, EventArgs e)
        {
            CargarListas();
            
             _txtIdHabitacion.Text = string.Empty;
             _txtCantidaPlazas.Text = string.Empty;
             _txtPrecio.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<CombinadoraDeControles> listaCombinadora = new List<CombinadoraDeControles>();
            string resultado = "";
            DateTime fechaEgreso;
            DateTime fechaIngreso;
            int cantidadDeHuespedes = 0;
            Habitacion habitacion = (Habitacion)_lstHabitaciones.SelectedItem;
            HotelEntidad hotel = (HotelEntidad)_lstHoteles.SelectedItem;
            Cliente cliente = (Cliente)_lstClientes.SelectedItem;

            CombinadoraDeControles txtlb1 = new CombinadoraDeControles(_txtCantidadDeHuespedes, _lblCantidadHuespedes);
            CombinadoraDeControles txtlb2 = new CombinadoraDeControles(_txtFechaIngreso, _lblFechaIngreso);
            CombinadoraDeControles txtlb3 = new CombinadoraDeControles(_txtFechaEgreso, _lblFechaEgreso);

            listaCombinadora.Add(txtlb1);
            listaCombinadora.Add(txtlb2);
            listaCombinadora.Add(txtlb3);

            fechaEgreso = Validador.pedirFecha(_txtFechaEgreso.Text);
            fechaIngreso = Validador.pedirFecha(_txtFechaIngreso.Text);
            //Agregado 25/06/22
            cantidadDeHuespedes = Validador.pedirInteger(_txtCantidadDeHuespedes,_lblCantidadHuespedes);


            if (_txtCantidadDeHuespedes.Text == string.Empty ||
                       _txtFechaIngreso.Text == string.Empty || _txtFechaEgreso.Text == string.Empty)
            {
                resultado = Validador.PedirStringLista(listaCombinadora);

                MessageBox.Show(resultado);
            }
            else if (_txtIdHabitacion.Text == string.Empty)
            {
                MessageBox.Show("El hotel no posee habitaciones");
            }
            else if (cantidadDeHuespedes <= 0)
            {
                MessageBox.Show("Ingrese cantidad válida");
                _txtCantidadDeHuespedes.Text = string.Empty;
            }

            else if (fechaIngreso.ToString() == "1/1/0001 00:00:00")
            {
                MessageBox.Show("Ingrese fecha válida");
                _txtFechaIngreso.Text = string.Empty;

            }
            else if (fechaEgreso.ToString() == "1/1/0001 00:00:00")
            {
                MessageBox.Show("Ingrese fecha válida");
                _txtFechaEgreso.Text = string.Empty;
            }

            else
            {
                try
                {
                    Reserva reserva = new Reserva(habitacion.IdHabitacion, cliente.ID,
                        Convert.ToInt32(_txtCantidadDeHuespedes.Text), fechaIngreso, fechaEgreso);

                    Program._hotelNegocio.AgregarReserva(reserva);

                    MessageBox.Show("Reserva agregada con éxito");

                    _txtCantidadDeHuespedes.Text = string.Empty;
                    _txtFechaEgreso.Text = string.Empty;
                    _txtFechaIngreso.Text = string.Empty;
                    

                    _lblCantidadHuespedes.BackColor = System.Drawing.Color.Transparent;
                    _lblFechaEgreso.BackColor = System.Drawing.Color.Transparent;
                    _lblFechaIngreso.BackColor = System.Drawing.Color.Transparent;

                }
                
                catch (Exception ex)
                
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void CargarListas()
        {
            List<HotelEntidad> listaHoteles = new List<HotelEntidad>();

            listaHoteles = Program._hotelNegocio.TraerHoteles();

            _lstHoteles.DataSource = null;
            _lstHoteles.DataSource = listaHoteles;
  
            List<Cliente> listaClientes = new List<Cliente>();

            listaClientes = Program._hotelNegocio.TraerClientes();
            
            _lstClientes.DataSource = null;
            _lstClientes.DataSource = listaClientes;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void _cmbClientesPorId_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show("pasó");
        }

        private void _cmbClientesPorId_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
         //Quedo sin efecto//

            try
            {
              
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            finally
            {
                DialogResult dialogResult = MessageBox.Show("¿Desea agregar cliente?", "", MessageBoxButtons.YesNo);
                
                if (dialogResult == DialogResult.Yes)
                {
                    FrmAltaCliente frm = new FrmAltaCliente(this);

                    frm.Show();
                }

                else if (dialogResult == DialogResult.No)
                {
                    
                }
            }
                
        }

        private void _cmbNombreHoteles_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void _lstHoteles_SelectedIndexChanged(object sender, EventArgs e)
        {
             List<Habitacion> listaHabitaciones = new List<Habitacion>();
             HotelEntidad hotelSeleccionado = (HotelEntidad)_lstHoteles.SelectedItem;
            _lstHabitaciones.DataSource = Program._hotelNegocio.TraerHabitaciones(hotelSeleccionado.ID);

            _txtIdHotel.Text = hotelSeleccionado.ID.ToString();
            _txtNombreHotel.Text = hotelSeleccionado.Nombre;
            _txtDireccionHotel.Text = hotelSeleccionado.Direccion;
            _txtPrecio.Text = hotelSeleccionado.Estrellas.ToString();
            
               if (_lstHabitaciones.Items.Count == 0)
            {
                _txtIdHabitacion.Text = string.Empty;
                _txtCantidaPlazas.Text = string.Empty;
                _txtPrecio.Text = string.Empty;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void _btnAltaCliente_Click(object sender, EventArgs e)
        {
            FrmAltaCliente frm = new FrmAltaCliente(this);
            frm.Show();
            this.Hide();

            
        }

        private void _btnRefrescar_Click(object sender, EventArgs e)
        {
            List<Cliente> listaCliente = Program._hotelNegocio.TraerClientes();
            _lstClientes.DataSource = listaCliente;
        }

        private void _cmbClienteID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void _lstHabitaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Habitacion> lsitahabitaciones = new List<Habitacion>();
            Habitacion habitacionseleccionada = (Habitacion)_lstHabitaciones.SelectedItem;

            if (habitacionseleccionada != null)
            {
                _txtIdHabitacion.Text = habitacionseleccionada.IdHabitacion.ToString();
                _txtCantidaPlazas.Text = habitacionseleccionada.CantidadPlazas.ToString();
                _txtPrecio.Text = habitacionseleccionada.Precio.ToString();
            }

        }

        private void _lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Cliente> listaclientes = new List<Cliente>();

            Cliente clienteSelecciondo = (Cliente)_lstClientes.SelectedItem;

            clienteID.Text = clienteSelecciondo.ID.ToString();
            _txtNombreCliente.Text = clienteSelecciondo.Nombre;
            _txtApellidoCliente.Text = clienteSelecciondo.Apellido;

        }

        private void FrmIngresarReservas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
