
namespace TPHotel.InterfazFormuario
{
    partial class FrmConsultarHoteles
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._TxtNombreHotel = new System.Windows.Forms.TextBox();
            this._txtDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._btnConsulta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 22);
            this.textBox1.TabIndex = 0;
            // 
            // _TxtNombreHotel
            // 
            this._TxtNombreHotel.Location = new System.Drawing.Point(91, 124);
            this._TxtNombreHotel.Name = "_TxtNombreHotel";
            this._TxtNombreHotel.Size = new System.Drawing.Size(100, 22);
            this._TxtNombreHotel.TabIndex = 1;
            // 
            // _txtDireccion
            // 
            this._txtDireccion.Location = new System.Drawing.Point(91, 163);
            this._txtDireccion.Name = "_txtDireccion";
            this._txtDireccion.Size = new System.Drawing.Size(100, 22);
            this._txtDireccion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Reserva";
            // 
            // _btnConsulta
            // 
            this._btnConsulta.Location = new System.Drawing.Point(108, 210);
            this._btnConsulta.Name = "_btnConsulta";
            this._btnConsulta.Size = new System.Drawing.Size(75, 23);
            this._btnConsulta.TabIndex = 4;
            this._btnConsulta.Text = "Consultar";
            this._btnConsulta.UseVisualStyleBackColor = true;
            this._btnConsulta.Click += new System.EventHandler(this._btnConsulta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Direccion";
            // 
            // FrmConsultarHoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 283);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._btnConsulta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtDireccion);
            this.Controls.Add(this._TxtNombreHotel);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmConsultarHoteles";
            this.Text = "FrmConsultarHoteles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox _TxtNombreHotel;
        private System.Windows.Forms.TextBox _txtDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}