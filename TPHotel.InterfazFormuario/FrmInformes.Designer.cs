
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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btnDetalle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtIdReserva = new System.Windows.Forms.TextBox();
            this._txtNombreYApellido = new System.Windows.Forms.TextBox();
            this._txtFechaIngreso = new System.Windows.Forms.TextBox();
            this._txtHabitacion = new System.Windows.Forms.TextBox();
            this._txtEgreso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cmbClientes
            // 
            this._cmbClientes.FormattingEnabled = true;
            this._cmbClientes.Location = new System.Drawing.Point(28, 55);
            this._cmbClientes.Name = "_cmbClientes";
            this._cmbClientes.Size = new System.Drawing.Size(121, 24);
            this._cmbClientes.TabIndex = 0;
            this._cmbClientes.SelectionChangeCommitted += new System.EventHandler(this._cmbClientes_SelectionChangeCommitted);
            // 
            // _lstReservas
            // 
            this._lstReservas.FormattingEnabled = true;
            this._lstReservas.ItemHeight = 16;
            this._lstReservas.Location = new System.Drawing.Point(28, 98);
            this._lstReservas.Name = "_lstReservas";
            this._lstReservas.Size = new System.Drawing.Size(369, 84);
            this._lstReservas.TabIndex = 1;
            // 
            // _cmbHotel
            // 
            this._cmbHotel.FormattingEnabled = true;
            this._cmbHotel.Location = new System.Drawing.Point(6, 55);
            this._cmbHotel.Name = "_cmbHotel";
            this._cmbHotel.Size = new System.Drawing.Size(121, 24);
            this._cmbHotel.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(6, 98);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(380, 84);
            this.listBox2.TabIndex = 3;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(24, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 372);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservas por cliente";
            // 
            // _btnDetalle
            // 
            this._btnDetalle.Location = new System.Drawing.Point(28, 196);
            this._btnDetalle.Name = "_btnDetalle";
            this._btnDetalle.Size = new System.Drawing.Size(75, 23);
            this._btnDetalle.TabIndex = 3;
            this._btnDetalle.Text = "Detalle";
            this._btnDetalle.UseVisualStyleBackColor = true;
            this._btnDetalle.Click += new System.EventHandler(this._btnBuscarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this._cmbHotel);
            this.groupBox2.Location = new System.Drawing.Point(466, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 225);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Habitaciones por hotel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Hotel";
            // 
            // _txtIdReserva
            // 
            this._txtIdReserva.Location = new System.Drawing.Point(181, 233);
            this._txtIdReserva.Name = "_txtIdReserva";
            this._txtIdReserva.Size = new System.Drawing.Size(30, 22);
            this._txtIdReserva.TabIndex = 4;
            // 
            // _txtNombreYApellido
            // 
            this._txtNombreYApellido.Location = new System.Drawing.Point(181, 261);
            this._txtNombreYApellido.Name = "_txtNombreYApellido";
            this._txtNombreYApellido.Size = new System.Drawing.Size(169, 22);
            this._txtNombreYApellido.TabIndex = 5;
            // 
            // _txtFechaIngreso
            // 
            this._txtFechaIngreso.Location = new System.Drawing.Point(181, 291);
            this._txtFechaIngreso.Name = "_txtFechaIngreso";
            this._txtFechaIngreso.Size = new System.Drawing.Size(169, 22);
            this._txtFechaIngreso.TabIndex = 6;
            // 
            // _txtHabitacion
            // 
            this._txtHabitacion.Location = new System.Drawing.Point(181, 350);
            this._txtHabitacion.Name = "_txtHabitacion";
            this._txtHabitacion.Size = new System.Drawing.Size(100, 22);
            this._txtHabitacion.TabIndex = 7;
            // 
            // _txtEgreso
            // 
            this._txtEgreso.Location = new System.Drawing.Point(181, 319);
            this._txtEgreso.Name = "_txtEgreso";
            this._txtEgreso.Size = new System.Drawing.Size(169, 22);
            this._txtEgreso.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Id reserva";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Habitacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha egreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre y apellido Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha ingreso";
            // 
            // FrmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 484);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmInformes";
            this.Text = "FrmInformes";
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
        private System.Windows.Forms.ListBox listBox2;
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
    }
}