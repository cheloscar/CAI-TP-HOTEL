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

        //public FrmIngresarReservas(Cliente cliente)
        //{
        //    InitializeComponent();
        //    _cliente = cliente;
        //}

        private void FrmIngresarConsultarReservas_Load(object sender, EventArgs e)
        {
            CargarListas();
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
            //CombinadoraDeControles txtlb4 = new CombinadoraDeControles(_txtId, _lblIdReserva);

            listaCombinadora.Add(txtlb1);
            listaCombinadora.Add(txtlb2);
            listaCombinadora.Add(txtlb3);

            fechaEgreso = Validador.pedirFecha(_txtFechaEgreso.Text);
            fechaIngreso = Validador.pedirFecha(_txtFechaIngreso.Text);
            


            if (_txtCantidadDeHuespedes.Text == string.Empty ||
                       _txtFechaIngreso.Text == string.Empty || _txtFechaEgreso.Text == string.Empty)
            {
                resultado = Validador.PedirStringLista(listaCombinadora);

                MessageBox.Show(resultado);
            }
            else if (fechaIngreso.ToString() == "1/1/0001 00:00:00")
            {
                MessageBox.Show("Ingrese fecha válidas");
                _txtFechaEgreso.Text = string.Empty;

            }
            else if (fechaEgreso.ToString() == "1/1/0001 00:00:00")
            {
                MessageBox.Show("Ingrese fecha válida");
                _txtFechaIngreso.Text = string.Empty;
            }
            else
            {
                try
                {
                    Reserva reserva = new Reserva(habitacion.IdHabitacion, cliente.ID,
                        Convert.ToInt32(_txtCantidadDeHuespedes.Text), fechaIngreso, fechaEgreso);

                    Program._hotelNegocio.AgregarReserva(reserva);

                    MessageBox.Show("Reserva agregafa con éxito");

                    _txtCantidadDeHuespedes.Text = string.Empty;
                    _txtFechaEgreso.Text = string.Empty;
                    _txtFechaIngreso.Text = string.Empty;

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
            //_cmbClienteID.DataSource = null;

            //_cmbNombreHoteles.DataSource = null;

            //_cmbNombreHoteles.DataSource = listaHoteles;
            //_cmbNombreHoteles.DisplayMember = "ComboDisplay";
            //_cmbNombreHoteles.ValueMember = "Nombre";

            List<Cliente> listaClientes = new List<Cliente>();

            listaClientes = Program._hotelNegocio.TraerClientes();
            //_cmbClientesPorId.DataSource = null;

            //_cmbClienteID.DataSource = listaClientes;
            //_cmbClienteID.DisplayMember = "ComboDisplay";
            //_cmbClienteID.ValueMember = "ID";

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
           // int id = Validador.pedirInteger(_txtIdABuscar, _lblCliente);
            //Cliente cliente = _hotelNegocio.TraerCliente(Convert.ToInt32(_cmbClienteID.SelectedValue));

            //if (id == -1)
            //{
            //    MessageBox.Show("Ingrese código válido, sin letras y con numero mayores a cero");
            //}

            //else
            //{
            //    try
            //    {
            //        Cliente cli = _hotelNegocio.TraerCliente(id);



            //    }

            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message.ToString());

            //        FrmDeseaAgregarClienteNuevo frm = new FrmDeseaAgregarClienteNuevo();
            //        frm.Show();
            //    }
            //    finally
            //    {

            //        //_txtId.Text = _cliente.ID.ToString();
            //        //_txtNombre.Text = _cliente.Nombre;
            //        //_txtApellido.Text = _cliente.Apellido;

            //    }

            //}

            try
            {
               // Cliente cli = _hotelNegocio.TraerCliente(id);
                //(Convert.ToInt32(_cmbClienteID.SelectedValue));
                //_txtIdCliente.Text = cli.ID.ToString();
                //_txtNombre.Text = cli.Nombre;
                //_txtApellido.Text = cli.Apellido;
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
                //object algo = _cmbClientesPorId.SelectedValue;

            //MessageBox.Show(algo.ToString());
            

            //_txtIdCliente.Text = cliente.ID.ToString();
            //_txtNombre.Text = cliente.Nombre;
            //_txtApellido.Text = cliente.Apellido;
        }

        private void _cmbNombreHoteles_SelectedIndexChanged(object sender, EventArgs e)
        {
           // List<Habitacion> listaHabitaciones = new List<Habitacion>();
           // List<HotelEntidad> listaHoteles = new List<HotelEntidad>();

           // HotelEntidad hotel = null;

           // listaHoteles = _hotelNegocio.TraerHoteles();

           // foreach (HotelEntidad ht in listaHoteles)
               
           // { 
           //     if (ht.Nombre == (_cmbNombreHoteles.SelectedValue).ToString())
           //     {
           //         hotel = ht;
           //     }
           // }

           //listaHabitaciones = _hotelNegocio.TraerHabitaciones(hotel.ID);

           // _cmbHabitacionesPorID.DataSource = null;
           // _cmbHabitacionesPorID.DataSource = listaHabitaciones;
           // _cmbHabitacionesPorID.DisplayMember = "ComboDisplay";
           // _cmbHabitacionesPorID.ValueMember = "IdHabitacion";

        }

        private void _lstHoteles_SelectedIndexChanged(object sender, EventArgs e)
        {
             List<Habitacion> listaHabitaciones = new List<Habitacion>();
            

             HotelEntidad hotelSeleccionado = (HotelEntidad)_lstHoteles.SelectedItem;

            
             //ListaHabitaciones = _hotelNegocio.TraerHabitaciones(hotelSeleccionado.ID);
           // _lstHabitaciones.DataSource = null;
            _lstHabitaciones.DataSource = Program._hotelNegocio.TraerHabitaciones(hotelSeleccionado.ID);

            _txtIdHotel.Text = hotelSeleccionado.ID.ToString();
            _txtNombreHotel.Text = hotelSeleccionado.Nombre;
            _txtDireccionHotel.Text = hotelSeleccionado.Direccion;
            _txtPrecio.Text = hotelSeleccionado.Estrellas.ToString();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void _btnAltaCliente_Click(object sender, EventArgs e)
        {
            FrmAltaCliente frm = new FrmAltaCliente(this);
            frm.Show();

            
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
