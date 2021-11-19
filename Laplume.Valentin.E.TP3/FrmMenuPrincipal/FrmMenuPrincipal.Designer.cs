
namespace FrmMenuPrincipal
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.pb_ABMVehiculos = new System.Windows.Forms.PictureBox();
            this.pb_Reportes = new System.Windows.Forms.PictureBox();
            this.lbl_ABMVehiculos = new System.Windows.Forms.Label();
            this.lbl_Reportes = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lbl_CargandoDatos = new System.Windows.Forms.Label();
            this.prg_BarraInicioPrograma = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GuardarCambios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ABMVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_GuardarCambios
            // 
            this.pb_GuardarCambios.Visible = false;
            // 
            // lbl_GuardarCambios
            // 
            this.lbl_GuardarCambios.Visible = false;
            // 
            // pb_Logo
            // 
            this.pb_Logo.BackColor = System.Drawing.SystemColors.Control;
            this.pb_Logo.Image = global::Formularios.Properties.Resources.vlMotors;
            this.pb_Logo.Location = new System.Drawing.Point(87, 52);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(291, 180);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 2;
            this.pb_Logo.TabStop = false;
            // 
            // pb_ABMVehiculos
            // 
            this.pb_ABMVehiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_ABMVehiculos.Image = global::Formularios.Properties.Resources.boton_menu;
            this.pb_ABMVehiculos.Location = new System.Drawing.Point(115, 200);
            this.pb_ABMVehiculos.Name = "pb_ABMVehiculos";
            this.pb_ABMVehiculos.Size = new System.Drawing.Size(100, 91);
            this.pb_ABMVehiculos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ABMVehiculos.TabIndex = 3;
            this.pb_ABMVehiculos.TabStop = false;
            this.pb_ABMVehiculos.Visible = false;
            this.pb_ABMVehiculos.Click += new System.EventHandler(this.pb_ABMVehiculos_Click);
            // 
            // pb_Reportes
            // 
            this.pb_Reportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Reportes.Image = global::Formularios.Properties.Resources.boton_reportes;
            this.pb_Reportes.Location = new System.Drawing.Point(255, 200);
            this.pb_Reportes.Name = "pb_Reportes";
            this.pb_Reportes.Size = new System.Drawing.Size(100, 91);
            this.pb_Reportes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Reportes.TabIndex = 4;
            this.pb_Reportes.TabStop = false;
            this.pb_Reportes.Visible = false;
            this.pb_Reportes.Click += new System.EventHandler(this.pb_Reportes_Click);
            // 
            // lbl_ABMVehiculos
            // 
            this.lbl_ABMVehiculos.AutoSize = true;
            this.lbl_ABMVehiculos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ABMVehiculos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ABMVehiculos.Location = new System.Drawing.Point(124, 292);
            this.lbl_ABMVehiculos.Name = "lbl_ABMVehiculos";
            this.lbl_ABMVehiculos.Size = new System.Drawing.Size(78, 18);
            this.lbl_ABMVehiculos.TabIndex = 5;
            this.lbl_ABMVehiculos.Text = "VEHICULOS";
            this.lbl_ABMVehiculos.Visible = false;
            // 
            // lbl_Reportes
            // 
            this.lbl_Reportes.AutoSize = true;
            this.lbl_Reportes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Reportes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Reportes.Location = new System.Drawing.Point(267, 292);
            this.lbl_Reportes.Name = "lbl_Reportes";
            this.lbl_Reportes.Size = new System.Drawing.Size(70, 18);
            this.lbl_Reportes.TabIndex = 6;
            this.lbl_Reportes.Text = "REPORTES";
            this.lbl_Reportes.Visible = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // lbl_CargandoDatos
            // 
            this.lbl_CargandoDatos.AutoSize = true;
            this.lbl_CargandoDatos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CargandoDatos.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CargandoDatos.ForeColor = System.Drawing.Color.Green;
            this.lbl_CargandoDatos.Location = new System.Drawing.Point(77, 273);
            this.lbl_CargandoDatos.Name = "lbl_CargandoDatos";
            this.lbl_CargandoDatos.Size = new System.Drawing.Size(316, 28);
            this.lbl_CargandoDatos.TabIndex = 15;
            this.lbl_CargandoDatos.Text = "Cargando datos, espere porfavor";
            // 
            // prg_BarraInicioPrograma
            // 
            this.prg_BarraInicioPrograma.ForeColor = System.Drawing.Color.Green;
            this.prg_BarraInicioPrograma.Location = new System.Drawing.Point(-3, 304);
            this.prg_BarraInicioPrograma.Name = "prg_BarraInicioPrograma";
            this.prg_BarraInicioPrograma.Size = new System.Drawing.Size(479, 23);
            this.prg_BarraInicioPrograma.TabIndex = 14;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(469, 321);
            this.Controls.Add(this.pb_Logo);
            this.Controls.Add(this.prg_BarraInicioPrograma);
            this.Controls.Add(this.lbl_Reportes);
            this.Controls.Add(this.lbl_ABMVehiculos);
            this.Controls.Add(this.pb_Reportes);
            this.Controls.Add(this.pb_ABMVehiculos);
            this.Controls.Add(this.lbl_CargandoDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.Controls.SetChildIndex(this.lbl_CargandoDatos, 0);
            this.Controls.SetChildIndex(this.pb_ABMVehiculos, 0);
            this.Controls.SetChildIndex(this.pb_Reportes, 0);
            this.Controls.SetChildIndex(this.lbl_ABMVehiculos, 0);
            this.Controls.SetChildIndex(this.lbl_Reportes, 0);
            this.Controls.SetChildIndex(this.lbl_GuardarCambios, 0);
            this.Controls.SetChildIndex(this.pb_GuardarCambios, 0);
            this.Controls.SetChildIndex(this.prg_BarraInicioPrograma, 0);
            this.Controls.SetChildIndex(this.pb_Logo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pb_GuardarCambios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ABMVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Reportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.PictureBox pb_ABMVehiculos;
        private System.Windows.Forms.PictureBox pb_Reportes;
        private System.Windows.Forms.Label lbl_ABMVehiculos;
        private System.Windows.Forms.Label lbl_Reportes;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lbl_CargandoDatos;
        private System.Windows.Forms.ProgressBar prg_BarraInicioPrograma;
    }
}

