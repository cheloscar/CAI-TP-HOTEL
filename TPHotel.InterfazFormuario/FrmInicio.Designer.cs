namespace TPHotel.InterfazFormuario
{
    partial class FrmInicio
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
            this.lblIniciando = new System.Windows.Forms.Label();
            this.lblEspere = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIniciando
            // 
            this.lblIniciando.AutoSize = true;
            this.lblIniciando.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciando.Location = new System.Drawing.Point(126, 80);
            this.lblIniciando.Name = "lblIniciando";
            this.lblIniciando.Size = new System.Drawing.Size(416, 73);
            this.lblIniciando.TabIndex = 0;
            this.lblIniciando.Text = "Inicializando.";
            // 
            // lblEspere
            // 
            this.lblEspere.AutoSize = true;
            this.lblEspere.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspere.Location = new System.Drawing.Point(140, 244);
            this.lblEspere.Name = "lblEspere";
            this.lblEspere.Size = new System.Drawing.Size(413, 54);
            this.lblEspere.TabIndex = 1;
            this.lblEspere.Text = "Por favor espere...";
            // 
            // FrmInicio
            // 
            this.ClientSize = new System.Drawing.Size(725, 457);
            this.Controls.Add(this.lblEspere);
            this.Controls.Add(this.lblIniciando);
            this.Name = "FrmInicio";
            this.Text = "Rich Texan Hotel";
            this.Activated += new System.EventHandler(this.FrmInicio_Activated);
            this.Shown += new System.EventHandler(this.FrmInicio_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIniciando;
        private System.Windows.Forms.Label lblEspere;
    }
}