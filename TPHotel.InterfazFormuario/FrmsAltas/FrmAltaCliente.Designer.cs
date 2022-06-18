
namespace TPHotel.InterfazFormuario
{
    partial class FrmAltaCliente
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
            this._txtFechaAlta = new System.Windows.Forms.TextBox();
            this._txtDireccion = new System.Windows.Forms.TextBox();
            this._txtApellido = new System.Windows.Forms.TextBox();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._lblFechaAlta = new System.Windows.Forms.Label();
            this._lblNombre = new System.Windows.Forms.Label();
            this._lblApellido = new System.Windows.Forms.Label();
            this._lblDireccion = new System.Windows.Forms.Label();
            this._txtTelefono = new System.Windows.Forms.TextBox();
            this._lblTelefono = new System.Windows.Forms.Label();
            this._txtEmail = new System.Windows.Forms.TextBox();
            this._lblEmail = new System.Windows.Forms.Label();
            this._txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this._lblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this._chkActivo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _txtFechaAlta
            // 
            this._txtFechaAlta.Location = new System.Drawing.Point(275, 600);
            this._txtFechaAlta.Margin = new System.Windows.Forms.Padding(4);
            this._txtFechaAlta.Name = "_txtFechaAlta";
            this._txtFechaAlta.Size = new System.Drawing.Size(136, 29);
            this._txtFechaAlta.TabIndex = 9;
            // 
            // _txtDireccion
            // 
            this._txtDireccion.Location = new System.Drawing.Point(275, 320);
            this._txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this._txtDireccion.Name = "_txtDireccion";
            this._txtDireccion.Size = new System.Drawing.Size(136, 29);
            this._txtDireccion.TabIndex = 3;
            this._txtDireccion.TextChanged += new System.EventHandler(this._txtDireccion_TextChanged);
            // 
            // _txtApellido
            // 
            this._txtApellido.Location = new System.Drawing.Point(275, 274);
            this._txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this._txtApellido.Name = "_txtApellido";
            this._txtApellido.Size = new System.Drawing.Size(136, 29);
            this._txtApellido.TabIndex = 2;
            this._txtApellido.TextChanged += new System.EventHandler(this._txtApellido_TextChanged);
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(275, 232);
            this._txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(136, 29);
            this._txtNombre.TabIndex = 1;
            this._txtNombre.TextChanged += new System.EventHandler(this._txtNombre_TextChanged);
            // 
            // _lblFechaAlta
            // 
            this._lblFechaAlta.AutoSize = true;
            this._lblFechaAlta.Location = new System.Drawing.Point(126, 604);
            this._lblFechaAlta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblFechaAlta.Name = "_lblFechaAlta";
            this._lblFechaAlta.Size = new System.Drawing.Size(137, 25);
            this._lblFechaAlta.TabIndex = 8;
            this._lblFechaAlta.Text = "FECHA ALTA";
            // 
            // _lblNombre
            // 
            this._lblNombre.AutoSize = true;
            this._lblNombre.Location = new System.Drawing.Point(175, 237);
            this._lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(98, 25);
            this._lblNombre.TabIndex = 10;
            this._lblNombre.Text = "NOMBRE";
            // 
            // _lblApellido
            // 
            this._lblApellido.AutoSize = true;
            this._lblApellido.Location = new System.Drawing.Point(164, 279);
            this._lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblApellido.Name = "_lblApellido";
            this._lblApellido.Size = new System.Drawing.Size(109, 25);
            this._lblApellido.TabIndex = 11;
            this._lblApellido.Text = "APELLIDO";
            // 
            // _lblDireccion
            // 
            this._lblDireccion.AutoSize = true;
            this._lblDireccion.Location = new System.Drawing.Point(154, 320);
            this._lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblDireccion.Name = "_lblDireccion";
            this._lblDireccion.Size = new System.Drawing.Size(122, 25);
            this._lblDireccion.TabIndex = 12;
            this._lblDireccion.Text = "DIRECCION";
            // 
            // _txtTelefono
            // 
            this._txtTelefono.Location = new System.Drawing.Point(275, 362);
            this._txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this._txtTelefono.Name = "_txtTelefono";
            this._txtTelefono.Size = new System.Drawing.Size(136, 29);
            this._txtTelefono.TabIndex = 4;
            this._txtTelefono.TextChanged += new System.EventHandler(this._txtTelefono_TextChanged);
            // 
            // _lblTelefono
            // 
            this._lblTelefono.AutoSize = true;
            this._lblTelefono.Location = new System.Drawing.Point(154, 362);
            this._lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblTelefono.Name = "_lblTelefono";
            this._lblTelefono.Size = new System.Drawing.Size(120, 25);
            this._lblTelefono.TabIndex = 14;
            this._lblTelefono.Text = "TELEFONO";
            // 
            // _txtEmail
            // 
            this._txtEmail.Location = new System.Drawing.Point(275, 406);
            this._txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this._txtEmail.Name = "_txtEmail";
            this._txtEmail.Size = new System.Drawing.Size(136, 29);
            this._txtEmail.TabIndex = 5;
            this._txtEmail.TextChanged += new System.EventHandler(this._txtEmail_TextChanged);
            // 
            // _lblEmail
            // 
            this._lblEmail.AutoSize = true;
            this._lblEmail.Location = new System.Drawing.Point(201, 406);
            this._lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblEmail.Name = "_lblEmail";
            this._lblEmail.Size = new System.Drawing.Size(72, 25);
            this._lblEmail.TabIndex = 16;
            this._lblEmail.Text = "EMAIL";
            // 
            // _txtFechaNacimiento
            // 
            this._txtFechaNacimiento.Location = new System.Drawing.Point(275, 448);
            this._txtFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this._txtFechaNacimiento.Name = "_txtFechaNacimiento";
            this._txtFechaNacimiento.Size = new System.Drawing.Size(136, 29);
            this._txtFechaNacimiento.TabIndex = 6;
            this._txtFechaNacimiento.TextChanged += new System.EventHandler(this._txtFechaNacimiento_TextChanged);
            // 
            // _lblFechaDeNacimiento
            // 
            this._lblFechaDeNacimiento.AutoSize = true;
            this._lblFechaDeNacimiento.Location = new System.Drawing.Point(43, 448);
            this._lblFechaDeNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblFechaDeNacimiento.Name = "_lblFechaDeNacimiento";
            this._lblFechaDeNacimiento.Size = new System.Drawing.Size(243, 25);
            this._lblFechaDeNacimiento.TabIndex = 18;
            this._lblFechaDeNacimiento.Text = "FECHA DE NACIMIENTO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 232);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 135);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dar de alta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _chkActivo
            // 
            this._chkActivo.AutoSize = true;
            this._chkActivo.Location = new System.Drawing.Point(263, 522);
            this._chkActivo.Margin = new System.Windows.Forms.Padding(4);
            this._chkActivo.Name = "_chkActivo";
            this._chkActivo.Size = new System.Drawing.Size(204, 29);
            this._chkActivo.TabIndex = 7;
            this._chkActivo.TabStop = false;
            this._chkActivo.Text = "CLIENTE ACTIVO";
            this._chkActivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Formato: \"YYYY-MM-DD\"";
            // 
            // FrmAltaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 897);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._chkActivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this._lblFechaDeNacimiento);
            this.Controls.Add(this._txtFechaNacimiento);
            this.Controls.Add(this._lblEmail);
            this.Controls.Add(this._txtEmail);
            this.Controls.Add(this._lblTelefono);
            this.Controls.Add(this._txtTelefono);
            this.Controls.Add(this._lblDireccion);
            this.Controls.Add(this._lblApellido);
            this.Controls.Add(this._lblNombre);
            this.Controls.Add(this._lblFechaAlta);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this._txtApellido);
            this.Controls.Add(this._txtDireccion);
            this.Controls.Add(this._txtFechaAlta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAltaClientes";
            this.Text = "Ingreso de clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAltaClientes_FormClosing);
            this.Load += new System.EventHandler(this.FormIngresarConsultarClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox _txtFechaAlta;
        private System.Windows.Forms.TextBox _txtDireccion;
        private System.Windows.Forms.TextBox _txtApellido;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.Label _lblFechaAlta;
        private System.Windows.Forms.Label _lblNombre;
        private System.Windows.Forms.Label _lblApellido;
        private System.Windows.Forms.Label _lblDireccion;
        private System.Windows.Forms.TextBox _txtTelefono;
        private System.Windows.Forms.Label _lblTelefono;
        private System.Windows.Forms.TextBox _txtEmail;
        private System.Windows.Forms.Label _lblEmail;
        private System.Windows.Forms.TextBox _txtFechaNacimiento;
        private System.Windows.Forms.Label _lblFechaDeNacimiento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox _chkActivo;
        private System.Windows.Forms.Label label1;
    }
}