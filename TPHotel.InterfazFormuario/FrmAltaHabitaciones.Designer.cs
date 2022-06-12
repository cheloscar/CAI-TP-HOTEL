
namespace TPHotel.InterfazFormuario
{
    partial class FrmAltaHabitaciones
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
            this._txtIdHabitacion = new System.Windows.Forms.TextBox();
            this._cmbIdHotel = new System.Windows.Forms.ComboBox();
            this._txtCantidadPlazas = new System.Windows.Forms.TextBox();
            this._txtCategoria = new System.Windows.Forms.TextBox();
            this._txtPrecio = new System.Windows.Forms.TextBox();
            this._lblIdHabitacion = new System.Windows.Forms.Label();
            this._lblidHotel = new System.Windows.Forms.Label();
            this._lblCantidadPlazas = new System.Windows.Forms.Label();
            this._lblCategoria = new System.Windows.Forms.Label();
            this._lblcCancelable = new System.Windows.Forms.Label();
            this._chkCancelable = new System.Windows.Forms.CheckBox();
            this._btnAlta = new System.Windows.Forms.Button();
            this._lblPrecio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _txtIdHabitacion
            // 
            this._txtIdHabitacion.Location = new System.Drawing.Point(173, 65);
            this._txtIdHabitacion.Name = "_txtIdHabitacion";
            this._txtIdHabitacion.Size = new System.Drawing.Size(100, 22);
            this._txtIdHabitacion.TabIndex = 0;
            // 
            // _cmbIdHotel
            // 
            this._cmbIdHotel.FormattingEnabled = true;
            this._cmbIdHotel.Location = new System.Drawing.Point(173, 103);
            this._cmbIdHotel.Name = "_cmbIdHotel";
            this._cmbIdHotel.Size = new System.Drawing.Size(100, 24);
            this._cmbIdHotel.TabIndex = 1;
            // 
            // _txtCantidadPlazas
            // 
            this._txtCantidadPlazas.Location = new System.Drawing.Point(173, 147);
            this._txtCantidadPlazas.Name = "_txtCantidadPlazas";
            this._txtCantidadPlazas.Size = new System.Drawing.Size(100, 22);
            this._txtCantidadPlazas.TabIndex = 2;
            // 
            // _txtCategoria
            // 
            this._txtCategoria.Location = new System.Drawing.Point(173, 192);
            this._txtCategoria.Name = "_txtCategoria";
            this._txtCategoria.Size = new System.Drawing.Size(100, 22);
            this._txtCategoria.TabIndex = 3;
            // 
            // _txtPrecio
            // 
            this._txtPrecio.Location = new System.Drawing.Point(173, 233);
            this._txtPrecio.Name = "_txtPrecio";
            this._txtPrecio.Size = new System.Drawing.Size(100, 22);
            this._txtPrecio.TabIndex = 5;
            // 
            // _lblIdHabitacion
            // 
            this._lblIdHabitacion.AutoSize = true;
            this._lblIdHabitacion.Location = new System.Drawing.Point(119, 70);
            this._lblIdHabitacion.Name = "_lblIdHabitacion";
            this._lblIdHabitacion.Size = new System.Drawing.Size(21, 17);
            this._lblIdHabitacion.TabIndex = 6;
            this._lblIdHabitacion.Text = "ID";
            // 
            // _lblidHotel
            // 
            this._lblidHotel.AutoSize = true;
            this._lblidHotel.Location = new System.Drawing.Point(81, 110);
            this._lblidHotel.Name = "_lblidHotel";
            this._lblidHotel.Size = new System.Drawing.Size(72, 17);
            this._lblidHotel.TabIndex = 7;
            this._lblidHotel.Text = "ID HOTEL";
            // 
            // _lblCantidadPlazas
            // 
            this._lblCantidadPlazas.AutoSize = true;
            this._lblCantidadPlazas.Location = new System.Drawing.Point(-4, 150);
            this._lblCantidadPlazas.Name = "_lblCantidadPlazas";
            this._lblCantidadPlazas.Size = new System.Drawing.Size(157, 17);
            this._lblCantidadPlazas.TabIndex = 8;
            this._lblCantidadPlazas.Text = "CANTIDAD DE PLAZAS";
            // 
            // _lblCategoria
            // 
            this._lblCategoria.AutoSize = true;
            this._lblCategoria.Location = new System.Drawing.Point(65, 195);
            this._lblCategoria.Name = "_lblCategoria";
            this._lblCategoria.Size = new System.Drawing.Size(88, 17);
            this._lblCategoria.TabIndex = 9;
            this._lblCategoria.Text = "CATEGORIA";
            // 
            // _lblcCancelable
            // 
            this._lblcCancelable.AutoSize = true;
            this._lblcCancelable.Location = new System.Drawing.Point(119, 289);
            this._lblcCancelable.Name = "_lblcCancelable";
            this._lblcCancelable.Size = new System.Drawing.Size(97, 17);
            this._lblcCancelable.TabIndex = 11;
            this._lblcCancelable.Text = "CANCELABLE";
            // 
            // _chkCancelable
            // 
            this._chkCancelable.AutoSize = true;
            this._chkCancelable.Location = new System.Drawing.Point(220, 289);
            this._chkCancelable.Name = "_chkCancelable";
            this._chkCancelable.Size = new System.Drawing.Size(18, 17);
            this._chkCancelable.TabIndex = 12;
            this._chkCancelable.UseVisualStyleBackColor = true;
            // 
            // _btnAlta
            // 
            this._btnAlta.Location = new System.Drawing.Point(198, 343);
            this._btnAlta.Name = "_btnAlta";
            this._btnAlta.Size = new System.Drawing.Size(75, 23);
            this._btnAlta.TabIndex = 13;
            this._btnAlta.Text = "ALTA";
            this._btnAlta.UseVisualStyleBackColor = true;
            this._btnAlta.Click += new System.EventHandler(this._btnAlta_Click);
            // 
            // _lblPrecio
            // 
            this._lblPrecio.AutoSize = true;
            this._lblPrecio.Location = new System.Drawing.Point(94, 238);
            this._lblPrecio.Name = "_lblPrecio";
            this._lblPrecio.Size = new System.Drawing.Size(59, 17);
            this._lblPrecio.TabIndex = 14;
            this._lblPrecio.Text = "PRECIO";
            // 
            // FrmAltaHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 450);
            this.Controls.Add(this._lblPrecio);
            this.Controls.Add(this._btnAlta);
            this.Controls.Add(this._chkCancelable);
            this.Controls.Add(this._lblcCancelable);
            this.Controls.Add(this._lblCategoria);
            this.Controls.Add(this._lblCantidadPlazas);
            this.Controls.Add(this._lblidHotel);
            this.Controls.Add(this._lblIdHabitacion);
            this.Controls.Add(this._txtPrecio);
            this.Controls.Add(this._txtCategoria);
            this.Controls.Add(this._txtCantidadPlazas);
            this.Controls.Add(this._cmbIdHotel);
            this.Controls.Add(this._txtIdHabitacion);
            this.Name = "FrmAltaHabitaciones";
            this.Text = "FrmHabitaciones";
            this.Load += new System.EventHandler(this.FrmAltaHabitaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtIdHabitacion;
        private System.Windows.Forms.ComboBox _cmbIdHotel;
        private System.Windows.Forms.TextBox _txtCantidadPlazas;
        private System.Windows.Forms.TextBox _txtCategoria;
        private System.Windows.Forms.TextBox _txtPrecio;
        private System.Windows.Forms.Label _lblIdHabitacion;
        private System.Windows.Forms.Label _lblidHotel;
        private System.Windows.Forms.Label _lblCantidadPlazas;
        private System.Windows.Forms.Label _lblCategoria;
        private System.Windows.Forms.Label _lblcCancelable;
        private System.Windows.Forms.CheckBox _chkCancelable;
        private System.Windows.Forms.Button _btnAlta;
        private System.Windows.Forms.Label _lblPrecio;
    }
}