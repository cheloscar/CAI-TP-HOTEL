
namespace TPHotel.InterfazFormuario
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.MenuTiraAltas = new System.Windows.Forms.ToolStripMenuItem();
            this.Clientes_MenuTiraAltas = new System.Windows.Forms.ToolStripMenuItem();
            this.Reservas_MenuTiraAltas = new System.Windows.Forms.ToolStripMenuItem();
            this.Hoteles_MenuTiraAltas = new System.Windows.Forms.ToolStripMenuItem();
            this.Habitaciones_MenuTiraAltas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTiraConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.Clientes_MenuTiraConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.Hoteles_MenuTiraConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.Habitaciones_MenuTiraConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.Informes_MenuTiraConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 40);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTiraAltas,
            this.MenuTiraConsultas});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(764, 40);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // MenuTiraAltas
            // 
            this.MenuTiraAltas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Clientes_MenuTiraAltas,
            this.Reservas_MenuTiraAltas,
            this.Hoteles_MenuTiraAltas,
            this.Habitaciones_MenuTiraAltas});
            this.MenuTiraAltas.Image = global::TPHotel.InterfazFormuario.Properties.Resources.Arriba;
            this.MenuTiraAltas.Name = "MenuTiraAltas";
            this.MenuTiraAltas.Size = new System.Drawing.Size(97, 34);
            this.MenuTiraAltas.Text = "Altas";
            // 
            // Clientes_MenuTiraAltas
            // 
            this.Clientes_MenuTiraAltas.AccessibleName = "Clientes_MenuTiraAltas";
            this.Clientes_MenuTiraAltas.Name = "Clientes_MenuTiraAltas";
            this.Clientes_MenuTiraAltas.Size = new System.Drawing.Size(251, 40);
            this.Clientes_MenuTiraAltas.Text = "Clientes";
            this.Clientes_MenuTiraAltas.Click += new System.EventHandler(this.Cliente_MenuTiraAltas_Click);
            // 
            // Reservas_MenuTiraAltas
            // 
            this.Reservas_MenuTiraAltas.AccessibleName = "Reservas_MenuTiraAltas";
            this.Reservas_MenuTiraAltas.Name = "Reservas_MenuTiraAltas";
            this.Reservas_MenuTiraAltas.Size = new System.Drawing.Size(251, 40);
            this.Reservas_MenuTiraAltas.Text = "Reservas";
            this.Reservas_MenuTiraAltas.Click += new System.EventHandler(this.Reserva_MenuTiraAltas_Click);
            // 
            // Hoteles_MenuTiraAltas
            // 
            this.Hoteles_MenuTiraAltas.AccessibleName = "Hoteles_MenuTiraAltas";
            this.Hoteles_MenuTiraAltas.Name = "Hoteles_MenuTiraAltas";
            this.Hoteles_MenuTiraAltas.Size = new System.Drawing.Size(251, 40);
            this.Hoteles_MenuTiraAltas.Text = "Hoteles";
            this.Hoteles_MenuTiraAltas.Click += new System.EventHandler(this.Hotel_MenuTiraAltas_Click);
            // 
            // Habitaciones_MenuTiraAltas
            // 
            this.Habitaciones_MenuTiraAltas.AccessibleName = "Habitaciones_MenuTiraAltas";
            this.Habitaciones_MenuTiraAltas.Name = "Habitaciones_MenuTiraAltas";
            this.Habitaciones_MenuTiraAltas.Size = new System.Drawing.Size(251, 40);
            this.Habitaciones_MenuTiraAltas.Text = "Habitaciones";
            this.Habitaciones_MenuTiraAltas.Click += new System.EventHandler(this.Habitacion_MenuTiraAltas_Click);
            // 
            // MenuTiraConsultas
            // 
            this.MenuTiraConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Clientes_MenuTiraConsultas,
            this.Hoteles_MenuTiraConsultas,
            this.Habitaciones_MenuTiraConsultas,
            this.Informes_MenuTiraConsultas});
            this.MenuTiraConsultas.Image = global::TPHotel.InterfazFormuario.Properties.Resources.Signo_de_pregunta;
            this.MenuTiraConsultas.Name = "MenuTiraConsultas";
            this.MenuTiraConsultas.Size = new System.Drawing.Size(141, 34);
            this.MenuTiraConsultas.Text = "Consultas";
            // 
            // Clientes_MenuTiraConsultas
            // 
            this.Clientes_MenuTiraConsultas.AccessibleName = "Clientes_MenuTiraConsultas";
            this.Clientes_MenuTiraConsultas.Name = "Clientes_MenuTiraConsultas";
            this.Clientes_MenuTiraConsultas.Size = new System.Drawing.Size(251, 40);
            this.Clientes_MenuTiraConsultas.Text = "Clientes";
            this.Clientes_MenuTiraConsultas.Click += new System.EventHandler(this.Clientes_MenuTiraConsultas_Click);
            // 
            // Hoteles_MenuTiraConsultas
            // 
            this.Hoteles_MenuTiraConsultas.AccessibleName = "Hoteles_MenuTiraConsultas";
            this.Hoteles_MenuTiraConsultas.Name = "Hoteles_MenuTiraConsultas";
            this.Hoteles_MenuTiraConsultas.Size = new System.Drawing.Size(251, 40);
            this.Hoteles_MenuTiraConsultas.Text = "Hoteles";
            this.Hoteles_MenuTiraConsultas.Click += new System.EventHandler(this.Hoteles_MenuTiraConsultas_Click);
            // 
            // Habitaciones_MenuTiraConsultas
            // 
            this.Habitaciones_MenuTiraConsultas.AccessibleName = "Habitaciones_MenuTiraConsultas";
            this.Habitaciones_MenuTiraConsultas.Name = "Habitaciones_MenuTiraConsultas";
            this.Habitaciones_MenuTiraConsultas.Size = new System.Drawing.Size(251, 40);
            this.Habitaciones_MenuTiraConsultas.Text = "Habitaciones";
            this.Habitaciones_MenuTiraConsultas.Click += new System.EventHandler(this.Habitaciones_MenuTiraConsultas_Click);
            // 
            // Informes_MenuTiraConsultas
            // 
            this.Informes_MenuTiraConsultas.Name = "Informes_MenuTiraConsultas";
            this.Informes_MenuTiraConsultas.Size = new System.Drawing.Size(251, 40);
            this.Informes_MenuTiraConsultas.Text = "Informes";
            this.Informes_MenuTiraConsultas.Click += new System.EventHandler(this.Informes_MenuTiraConsultas_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TPHotel.InterfazFormuario.Properties.Resources.Texan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 675);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "Sistema de gestión de hoteles";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem MenuTiraAltas;
        private System.Windows.Forms.ToolStripMenuItem Clientes_MenuTiraAltas;
        private System.Windows.Forms.ToolStripMenuItem Reservas_MenuTiraAltas;
        private System.Windows.Forms.ToolStripMenuItem Hoteles_MenuTiraAltas;
        private System.Windows.Forms.ToolStripMenuItem Habitaciones_MenuTiraAltas;
        private System.Windows.Forms.ToolStripMenuItem MenuTiraConsultas;
        private System.Windows.Forms.ToolStripMenuItem Clientes_MenuTiraConsultas;
        private System.Windows.Forms.ToolStripMenuItem Hoteles_MenuTiraConsultas;
        private System.Windows.Forms.ToolStripMenuItem Habitaciones_MenuTiraConsultas;
        private System.Windows.Forms.ToolStripMenuItem Informes_MenuTiraConsultas;
    }
}

