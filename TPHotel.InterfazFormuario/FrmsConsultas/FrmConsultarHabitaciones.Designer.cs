
namespace TPHotel.InterfazFormuario
{
    partial class FrmConsultarHabitaciones
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._txtHabNmbr = new System.Windows.Forms.TextBox();
            this._txtEstrellas = new System.Windows.Forms.TextBox();
            this._txtIdHabitacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._lstHabitaciones = new System.Windows.Forms.ListBox();
            this._cmbHotel = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(36, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(831, 558);
            this.groupBox2.TabIndex = 6;
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
            // _lstHabitaciones
            // 
            this._lstHabitaciones.FormattingEnabled = true;
            this._lstHabitaciones.ItemHeight = 24;
            this._lstHabitaciones.Location = new System.Drawing.Point(8, 147);
            this._lstHabitaciones.Margin = new System.Windows.Forms.Padding(4);
            this._lstHabitaciones.Name = "_lstHabitaciones";
            this._lstHabitaciones.Size = new System.Drawing.Size(815, 124);
            this._lstHabitaciones.TabIndex = 3;
            // 
            // _cmbHotel
            // 
            this._cmbHotel.FormattingEnabled = true;
            this._cmbHotel.Location = new System.Drawing.Point(8, 82);
            this._cmbHotel.Margin = new System.Windows.Forms.Padding(4);
            this._cmbHotel.Name = "_cmbHotel";
            this._cmbHotel.Size = new System.Drawing.Size(815, 32);
            this._cmbHotel.TabIndex = 2;
            this._cmbHotel.SelectionChangeCommitted += new System.EventHandler(this._cmbHotel_SelectionChangeCommitted);
            // 
            // FrmConsultarHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(897, 612);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConsultarHabitaciones";
            this.Text = "Consultar Habitaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConsultarHoteles_FormClosing);
            this.Load += new System.EventHandler(this.FrmConsultarHoteles_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox _txtHabNmbr;
        private System.Windows.Forms.TextBox _txtEstrellas;
        private System.Windows.Forms.TextBox _txtIdHabitacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox _lstHabitaciones;
        private System.Windows.Forms.ComboBox _cmbHotel;
    }
}