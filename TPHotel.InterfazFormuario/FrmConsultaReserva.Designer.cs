
namespace TPHotel.InterfazFormuario
{
    partial class FrmConsultaReserva
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
            this._lblIDReserva = new System.Windows.Forms.Label();
            this._btnBuscarPorIdReserva = new System.Windows.Forms.Button();
            this._txtIdReserva = new System.Windows.Forms.TextBox();
            this._txtFechaEgreso = new System.Windows.Forms.TextBox();
            this._txtFechaIngreso = new System.Windows.Forms.TextBox();
            this._txtNumeroDeHuespedes = new System.Windows.Forms.TextBox();
            this._txtIdHabitacion = new System.Windows.Forms.TextBox();
            this._txtIDCliente = new System.Windows.Forms.TextBox();
            this.ReservaID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblIDReserva
            // 
            this._lblIDReserva.AutoSize = true;
            this._lblIDReserva.Location = new System.Drawing.Point(30, 50);
            this._lblIDReserva.Name = "_lblIDReserva";
            this._lblIDReserva.Size = new System.Drawing.Size(72, 17);
            this._lblIDReserva.TabIndex = 5;
            this._lblIDReserva.Text = "Ingrese ID";
            // 
            // _btnBuscarPorIdReserva
            // 
            this._btnBuscarPorIdReserva.Location = new System.Drawing.Point(187, 50);
            this._btnBuscarPorIdReserva.Name = "_btnBuscarPorIdReserva";
            this._btnBuscarPorIdReserva.Size = new System.Drawing.Size(75, 53);
            this._btnBuscarPorIdReserva.TabIndex = 4;
            this._btnBuscarPorIdReserva.Text = "Buscar por ID Reserva";
            this._btnBuscarPorIdReserva.UseVisualStyleBackColor = true;
            this._btnBuscarPorIdReserva.Click += new System.EventHandler(this._btnBuscarPorIdReserva_Click);
            // 
            // _txtIdReserva
            // 
            this._txtIdReserva.Location = new System.Drawing.Point(130, 65);
            this._txtIdReserva.Name = "_txtIdReserva";
            this._txtIdReserva.Size = new System.Drawing.Size(36, 22);
            this._txtIdReserva.TabIndex = 3;
            // 
            // _txtFechaEgreso
            // 
            this._txtFechaEgreso.Location = new System.Drawing.Point(630, 164);
            this._txtFechaEgreso.Name = "_txtFechaEgreso";
            this._txtFechaEgreso.Size = new System.Drawing.Size(100, 22);
            this._txtFechaEgreso.TabIndex = 20;
            // 
            // _txtFechaIngreso
            // 
            this._txtFechaIngreso.Location = new System.Drawing.Point(489, 164);
            this._txtFechaIngreso.Name = "_txtFechaIngreso";
            this._txtFechaIngreso.Size = new System.Drawing.Size(100, 22);
            this._txtFechaIngreso.TabIndex = 16;
            // 
            // _txtNumeroDeHuespedes
            // 
            this._txtNumeroDeHuespedes.Location = new System.Drawing.Point(364, 164);
            this._txtNumeroDeHuespedes.Name = "_txtNumeroDeHuespedes";
            this._txtNumeroDeHuespedes.Size = new System.Drawing.Size(100, 22);
            this._txtNumeroDeHuespedes.TabIndex = 15;
            // 
            // _txtIdHabitacion
            // 
            this._txtIdHabitacion.Location = new System.Drawing.Point(224, 164);
            this._txtIdHabitacion.Name = "_txtIdHabitacion";
            this._txtIdHabitacion.Size = new System.Drawing.Size(100, 22);
            this._txtIdHabitacion.TabIndex = 14;
            // 
            // _txtIDCliente
            // 
            this._txtIDCliente.Location = new System.Drawing.Point(118, 164);
            this._txtIDCliente.Name = "_txtIDCliente";
            this._txtIDCliente.Size = new System.Drawing.Size(100, 22);
            this._txtIDCliente.TabIndex = 13;
            // 
            // ReservaID
            // 
            this.ReservaID.Location = new System.Drawing.Point(58, 164);
            this.ReservaID.Name = "ReservaID";
            this.ReservaID.Size = new System.Drawing.Size(29, 22);
            this.ReservaID.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID CLIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "ID HABITACION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "NRO. HUESPEDES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "FECHA INGRESO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "FECHA EGRESO";
            // 
            // FrmConsultaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtFechaEgreso);
            this.Controls.Add(this._txtFechaIngreso);
            this.Controls.Add(this._txtNumeroDeHuespedes);
            this.Controls.Add(this._txtIdHabitacion);
            this.Controls.Add(this._txtIDCliente);
            this.Controls.Add(this.ReservaID);
            this.Controls.Add(this._lblIDReserva);
            this.Controls.Add(this._btnBuscarPorIdReserva);
            this.Controls.Add(this._txtIdReserva);
            this.Name = "FrmConsultaReserva";
            this.Text = "FrmConsultaReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblIDReserva;
        private System.Windows.Forms.Button _btnBuscarPorIdReserva;
        private System.Windows.Forms.TextBox _txtIdReserva;
        private System.Windows.Forms.TextBox _txtFechaEgreso;
        private System.Windows.Forms.TextBox _txtFechaIngreso;
        private System.Windows.Forms.TextBox _txtNumeroDeHuespedes;
        private System.Windows.Forms.TextBox _txtIdHabitacion;
        private System.Windows.Forms.TextBox _txtIDCliente;
        private System.Windows.Forms.TextBox ReservaID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}