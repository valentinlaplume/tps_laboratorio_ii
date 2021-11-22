
namespace Formularios
{
    partial class FrmLoadTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoadTask));
            this.prg_BarraInicioPrograma = new System.Windows.Forms.ProgressBar();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_CargandoDatos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // prg_BarraInicioPrograma
            // 
            this.prg_BarraInicioPrograma.ForeColor = System.Drawing.Color.Green;
            this.prg_BarraInicioPrograma.Location = new System.Drawing.Point(12, 325);
            this.prg_BarraInicioPrograma.Name = "prg_BarraInicioPrograma";
            this.prg_BarraInicioPrograma.Size = new System.Drawing.Size(461, 23);
            this.prg_BarraInicioPrograma.TabIndex = 0;
            // 
            // pb_Logo
            // 
            this.pb_Logo.BackColor = System.Drawing.SystemColors.Control;
            this.pb_Logo.Image = global::Formularios.Properties.Resources.vlMotors;
            this.pb_Logo.Location = new System.Drawing.Point(98, 40);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(291, 180);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 3;
            this.pb_Logo.TabStop = false;
            // 
            // lbl_CargandoDatos
            // 
            this.lbl_CargandoDatos.AutoSize = true;
            this.lbl_CargandoDatos.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CargandoDatos.ForeColor = System.Drawing.Color.Green;
            this.lbl_CargandoDatos.Location = new System.Drawing.Point(82, 294);
            this.lbl_CargandoDatos.Name = "lbl_CargandoDatos";
            this.lbl_CargandoDatos.Size = new System.Drawing.Size(316, 28);
            this.lbl_CargandoDatos.TabIndex = 13;
            this.lbl_CargandoDatos.Text = "Cargando datos, espere porfavor";
            // 
            // FrmLoadTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 360);
            this.Controls.Add(this.lbl_CargandoDatos);
            this.Controls.Add(this.pb_Logo);
            this.Controls.Add(this.prg_BarraInicioPrograma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLoadTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoadTask";
            this.Load += new System.EventHandler(this.FrmLoadTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prg_BarraInicioPrograma;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Label lbl_CargandoDatos;
    }
}