
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
            this._txtIdCliente = new System.Windows.Forms.TextBox();
            this._txtCantidadDeHuespedes = new System.Windows.Forms.TextBox();
            this._txtFechaIngreso = new System.Windows.Forms.TextBox();
            this._txtFechaEgreso = new System.Windows.Forms.TextBox();
            this._txtId = new System.Windows.Forms.TextBox();
            this._cmbClientesPorId = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this._cmbNombreHoteles = new System.Windows.Forms.ComboBox();
            this._lblNombreHotel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this._lblCantidadHuespedes = new System.Windows.Forms.Label();
            this._lblFechaIngreso = new System.Windows.Forms.Label();
            this._lblFechaEgreso = new System.Windows.Forms.Label();
            this._lblIdReserva = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _btnAltaHotel
            // 
            this._btnAltaHotel.Location = new System.Drawing.Point(406, 268);
            this._btnAltaHotel.Name = "_btnAltaHotel";
            this._btnAltaHotel.Size = new System.Drawing.Size(184, 94);
            this._btnAltaHotel.TabIndex = 0;
            this._btnAltaHotel.Text = "ALTA HOTEL";
            this._btnAltaHotel.UseVisualStyleBackColor = true;
            this._btnAltaHotel.Click += new System.EventHandler(this.button1_Click);
            // 
            // _txtIdCliente
            // 
            this._txtIdCliente.Enabled = false;
            this._txtIdCliente.Location = new System.Drawing.Point(406, 158);
            this._txtIdCliente.Name = "_txtIdCliente";
            this._txtIdCliente.Size = new System.Drawing.Size(31, 22);
            this._txtIdCliente.TabIndex = 1;
            // 
            // _txtCantidadDeHuespedes
            // 
            this._txtCantidadDeHuespedes.Location = new System.Drawing.Point(186, 212);
            this._txtCantidadDeHuespedes.Name = "_txtCantidadDeHuespedes";
            this._txtCantidadDeHuespedes.Size = new System.Drawing.Size(100, 22);
            this._txtCantidadDeHuespedes.TabIndex = 2;
            // 
            // _txtFechaIngreso
            // 
            this._txtFechaIngreso.Location = new System.Drawing.Point(186, 240);
            this._txtFechaIngreso.Name = "_txtFechaIngreso";
            this._txtFechaIngreso.Size = new System.Drawing.Size(100, 22);
            this._txtFechaIngreso.TabIndex = 3;
            // 
            // _txtFechaEgreso
            // 
            this._txtFechaEgreso.Location = new System.Drawing.Point(186, 268);
            this._txtFechaEgreso.Name = "_txtFechaEgreso";
            this._txtFechaEgreso.Size = new System.Drawing.Size(100, 22);
            this._txtFechaEgreso.TabIndex = 4;
            // 
            // _txtId
            // 
            this._txtId.Location = new System.Drawing.Point(186, 307);
            this._txtId.Name = "_txtId";
            this._txtId.Size = new System.Drawing.Size(100, 22);
            this._txtId.TabIndex = 5;
            // 
            // _cmbClientesPorId
            // 
            this._cmbClientesPorId.FormattingEnabled = true;
            this._cmbClientesPorId.Location = new System.Drawing.Point(183, 155);
            this._cmbClientesPorId.Name = "_cmbClientesPorId";
            this._cmbClientesPorId.Size = new System.Drawing.Size(100, 24);
            this._cmbClientesPorId.TabIndex = 6;
            this._cmbClientesPorId.SelectedIndexChanged += new System.EventHandler(this._cmbClientesPorId_SelectedIndexChanged);
            this._cmbClientesPorId.SelectedValueChanged += new System.EventHandler(this._cmbClientesPorId_SelectedValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(183, 113);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(103, 24);
            this.comboBox2.TabIndex = 7;
            // 
            // _cmbNombreHoteles
            // 
            this._cmbNombreHoteles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbNombreHoteles.FormattingEnabled = true;
            this._cmbNombreHoteles.Location = new System.Drawing.Point(183, 68);
            this._cmbNombreHoteles.Name = "_cmbNombreHoteles";
            this._cmbNombreHoteles.Size = new System.Drawing.Size(103, 24);
            this._cmbNombreHoteles.TabIndex = 8;
            // 
            // _lblNombreHotel
            // 
            this._lblNombreHotel.AutoSize = true;
            this._lblNombreHotel.Location = new System.Drawing.Point(44, 68);
            this._lblNombreHotel.Name = "_lblNombreHotel";
            this._lblNombreHotel.Size = new System.Drawing.Size(133, 17);
            this._lblNombreHotel.TabIndex = 9;
            this._lblNombreHotel.Text = "Hoteles por nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Habitaciones por ID";
            // 
            // _txtNombre
            // 
            this._txtNombre.Enabled = false;
            this._txtNombre.Location = new System.Drawing.Point(443, 157);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(100, 22);
            this._txtNombre.TabIndex = 11;
            // 
            // _txtApellido
            // 
            this._txtApellido.Enabled = false;
            this._txtApellido.Location = new System.Drawing.Point(549, 157);
            this._txtApellido.Name = "_txtApellido";
            this._txtApellido.Size = new System.Drawing.Size(100, 22);
            this._txtApellido.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Clientes por ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "NOMBRE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(561, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "APELLIDO";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 64);
            this.button2.TabIndex = 17;
            this.button2.Text = "Ver detalle seleccion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // _lblCantidadHuespedes
            // 
            this._lblCantidadHuespedes.AutoSize = true;
            this._lblCantidadHuespedes.Location = new System.Drawing.Point(39, 215);
            this._lblCantidadHuespedes.Name = "_lblCantidadHuespedes";
            this._lblCantidadHuespedes.Size = new System.Drawing.Size(138, 17);
            this._lblCantidadHuespedes.TabIndex = 18;
            this._lblCantidadHuespedes.Text = "Cantidad huespedes";
            // 
            // _lblFechaIngreso
            // 
            this._lblFechaIngreso.AutoSize = true;
            this._lblFechaIngreso.Location = new System.Drawing.Point(77, 243);
            this._lblFechaIngreso.Name = "_lblFechaIngreso";
            this._lblFechaIngreso.Size = new System.Drawing.Size(98, 17);
            this._lblFechaIngreso.TabIndex = 19;
            this._lblFechaIngreso.Text = "Fecha ingreso";
            // 
            // _lblFechaEgreso
            // 
            this._lblFechaEgreso.AutoSize = true;
            this._lblFechaEgreso.Location = new System.Drawing.Point(77, 268);
            this._lblFechaEgreso.Name = "_lblFechaEgreso";
            this._lblFechaEgreso.Size = new System.Drawing.Size(95, 17);
            this._lblFechaEgreso.TabIndex = 20;
            this._lblFechaEgreso.Text = "Fecha egreso";
            // 
            // _lblIdReserva
            // 
            this._lblIdReserva.AutoSize = true;
            this._lblIdReserva.Location = new System.Drawing.Point(95, 307);
            this._lblIdReserva.Name = "_lblIdReserva";
            this._lblIdReserva.Size = new System.Drawing.Size(78, 17);
            this._lblIdReserva.TabIndex = 21;
            this._lblIdReserva.Text = "ID Reserva";
            // 
            // FrmIngresarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._lblIdReserva);
            this.Controls.Add(this._lblFechaEgreso);
            this.Controls.Add(this._lblFechaIngreso);
            this.Controls.Add(this._lblCantidadHuespedes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtApellido);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lblNombreHotel);
            this.Controls.Add(this._cmbNombreHoteles);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this._cmbClientesPorId);
            this.Controls.Add(this._txtId);
            this.Controls.Add(this._txtFechaEgreso);
            this.Controls.Add(this._txtFechaIngreso);
            this.Controls.Add(this._txtCantidadDeHuespedes);
            this.Controls.Add(this._txtIdCliente);
            this.Controls.Add(this._btnAltaHotel);
            this.Name = "FrmIngresarReservas";
            this.Text = "FormIngresarReservas";
            this.Load += new System.EventHandler(this.FrmIngresarConsultarReservas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnAltaHotel;
        private System.Windows.Forms.TextBox _txtIdCliente;
        private System.Windows.Forms.TextBox _txtCantidadDeHuespedes;
        private System.Windows.Forms.TextBox _txtFechaIngreso;
        private System.Windows.Forms.TextBox _txtFechaEgreso;
        private System.Windows.Forms.TextBox _txtId;
        private System.Windows.Forms.ComboBox _cmbClientesPorId;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox _cmbNombreHoteles;
        private System.Windows.Forms.Label _lblNombreHotel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.TextBox _txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label _lblCantidadHuespedes;
        private System.Windows.Forms.Label _lblFechaIngreso;
        private System.Windows.Forms.Label _lblFechaEgreso;
        private System.Windows.Forms.Label _lblIdReserva;
    }
}