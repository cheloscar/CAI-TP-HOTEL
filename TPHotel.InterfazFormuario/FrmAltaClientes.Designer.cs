
namespace TPHotel.InterfazFormuario
{
    partial class FrmAltaClientes
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
            this._txtId = new System.Windows.Forms.TextBox();
            this._txtFechaAlta = new System.Windows.Forms.TextBox();
            this._txtDireccion = new System.Windows.Forms.TextBox();
            this._txtApellido = new System.Windows.Forms.TextBox();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._lblId = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // _txtId
            // 
            this._txtId.BackColor = System.Drawing.Color.White;
            this._txtId.ForeColor = System.Drawing.Color.Black;
            this._txtId.Location = new System.Drawing.Point(200, 97);
            this._txtId.Name = "_txtId";
            this._txtId.Size = new System.Drawing.Size(100, 22);
            this._txtId.TabIndex = 1;
            this._txtId.TextChanged += new System.EventHandler(this._txtId_TextChanged);
            // 
            // _txtFechaAlta
            // 
            this._txtFechaAlta.Location = new System.Drawing.Point(200, 400);
            this._txtFechaAlta.Name = "_txtFechaAlta";
            this._txtFechaAlta.Size = new System.Drawing.Size(100, 22);
            this._txtFechaAlta.TabIndex = 2;
            // 
            // _txtDireccion
            // 
            this._txtDireccion.Location = new System.Drawing.Point(200, 213);
            this._txtDireccion.Name = "_txtDireccion";
            this._txtDireccion.Size = new System.Drawing.Size(100, 22);
            this._txtDireccion.TabIndex = 4;
            this._txtDireccion.TextChanged += new System.EventHandler(this._txtDireccion_TextChanged);
            // 
            // _txtApellido
            // 
            this._txtApellido.Location = new System.Drawing.Point(200, 183);
            this._txtApellido.Name = "_txtApellido";
            this._txtApellido.Size = new System.Drawing.Size(100, 22);
            this._txtApellido.TabIndex = 5;
            this._txtApellido.TextChanged += new System.EventHandler(this._txtApellido_TextChanged);
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(200, 155);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(100, 22);
            this._txtNombre.TabIndex = 6;
            this._txtNombre.TextChanged += new System.EventHandler(this._txtNombre_TextChanged);
            // 
            // _lblId
            // 
            this._lblId.AutoSize = true;
            this._lblId.Location = new System.Drawing.Point(173, 97);
            this._lblId.Name = "_lblId";
            this._lblId.Size = new System.Drawing.Size(21, 17);
            this._lblId.TabIndex = 7;
            this._lblId.Text = "ID";
            // 
            // _lblFechaAlta
            // 
            this._lblFechaAlta.AutoSize = true;
            this._lblFechaAlta.Location = new System.Drawing.Point(92, 403);
            this._lblFechaAlta.Name = "_lblFechaAlta";
            this._lblFechaAlta.Size = new System.Drawing.Size(92, 17);
            this._lblFechaAlta.TabIndex = 8;
            this._lblFechaAlta.Text = "FECHA ALTA";
            // 
            // _lblNombre
            // 
            this._lblNombre.AutoSize = true;
            this._lblNombre.Location = new System.Drawing.Point(127, 158);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(68, 17);
            this._lblNombre.TabIndex = 10;
            this._lblNombre.Text = "NOMBRE";
            // 
            // _lblApellido
            // 
            this._lblApellido.AutoSize = true;
            this._lblApellido.Location = new System.Drawing.Point(119, 186);
            this._lblApellido.Name = "_lblApellido";
            this._lblApellido.Size = new System.Drawing.Size(75, 17);
            this._lblApellido.TabIndex = 11;
            this._lblApellido.Text = "APELLIDO";
            // 
            // _lblDireccion
            // 
            this._lblDireccion.AutoSize = true;
            this._lblDireccion.Location = new System.Drawing.Point(112, 213);
            this._lblDireccion.Name = "_lblDireccion";
            this._lblDireccion.Size = new System.Drawing.Size(82, 17);
            this._lblDireccion.TabIndex = 12;
            this._lblDireccion.Text = "DIRECCION";
            // 
            // _txtTelefono
            // 
            this._txtTelefono.Location = new System.Drawing.Point(200, 241);
            this._txtTelefono.Name = "_txtTelefono";
            this._txtTelefono.Size = new System.Drawing.Size(100, 22);
            this._txtTelefono.TabIndex = 13;
            this._txtTelefono.TextChanged += new System.EventHandler(this._txtTelefono_TextChanged);
            // 
            // _lblTelefono
            // 
            this._lblTelefono.AutoSize = true;
            this._lblTelefono.Location = new System.Drawing.Point(112, 241);
            this._lblTelefono.Name = "_lblTelefono";
            this._lblTelefono.Size = new System.Drawing.Size(83, 17);
            this._lblTelefono.TabIndex = 14;
            this._lblTelefono.Text = "TELEFONO";
            // 
            // _txtEmail
            // 
            this._txtEmail.Location = new System.Drawing.Point(200, 271);
            this._txtEmail.Name = "_txtEmail";
            this._txtEmail.Size = new System.Drawing.Size(100, 22);
            this._txtEmail.TabIndex = 15;
            this._txtEmail.TextChanged += new System.EventHandler(this._txtEmail_TextChanged);
            // 
            // _lblEmail
            // 
            this._lblEmail.AutoSize = true;
            this._lblEmail.Location = new System.Drawing.Point(146, 271);
            this._lblEmail.Name = "_lblEmail";
            this._lblEmail.Size = new System.Drawing.Size(48, 17);
            this._lblEmail.TabIndex = 16;
            this._lblEmail.Text = "EMAIL";
            // 
            // _txtFechaNacimiento
            // 
            this._txtFechaNacimiento.Location = new System.Drawing.Point(200, 299);
            this._txtFechaNacimiento.Name = "_txtFechaNacimiento";
            this._txtFechaNacimiento.Size = new System.Drawing.Size(100, 22);
            this._txtFechaNacimiento.TabIndex = 17;
            this._txtFechaNacimiento.TextChanged += new System.EventHandler(this._txtFechaNacimiento_TextChanged);
            // 
            // _lblFechaDeNacimiento
            // 
            this._lblFechaDeNacimiento.AutoSize = true;
            this._lblFechaDeNacimiento.Location = new System.Drawing.Point(31, 299);
            this._lblFechaDeNacimiento.Name = "_lblFechaDeNacimiento";
            this._lblFechaDeNacimiento.Size = new System.Drawing.Size(164, 17);
            this._lblFechaDeNacimiento.TabIndex = 18;
            this._lblFechaDeNacimiento.Text = "FECHA DE NACIMIENTO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 90);
            this.button1.TabIndex = 19;
            this.button1.Text = "Dar de alta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _chkActivo
            // 
            this._chkActivo.AutoSize = true;
            this._chkActivo.Location = new System.Drawing.Point(191, 348);
            this._chkActivo.Name = "_chkActivo";
            this._chkActivo.Size = new System.Drawing.Size(141, 21);
            this._chkActivo.TabIndex = 20;
            this._chkActivo.Text = "CLIENTE ACTIVO";
            this._chkActivo.UseVisualStyleBackColor = true;
            // 
            // FrmAltaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 598);
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
            this.Controls.Add(this._lblId);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this._txtApellido);
            this.Controls.Add(this._txtDireccion);
            this.Controls.Add(this._txtFechaAlta);
            this.Controls.Add(this._txtId);
            this.Name = "FrmAltaClientes";
            this.Text = "FormIngresarClientes";
            this.Load += new System.EventHandler(this.FormIngresarConsultarClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox _txtId;
        private System.Windows.Forms.TextBox _txtFechaAlta;
        private System.Windows.Forms.TextBox _txtDireccion;
        private System.Windows.Forms.TextBox _txtApellido;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.Label _lblId;
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
    }
}