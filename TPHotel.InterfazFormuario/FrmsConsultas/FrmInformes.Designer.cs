
namespace TPHotel.InterfazFormuario
{
    partial class FrmInformes
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
            this._cmbClientes = new System.Windows.Forms.ComboBox();
            this._lstReservas = new System.Windows.Forms.ListBox();
            this._cmbHotel = new System.Windows.Forms.ComboBox();
            this._lstHabitaciones = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._txtEgreso = new System.Windows.Forms.TextBox();
            this._txtHabitacion = new System.Windows.Forms.TextBox();
            this._txtFechaIngreso = new System.Windows.Forms.TextBox();
            this._txtNombreYApellido = new System.Windows.Forms.TextBox();
            this._txtIdReserva = new System.Windows.Forms.TextBox();
            this._btnDetalle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._txtHabNmbr = new System.Windows.Forms.TextBox();
            this._txtEstrellas = new System.Windows.Forms.TextBox();
            this._txtIdHabitacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cmbClientes
            // 
            this._cmbClientes.FormattingEnabled = true;
            this._cmbClientes.Location = new System.Drawing.Point(38, 82);
            this._cmbClientes.Margin = new System.Windows.Forms.Padding(4);
            this._cmbClientes.Name = "_cmbClientes";
            this._cmbClientes.Size = new System.Drawing.Size(328, 32);
            this._cmbClientes.TabIndex = 0;
            this._cmbClientes.SelectedIndexChanged += new System.EventHandler(this._cmbClientes_SelectedIndexChanged);
            this._cmbClientes.SelectionChangeCommitted += new System.EventHandler(this._cmbClientes_SelectionChangeCommitted);
            // 
            // _lstReservas
            // 
            this._lstReservas.FormattingEnabled = true;
            this._lstReservas.ItemHeight = 24;
            this._lstReservas.Location = new System.Drawing.Point(38, 147);
            this._lstReservas.Margin = new System.Windows.Forms.Padding(4);
            this._lstReservas.Name = "_lstReservas";
            this._lstReservas.Size = new System.Drawing.Size(506, 124);
            this._lstReservas.TabIndex = 1;
            this._lstReservas.SelectedIndexChanged += new System.EventHandler(this._lstReservas_SelectedIndexChanged);
            // 
            // _cmbHotel
            // 
            this._cmbHotel.FormattingEnabled = true;
            this._cmbHotel.Location = new System.Drawing.Point(8, 82);
            this._cmbHotel.Margin = new System.Windows.Forms.Padding(4);
            this._cmbHotel.Name = "_cmbHotel";
            this._cmbHotel.Size = new System.Drawing.Size(323, 32);
            this._cmbHotel.TabIndex = 2;
            this._cmbHotel.SelectionChangeCommitted += new System.EventHandler(this._cmbHotel_SelectionChangeCommitted);
            // 
            // _lstHabitaciones
            // 
            this._lstHabitaciones.FormattingEnabled = true;
            this._lstHabitaciones.ItemHeight = 24;
            this._lstHabitaciones.Location = new System.Drawing.Point(8, 147);
            this._lstHabitaciones.Margin = new System.Windows.Forms.Padding(4);
            this._lstHabitaciones.Name = "_lstHabitaciones";
            this._lstHabitaciones.Size = new System.Drawing.Size(521, 124);
            this._lstHabitaciones.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this._txtEgreso);
            this.groupBox1.Controls.Add(this._txtHabitacion);
            this.groupBox1.Controls.Add(this._txtFechaIngreso);
            this.groupBox1.Controls.Add(this._txtNombreYApellido);
            this.groupBox1.Controls.Add(this._txtIdReserva);
            this.groupBox1.Controls.Add(this._btnDetalle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._lstReservas);
            this.groupBox1.Controls.Add(this._cmbClientes);
            this.groupBox1.Location = new System.Drawing.Point(16, 129);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(616, 558);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservas por cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 444);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 396);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre y apellido del cliente";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 483);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha egreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 525);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Habitacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 357);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Id reserva";
            // 
            // _txtEgreso
            // 
            this._txtEgreso.Location = new System.Drawing.Point(327, 478);
            this._txtEgreso.Margin = new System.Windows.Forms.Padding(4);
            this._txtEgreso.Name = "_txtEgreso";
            this._txtEgreso.Size = new System.Drawing.Size(231, 29);
            this._txtEgreso.TabIndex = 8;
            // 
            // _txtHabitacion
            // 
            this._txtHabitacion.Location = new System.Drawing.Point(327, 525);
            this._txtHabitacion.Margin = new System.Windows.Forms.Padding(4);
            this._txtHabitacion.Name = "_txtHabitacion";
            this._txtHabitacion.Size = new System.Drawing.Size(136, 29);
            this._txtHabitacion.TabIndex = 7;
            // 
            // _txtFechaIngreso
            // 
            this._txtFechaIngreso.Location = new System.Drawing.Point(327, 436);
            this._txtFechaIngreso.Margin = new System.Windows.Forms.Padding(4);
            this._txtFechaIngreso.Name = "_txtFechaIngreso";
            this._txtFechaIngreso.Size = new System.Drawing.Size(231, 29);
            this._txtFechaIngreso.TabIndex = 6;
            // 
            // _txtNombreYApellido
            // 
            this._txtNombreYApellido.Location = new System.Drawing.Point(327, 392);
            this._txtNombreYApellido.Margin = new System.Windows.Forms.Padding(4);
            this._txtNombreYApellido.Name = "_txtNombreYApellido";
            this._txtNombreYApellido.Size = new System.Drawing.Size(231, 29);
            this._txtNombreYApellido.TabIndex = 5;
            // 
            // _txtIdReserva
            // 
            this._txtIdReserva.Location = new System.Drawing.Point(327, 350);
            this._txtIdReserva.Margin = new System.Windows.Forms.Padding(4);
            this._txtIdReserva.Name = "_txtIdReserva";
            this._txtIdReserva.Size = new System.Drawing.Size(40, 29);
            this._txtIdReserva.TabIndex = 4;
            // 
            // _btnDetalle
            // 
            this._btnDetalle.Location = new System.Drawing.Point(38, 294);
            this._btnDetalle.Margin = new System.Windows.Forms.Padding(4);
            this._btnDetalle.Name = "_btnDetalle";
            this._btnDetalle.Size = new System.Drawing.Size(103, 34);
            this._btnDetalle.TabIndex = 3;
            this._btnDetalle.Text = "Detalle";
            this._btnDetalle.UseVisualStyleBackColor = true;
            this._btnDetalle.Click += new System.EventHandler(this._btnBuscarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this._txtHabNmbr);
            this.groupBox2.Controls.Add(this._txtEstrellas);
            this.groupBox2.Controls.Add(this._txtIdHabitacion);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this._lstHabitaciones);
            this.groupBox2.Controls.Add(this._cmbHotel);
            this.groupBox2.Location = new System.Drawing.Point(641, 129);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(539, 558);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Habitaciones por hotel";
            // 
            // _txtHabNmbr
            // 
            this._txtHabNmbr.Location = new System.Drawing.Point(139, 392);
            this._txtHabNmbr.Margin = new System.Windows.Forms.Padding(4);
            this._txtHabNmbr.Name = "_txtHabNmbr";
            this._txtHabNmbr.Size = new System.Drawing.Size(136, 29);
            this._txtHabNmbr.TabIndex = 12;
            // 
            // _txtEstrellas
            // 
            this._txtEstrellas.Location = new System.Drawing.Point(139, 434);
            this._txtEstrellas.Margin = new System.Windows.Forms.Padding(4);
            this._txtEstrellas.Name = "_txtEstrellas";
            this._txtEstrellas.Size = new System.Drawing.Size(136, 29);
            this._txtEstrellas.TabIndex = 11;
            // 
            // _txtIdHabitacion
            // 
            this._txtIdHabitacion.Location = new System.Drawing.Point(139, 342);
            this._txtIdHabitacion.Margin = new System.Windows.Forms.Padding(4);
            this._txtIdHabitacion.Name = "_txtIdHabitacion";
            this._txtIdHabitacion.Size = new System.Drawing.Size(136, 29);
            this._txtIdHabitacion.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 399);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Categoria";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 441);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 357);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 294);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Detalle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Hotel";
            // 
            // FrmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 726);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInformes";
            this.Text = "FrmInformes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInformes_FormClosing);
            this.Load += new System.EventHandler(this.FrmInformes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox _cmbClientes;
        private System.Windows.Forms.ListBox _lstReservas;
        private System.Windows.Forms.ComboBox _cmbHotel;
        private System.Windows.Forms.ListBox _lstHabitaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnDetalle;
        private System.Windows.Forms.TextBox _txtIdReserva;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtEgreso;
        private System.Windows.Forms.TextBox _txtHabitacion;
        private System.Windows.Forms.TextBox _txtFechaIngreso;
        private System.Windows.Forms.TextBox _txtNombreYApellido;
        private System.Windows.Forms.TextBox _txtIdHabitacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox _txtHabNmbr;
        private System.Windows.Forms.TextBox _txtEstrellas;
    }
}