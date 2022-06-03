
namespace TPHotel.InterfazFormuario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this._btnIngresarConsultarReservas = new System.Windows.Forms.Button();
            this._btnIngresarConsultarClientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(559, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // _btnIngresarConsultarReservas
            // 
            this._btnIngresarConsultarReservas.Location = new System.Drawing.Point(294, 93);
            this._btnIngresarConsultarReservas.Name = "_btnIngresarConsultarReservas";
            this._btnIngresarConsultarReservas.Size = new System.Drawing.Size(127, 91);
            this._btnIngresarConsultarReservas.TabIndex = 3;
            this._btnIngresarConsultarReservas.Text = "Ingresar/consultar reservas";
            this._btnIngresarConsultarReservas.UseVisualStyleBackColor = true;
            this._btnIngresarConsultarReservas.Click += new System.EventHandler(this._btnIngresarConsultarReservas_Click);
            // 
            // _btnIngresarConsultarClientes
            // 
            this._btnIngresarConsultarClientes.Location = new System.Drawing.Point(134, 93);
            this._btnIngresarConsultarClientes.Name = "_btnIngresarConsultarClientes";
            this._btnIngresarConsultarClientes.Size = new System.Drawing.Size(131, 91);
            this._btnIngresarConsultarClientes.TabIndex = 4;
            this._btnIngresarConsultarClientes.Text = "Ingresar/consultar clientes";
            this._btnIngresarConsultarClientes.UseVisualStyleBackColor = true;
            this._btnIngresarConsultarClientes.Click += new System.EventHandler(this._btnIngresarConsultarClientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Estos botones son para los otras funcionalidades ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnIngresarConsultarClientes);
            this.Controls.Add(this._btnIngresarConsultarReservas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button _btnIngresarConsultarReservas;
        private System.Windows.Forms.Button _btnIngresarConsultarClientes;
        private System.Windows.Forms.Label label1;
    }
}

