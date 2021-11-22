
namespace Formularios
{
    partial class FrmDatos
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
            this.pb_GuardarCambios = new System.Windows.Forms.PictureBox();
            this.lbl_GuardarCambios = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GuardarCambios)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_GuardarCambios
            // 
            this.pb_GuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_GuardarCambios.Image = global::Formularios.Properties.Resources.save;
            this.pb_GuardarCambios.Location = new System.Drawing.Point(10, 9);
            this.pb_GuardarCambios.Name = "pb_GuardarCambios";
            this.pb_GuardarCambios.Size = new System.Drawing.Size(26, 26);
            this.pb_GuardarCambios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_GuardarCambios.TabIndex = 10;
            this.pb_GuardarCambios.TabStop = false;
            this.pb_GuardarCambios.Tag = "Guardar";
            this.pb_GuardarCambios.Click += new System.EventHandler(this.pb_GuardarCambios_Click);
            // 
            // lbl_GuardarCambios
            // 
            this.lbl_GuardarCambios.AutoSize = true;
            this.lbl_GuardarCambios.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GuardarCambios.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_GuardarCambios.Location = new System.Drawing.Point(37, 9);
            this.lbl_GuardarCambios.Name = "lbl_GuardarCambios";
            this.lbl_GuardarCambios.Size = new System.Drawing.Size(48, 26);
            this.lbl_GuardarCambios.TabIndex = 11;
            this.lbl_GuardarCambios.Text = "Guardar\r\nCambios\r\n";
            this.lbl_GuardarCambios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_GuardarCambios.UseMnemonic = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // FrmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 149);
            this.Controls.Add(this.pb_GuardarCambios);
            this.Controls.Add(this.lbl_GuardarCambios);
            this.Name = "FrmDatos";
            this.Text = "FrmDatos";
            ((System.ComponentModel.ISupportInitialize)(this.pb_GuardarCambios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pb_GuardarCambios;
        public System.Windows.Forms.Label lbl_GuardarCambios;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}