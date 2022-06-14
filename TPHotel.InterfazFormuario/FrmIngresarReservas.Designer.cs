﻿
namespace TPHotel.InterfazFormuario
{
    partial class FrmIngresarReservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._btnAltaHotel = new System.Windows.Forms.Button();
            this._txtIdHotel = new System.Windows.Forms.TextBox();
            this._txtCantidadDeHuespedes = new System.Windows.Forms.TextBox();
            this._txtFechaIngreso = new System.Windows.Forms.TextBox();
            this._txtFechaEgreso = new System.Windows.Forms.TextBox();
            this._lblNombreHotel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._txtDireccionHotel = new System.Windows.Forms.TextBox();
            this._txtEstrellas = new System.Windows.Forms.TextBox();
            this._lblCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._lblCantidadHuespedes = new System.Windows.Forms.Label();
            this._lblFechaIngreso = new System.Windows.Forms.Label();
            this._lblFechaEgreso = new System.Windows.Forms.Label();
            this._lstHabitaciones = new System.Windows.Forms.ListBox();
            this._lstHoteles = new System.Windows.Forms.ListBox();
            this._txtNombreHotel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._lstClientes = new System.Windows.Forms.ListBox();
            this._btnAltaCliente = new System.Windows.Forms.Button();
            this._btnRefrescar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._txtCantidaPlazas = new System.Windows.Forms.TextBox();
            this._txtIdHabitacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this._txtPrecio = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this._txtNombreCliente = new System.Windows.Forms.TextBox();
            this.clienteID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this._txtApellidoCliente = new System.Windows.Forms.TextBox();
            this._txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnAltaHotel
            // 
            this._btnAltaHotel.Location = new System.Drawing.Point(144, 151);
            this._btnAltaHotel.Name = "_btnAltaHotel";
            this._btnAltaHotel.Size = new System.Drawing.Size(117, 99);
            this._btnAltaHotel.TabIndex = 0;
            this._btnAltaHotel.Text = "ALTA HOTEL";
            this._btnAltaHotel.UseVisualStyleBackColor = true;
            this._btnAltaHotel.Click += new System.EventHandler(this.button1_Click);
            // 
            // _txtIdHotel
            // 
            this._txtIdHotel.Enabled = false;
            this._txtIdHotel.Location = new System.Drawing.Point(17, 58);
            this._txtIdHotel.Name = "_txtIdHotel";
            this._txtIdHotel.Size = new System.Drawing.Size(31, 22);
            this._txtIdHotel.TabIndex = 1;
            // 
            // _txtCantidadDeHuespedes
            // 
            this._txtCantidadDeHuespedes.Location = new System.Drawing.Point(144, 21);
            this._txtCantidadDeHuespedes.Name = "_txtCantidadDeHuespedes";
            this._txtCantidadDeHuespedes.Size = new System.Drawing.Size(100, 22);
            this._txtCantidadDeHuespedes.TabIndex = 2;
            // 
            // _txtFechaIngreso
            // 
            this._txtFechaIngreso.Location = new System.Drawing.Point(144, 51);
            this._txtFechaIngreso.Name = "_txtFechaIngreso";
            this._txtFechaIngreso.Size = new System.Drawing.Size(100, 22);
            this._txtFechaIngreso.TabIndex = 3;
            // 
            // _txtFechaEgreso
            // 
            this._txtFechaEgreso.Location = new System.Drawing.Point(144, 79);
            this._txtFechaEgreso.Name = "_txtFechaEgreso";
            this._txtFechaEgreso.Size = new System.Drawing.Size(100, 22);
            this._txtFechaEgreso.TabIndex = 4;
            // 
            // _lblNombreHotel
            // 
            this._lblNombreHotel.AutoSize = true;
            this._lblNombreHotel.Location = new System.Drawing.Point(12, 28);
            this._lblNombreHotel.Name = "_lblNombreHotel";
            this._lblNombreHotel.Size = new System.Drawing.Size(133, 17);
            this._lblNombreHotel.TabIndex = 9;
            this._lblNombreHotel.Text = "Hoteles por nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Habitaciones del hotel";
            // 
            // _txtDireccionHotel
            // 
            this._txtDireccionHotel.Enabled = false;
            this._txtDireccionHotel.Location = new System.Drawing.Point(167, 58);
            this._txtDireccionHotel.Name = "_txtDireccionHotel";
            this._txtDireccionHotel.Size = new System.Drawing.Size(100, 22);
            this._txtDireccionHotel.TabIndex = 11;
            // 
            // _txtEstrellas
            // 
            this._txtEstrellas.Enabled = false;
            this._txtEstrellas.Location = new System.Drawing.Point(273, 58);
            this._txtEstrellas.Name = "_txtEstrellas";
            this._txtEstrellas.Size = new System.Drawing.Size(100, 22);
            this._txtEstrellas.TabIndex = 12;
            // 
            // _lblCliente
            // 
            this._lblCliente.AutoSize = true;
            this._lblCliente.Location = new System.Drawing.Point(14, 232);
            this._lblCliente.Name = "_lblCliente";
            this._lblCliente.Size = new System.Drawing.Size(126, 17);
            this._lblCliente.TabIndex = 13;
            this._lblCliente.Text = "Listado de clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "NOMBRE";
            // 
            // _lblCantidadHuespedes
            // 
            this._lblCantidadHuespedes.AutoSize = true;
            this._lblCantidadHuespedes.Location = new System.Drawing.Point(6, 21);
            this._lblCantidadHuespedes.Name = "_lblCantidadHuespedes";
            this._lblCantidadHuespedes.Size = new System.Drawing.Size(138, 17);
            this._lblCantidadHuespedes.TabIndex = 18;
            this._lblCantidadHuespedes.Text = "Cantidad huespedes";
            // 
            // _lblFechaIngreso
            // 
            this._lblFechaIngreso.AutoSize = true;
            this._lblFechaIngreso.Location = new System.Drawing.Point(30, 54);
            this._lblFechaIngreso.Name = "_lblFechaIngreso";
            this._lblFechaIngreso.Size = new System.Drawing.Size(98, 17);
            this._lblFechaIngreso.TabIndex = 19;
            this._lblFechaIngreso.Text = "Fecha ingreso";
            // 
            // _lblFechaEgreso
            // 
            this._lblFechaEgreso.AutoSize = true;
            this._lblFechaEgreso.Location = new System.Drawing.Point(33, 84);
            this._lblFechaEgreso.Name = "_lblFechaEgreso";
            this._lblFechaEgreso.Size = new System.Drawing.Size(95, 17);
            this._lblFechaEgreso.TabIndex = 20;
            this._lblFechaEgreso.Text = "Fecha egreso";
            // 
            // _lstHabitaciones
            // 
            this._lstHabitaciones.FormattingEnabled = true;
            this._lstHabitaciones.ItemHeight = 16;
            this._lstHabitaciones.Location = new System.Drawing.Point(17, 154);
            this._lstHabitaciones.Name = "_lstHabitaciones";
            this._lstHabitaciones.Size = new System.Drawing.Size(326, 68);
            this._lstHabitaciones.TabIndex = 22;
            this._lstHabitaciones.SelectedIndexChanged += new System.EventHandler(this._lstHabitaciones_SelectedIndexChanged);
            // 
            // _lstHoteles
            // 
            this._lstHoteles.FormattingEnabled = true;
            this._lstHoteles.ItemHeight = 16;
            this._lstHoteles.Location = new System.Drawing.Point(15, 51);
            this._lstHoteles.Name = "_lstHoteles";
            this._lstHoteles.Size = new System.Drawing.Size(336, 68);
            this._lstHoteles.TabIndex = 23;
            this._lstHoteles.SelectedIndexChanged += new System.EventHandler(this._lstHoteles_SelectedIndexChanged);
            // 
            // _txtNombreHotel
            // 
            this._txtNombreHotel.Enabled = false;
            this._txtNombreHotel.Location = new System.Drawing.Point(61, 58);
            this._txtNombreHotel.Name = "_txtNombreHotel";
            this._txtNombreHotel.Size = new System.Drawing.Size(100, 22);
            this._txtNombreHotel.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Salmon;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this._txtFechaEgreso);
            this.groupBox1.Controls.Add(this._txtCantidadDeHuespedes);
            this.groupBox1.Controls.Add(this._txtFechaIngreso);
            this.groupBox1.Controls.Add(this._lblCantidadHuespedes);
            this.groupBox1.Controls.Add(this._lblFechaIngreso);
            this.groupBox1.Controls.Add(this._lblFechaEgreso);
            this.groupBox1.Controls.Add(this._btnAltaHotel);
            this.groupBox1.Location = new System.Drawing.Point(10, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 279);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // _lstClientes
            // 
            this._lstClientes.FormattingEnabled = true;
            this._lstClientes.ItemHeight = 16;
            this._lstClientes.Location = new System.Drawing.Point(17, 252);
            this._lstClientes.Name = "_lstClientes";
            this._lstClientes.Size = new System.Drawing.Size(326, 68);
            this._lstClientes.TabIndex = 26;
            this._lstClientes.SelectedIndexChanged += new System.EventHandler(this._lstClientes_SelectedIndexChanged);
            // 
            // _btnAltaCliente
            // 
            this._btnAltaCliente.Location = new System.Drawing.Point(190, 325);
            this._btnAltaCliente.Name = "_btnAltaCliente";
            this._btnAltaCliente.Size = new System.Drawing.Size(161, 29);
            this._btnAltaCliente.TabIndex = 27;
            this._btnAltaCliente.Text = "Dar de alta cliente";
            this._btnAltaCliente.UseVisualStyleBackColor = true;
            this._btnAltaCliente.Click += new System.EventHandler(this._btnAltaCliente_Click);
            // 
            // _btnRefrescar
            // 
            this._btnRefrescar.Location = new System.Drawing.Point(40, 326);
            this._btnRefrescar.Name = "_btnRefrescar";
            this._btnRefrescar.Size = new System.Drawing.Size(134, 28);
            this._btnRefrescar.TabIndex = 28;
            this._btnRefrescar.Text = "Refrescar lista";
            this._btnRefrescar.UseVisualStyleBackColor = true;
            this._btnRefrescar.Click += new System.EventHandler(this._btnRefrescar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "ESTRELLAS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "DIRECCIÓN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this._txtNombreHotel);
            this.groupBox2.Controls.Add(this._txtIdHotel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this._txtDireccionHotel);
            this.groupBox2.Controls.Add(this._txtEstrellas);
            this.groupBox2.Location = new System.Drawing.Point(381, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 100);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle hotel seleccionado";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this._txtCantidaPlazas);
            this.groupBox3.Controls.Add(this._txtIdHabitacion);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this._txtPrecio);
            this.groupBox3.Location = new System.Drawing.Point(381, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 100);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle habitación seleccionada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "PRECIO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "ID";
            // 
            // _txtCantidaPlazas
            // 
            this._txtCantidaPlazas.Enabled = false;
            this._txtCantidaPlazas.Location = new System.Drawing.Point(91, 58);
            this._txtCantidaPlazas.Name = "_txtCantidaPlazas";
            this._txtCantidaPlazas.Size = new System.Drawing.Size(100, 22);
            this._txtCantidaPlazas.TabIndex = 24;
            // 
            // _txtIdHabitacion
            // 
            this._txtIdHabitacion.Enabled = false;
            this._txtIdHabitacion.Location = new System.Drawing.Point(17, 58);
            this._txtIdHabitacion.Name = "_txtIdHabitacion";
            this._txtIdHabitacion.Size = new System.Drawing.Size(31, 22);
            this._txtIdHabitacion.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "CANTIDAD PLAZAS";
            // 
            // _txtPrecio
            // 
            this._txtPrecio.Enabled = false;
            this._txtPrecio.Location = new System.Drawing.Point(223, 58);
            this._txtPrecio.Name = "_txtPrecio";
            this._txtPrecio.Size = new System.Drawing.Size(100, 22);
            this._txtPrecio.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this._txtNombreCliente);
            this.groupBox4.Controls.Add(this.clienteID);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this._txtApellidoCliente);
            this.groupBox4.Controls.Add(this._txtFechaNacimiento);
            this.groupBox4.Location = new System.Drawing.Point(381, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(414, 100);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalle cliente seleccionado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(181, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "APELLIDO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(270, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "FECHA DE NACIM.";
            // 
            // _txtNombreCliente
            // 
            this._txtNombreCliente.Enabled = false;
            this._txtNombreCliente.Location = new System.Drawing.Point(61, 58);
            this._txtNombreCliente.Name = "_txtNombreCliente";
            this._txtNombreCliente.Size = new System.Drawing.Size(100, 22);
            this._txtNombreCliente.TabIndex = 24;
            // 
            // clienteID
            // 
            this.clienteID.Enabled = false;
            this.clienteID.Location = new System.Drawing.Point(17, 58);
            this.clienteID.Name = "clienteID";
            this.clienteID.Size = new System.Drawing.Size(31, 22);
            this.clienteID.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(68, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 15;
            this.label14.Text = "NOMBRE";
            // 
            // _txtApellidoCliente
            // 
            this._txtApellidoCliente.Enabled = false;
            this._txtApellidoCliente.Location = new System.Drawing.Point(167, 58);
            this._txtApellidoCliente.Name = "_txtApellidoCliente";
            this._txtApellidoCliente.Size = new System.Drawing.Size(100, 22);
            this._txtApellidoCliente.TabIndex = 11;
            // 
            // _txtFechaNacimiento
            // 
            this._txtFechaNacimiento.Enabled = false;
            this._txtFechaNacimiento.Location = new System.Drawing.Point(273, 58);
            this._txtFechaNacimiento.Name = "_txtFechaNacimiento";
            this._txtFechaNacimiento.Size = new System.Drawing.Size(100, 22);
            this._txtFechaNacimiento.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TPHotel.InterfazFormuario.Properties.Resources.uno_dos_tres_cuatro;
            this.pictureBox1.Location = new System.Drawing.Point(480, -99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 384);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FrmIngresarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 637);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this._btnRefrescar);
            this.Controls.Add(this._btnAltaCliente);
            this.Controls.Add(this._lstClientes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._lstHoteles);
            this.Controls.Add(this._lstHabitaciones);
            this.Controls.Add(this._lblCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lblNombreHotel);
            this.Name = "FrmIngresarReservas";
            this.Text = "FormIngresarReservas";
            this.Load += new System.EventHandler(this.FrmIngresarConsultarReservas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnAltaHotel;
        private System.Windows.Forms.TextBox _txtIdHotel;
        private System.Windows.Forms.TextBox _txtCantidadDeHuespedes;
        private System.Windows.Forms.TextBox _txtFechaIngreso;
        private System.Windows.Forms.TextBox _txtFechaEgreso;
        private System.Windows.Forms.Label _lblNombreHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtDireccionHotel;
        private System.Windows.Forms.TextBox _txtEstrellas;
        private System.Windows.Forms.Label _lblCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label _lblCantidadHuespedes;
        private System.Windows.Forms.Label _lblFechaIngreso;
        private System.Windows.Forms.Label _lblFechaEgreso;
        private System.Windows.Forms.ListBox _lstHabitaciones;
        private System.Windows.Forms.ListBox _lstHoteles;
        private System.Windows.Forms.TextBox _txtNombreHotel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox _lstClientes;
        private System.Windows.Forms.Button _btnAltaCliente;
        private System.Windows.Forms.Button _btnRefrescar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox _txtCantidaPlazas;
        private System.Windows.Forms.TextBox _txtIdHabitacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox _txtPrecio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox _txtNombreCliente;
        private System.Windows.Forms.TextBox clienteID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox _txtApellidoCliente;
        private System.Windows.Forms.TextBox _txtFechaNacimiento;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}