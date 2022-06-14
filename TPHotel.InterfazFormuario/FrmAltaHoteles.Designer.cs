
namespace TPHotel.InterfazFormuario
{
    partial class FrmAltaHoteles
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
            this._btnAlta = new System.Windows.Forms.Button();
            this._txtEstrellas = new System.Windows.Forms.TextBox();
            this._txtId = new System.Windows.Forms.TextBox();
            this._txtDireccion = new System.Windows.Forms.TextBox();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._lblEstrellas = new System.Windows.Forms.Label();
            this._lblNombre = new System.Windows.Forms.Label();
            this._lblDireccion = new System.Windows.Forms.Label();
            this._lblAmenities = new System.Windows.Forms.Label();
            this._lblId = new System.Windows.Forms.Label();
            this._chkAmenities = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // _btnAlta
            // 
            this._btnAlta.Location = new System.Drawing.Point(104, 297);
            this._btnAlta.Name = "_btnAlta";
            this._btnAlta.Size = new System.Drawing.Size(118, 78);
            this._btnAlta.TabIndex = 0;
            this._btnAlta.Text = "Alta";
            this._btnAlta.UseVisualStyleBackColor = true;
            this._btnAlta.Click += new System.EventHandler(this._btnAlta_Click);
            // 
            // _txtEstrellas
            // 
            this._txtEstrellas.Location = new System.Drawing.Point(122, 123);
            this._txtEstrellas.Name = "_txtEstrellas";
            this._txtEstrellas.Size = new System.Drawing.Size(100, 22);
            this._txtEstrellas.TabIndex = 1;
            // 
            // _txtId
            // 
            this._txtId.Location = new System.Drawing.Point(122, 217);
            this._txtId.Name = "_txtId";
            this._txtId.Size = new System.Drawing.Size(100, 22);
            this._txtId.TabIndex = 2;
            // 
            // _txtDireccion
            // 
            this._txtDireccion.Location = new System.Drawing.Point(122, 184);
            this._txtDireccion.Name = "_txtDireccion";
            this._txtDireccion.Size = new System.Drawing.Size(100, 22);
            this._txtDireccion.TabIndex = 4;
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(122, 151);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(100, 22);
            this._txtNombre.TabIndex = 5;
            // 
            // _lblEstrellas
            // 
            this._lblEstrellas.AutoSize = true;
            this._lblEstrellas.Location = new System.Drawing.Point(28, 123);
            this._lblEstrellas.Name = "_lblEstrellas";
            this._lblEstrellas.Size = new System.Drawing.Size(88, 17);
            this._lblEstrellas.TabIndex = 6;
            this._lblEstrellas.Text = "ESTRELLAS";
            // 
            // _lblNombre
            // 
            this._lblNombre.AutoSize = true;
            this._lblNombre.Location = new System.Drawing.Point(48, 154);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(68, 17);
            this._lblNombre.TabIndex = 7;
            this._lblNombre.Text = "NOMBRE";
            // 
            // _lblDireccion
            // 
            this._lblDireccion.AutoSize = true;
            this._lblDireccion.Location = new System.Drawing.Point(28, 187);
            this._lblDireccion.Name = "_lblDireccion";
            this._lblDireccion.Size = new System.Drawing.Size(82, 17);
            this._lblDireccion.TabIndex = 8;
            this._lblDireccion.Text = "DIRECCION";
            // 
            // _lblAmenities
            // 
            this._lblAmenities.AutoSize = true;
            this._lblAmenities.Location = new System.Drawing.Point(28, 250);
            this._lblAmenities.Name = "_lblAmenities";
            this._lblAmenities.Size = new System.Drawing.Size(80, 17);
            this._lblAmenities.TabIndex = 9;
            this._lblAmenities.Text = "AMENITIES";
            // 
            // _lblId
            // 
            this._lblId.AutoSize = true;
            this._lblId.Location = new System.Drawing.Point(80, 217);
            this._lblId.Name = "_lblId";
            this._lblId.Size = new System.Drawing.Size(21, 17);
            this._lblId.TabIndex = 10;
            this._lblId.Text = "ID";
            // 
            // _chkAmenities
            // 
            this._chkAmenities.AutoSize = true;
            this._chkAmenities.Location = new System.Drawing.Point(141, 251);
            this._chkAmenities.Name = "_chkAmenities";
            this._chkAmenities.Size = new System.Drawing.Size(18, 17);
            this._chkAmenities.TabIndex = 11;
            this._chkAmenities.UseVisualStyleBackColor = true;
            // 
            // FrmAltaHoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this._chkAmenities);
            this.Controls.Add(this._lblId);
            this.Controls.Add(this._lblAmenities);
            this.Controls.Add(this._lblDireccion);
            this.Controls.Add(this._lblNombre);
            this.Controls.Add(this._lblEstrellas);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this._txtDireccion);
            this.Controls.Add(this._txtId);
            this.Controls.Add(this._txtEstrellas);
            this.Controls.Add(this._btnAlta);
            this.Name = "FrmAltaHoteles";
            this.Text = "Ingreso de hoteles";
            this.Load += new System.EventHandler(this.FrmHoteles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnAlta;
        private System.Windows.Forms.TextBox _txtEstrellas;
        private System.Windows.Forms.TextBox _txtId;
        private System.Windows.Forms.TextBox _txtDireccion;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.Label _lblEstrellas;
        private System.Windows.Forms.Label _lblNombre;
        private System.Windows.Forms.Label _lblDireccion;
        private System.Windows.Forms.Label _lblAmenities;
        private System.Windows.Forms.Label _lblId;
        private System.Windows.Forms.CheckBox _chkAmenities;
    }
}