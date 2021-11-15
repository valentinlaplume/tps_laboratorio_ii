
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_GuardarCambios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ABMVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Logo
            // 
            this.pb_Logo.BackColor = System.Drawing.SystemColors.Control;
            this.pb_Logo.Image = global::Formularios.Properties.Resources.vlMotors;
            this.pb_Logo.Location = new System.Drawing.Point(87, 12);
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
            this.pb_ABMVehiculos.Location = new System.Drawing.Point(112, 204);
            this.pb_ABMVehiculos.Name = "pb_ABMVehiculos";
            this.pb_ABMVehiculos.Size = new System.Drawing.Size(100, 91);
            this.pb_ABMVehiculos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ABMVehiculos.TabIndex = 3;
            this.pb_ABMVehiculos.TabStop = false;
            this.pb_ABMVehiculos.Click += new System.EventHandler(this.pb_ABMVehiculos_Click);
            // 
            // pb_Reportes
            // 
            this.pb_Reportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Reportes.Image = global::Formularios.Properties.Resources.boton_reportes;
            this.pb_Reportes.Location = new System.Drawing.Point(251, 204);
            this.pb_Reportes.Name = "pb_Reportes";
            this.pb_Reportes.Size = new System.Drawing.Size(100, 91);
            this.pb_Reportes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Reportes.TabIndex = 4;
            this.pb_Reportes.TabStop = false;
            this.pb_Reportes.Click += new System.EventHandler(this.pb_Reportes_Click);
            // 
            // lbl_ABMVehiculos
            // 
            this.lbl_ABMVehiculos.AutoSize = true;
            this.lbl_ABMVehiculos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ABMVehiculos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ABMVehiculos.Location = new System.Drawing.Point(124, 296);
            this.lbl_ABMVehiculos.Name = "lbl_ABMVehiculos";
            this.lbl_ABMVehiculos.Size = new System.Drawing.Size(78, 18);
            this.lbl_ABMVehiculos.TabIndex = 5;
            this.lbl_ABMVehiculos.Text = "VEHICULOS";
            // 
            // lbl_Reportes
            // 
            this.lbl_Reportes.AutoSize = true;
            this.lbl_Reportes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Reportes.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Reportes.Location = new System.Drawing.Point(267, 296);
            this.lbl_Reportes.Name = "lbl_Reportes";
            this.lbl_Reportes.Size = new System.Drawing.Size(70, 18);
            this.lbl_Reportes.TabIndex = 6;
            this.lbl_Reportes.Text = "REPORTES";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(469, 321);
            this.Controls.Add(this.lbl_Reportes);
            this.Controls.Add(this.lbl_ABMVehiculos);
            this.Controls.Add(this.pb_Reportes);
            this.Controls.Add(this.pb_ABMVehiculos);
            this.Controls.Add(this.pb_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.Controls.SetChildIndex(this.pb_Logo, 0);
            this.Controls.SetChildIndex(this.pb_ABMVehiculos, 0);
            this.Controls.SetChildIndex(this.pb_Reportes, 0);
            this.Controls.SetChildIndex(this.lbl_ABMVehiculos, 0);
            this.Controls.SetChildIndex(this.lbl_Reportes, 0);
            this.Controls.SetChildIndex(this.lbl_GuardarCambios, 0);
            this.Controls.SetChildIndex(this.pb_GuardarCambios, 0);
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
    }
}

