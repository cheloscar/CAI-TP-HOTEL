
namespace TPHotel.InterfazFormuario
{
    partial class FrmDeseaAgregarClienteNuevo
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
            this.label1 = new System.Windows.Forms.Label();
            this._btnSI = new System.Windows.Forms.Button();
            this._btnNO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Desea agregar nuevo cliente?";
            // 
            // _btnSI
            // 
            this._btnSI.Location = new System.Drawing.Point(46, 119);
            this._btnSI.Name = "_btnSI";
            this._btnSI.Size = new System.Drawing.Size(75, 23);
            this._btnSI.TabIndex = 1;
            this._btnSI.Text = "SI";
            this._btnSI.UseVisualStyleBackColor = true;
            this._btnSI.Click += new System.EventHandler(this._btnSI_Click);
            // 
            // _btnNO
            // 
            this._btnNO.Location = new System.Drawing.Point(137, 119);
            this._btnNO.Name = "_btnNO";
            this._btnNO.Size = new System.Drawing.Size(75, 23);
            this._btnNO.TabIndex = 2;
            this._btnNO.Text = "NO";
            this._btnNO.UseVisualStyleBackColor = true;
            // 
            // FrmDeseaAgregarClienteNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 207);
            this.Controls.Add(this._btnNO);
            this.Controls.Add(this._btnSI);
            this.Controls.Add(this.label1);
            this.Name = "FrmDeseaAgregarClienteNuevo";
            this.Text = "FrmDeseaAgregarClienteNuevo";
            this.Load += new System.EventHandler(this.FrmDeseaAgregarClienteNuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnSI;
        private System.Windows.Forms.Button _btnNO;
    }
}