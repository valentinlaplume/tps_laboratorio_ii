
namespace Formularios
{
    partial class FrmEstadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadisticas));
            this.lst_Estadisticas = new System.Windows.Forms.ListBox();
            this.btn_ExportarEstadisticas = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lst_Estadisticas
            // 
            this.lst_Estadisticas.BackColor = System.Drawing.Color.White;
            this.lst_Estadisticas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_Estadisticas.FormattingEnabled = true;
            this.lst_Estadisticas.ItemHeight = 15;
            this.lst_Estadisticas.Location = new System.Drawing.Point(12, 61);
            this.lst_Estadisticas.Name = "lst_Estadisticas";
            this.lst_Estadisticas.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lst_Estadisticas.Size = new System.Drawing.Size(575, 450);
            this.lst_Estadisticas.TabIndex = 0;
            this.lst_Estadisticas.TabStop = false;
            this.lst_Estadisticas.UseTabStops = false;
            // 
            // btn_ExportarEstadisticas
            // 
            this.btn_ExportarEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_ExportarEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ExportarEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ExportarEstadisticas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ExportarEstadisticas.Location = new System.Drawing.Point(478, 24);
            this.btn_ExportarEstadisticas.Name = "btn_ExportarEstadisticas";
            this.btn_ExportarEstadisticas.Size = new System.Drawing.Size(109, 30);
            this.btn_ExportarEstadisticas.TabIndex = 60;
            this.btn_ExportarEstadisticas.Text = "EXPORTAR";
            this.btn_ExportarEstadisticas.UseVisualStyleBackColor = false;
            this.btn_ExportarEstadisticas.Click += new System.EventHandler(this.btn_ExportarEstadisticas_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.ForeColor = System.Drawing.Color.Black;
            this.lbl_Titulo.Location = new System.Drawing.Point(12, 21);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(276, 33);
            this.lbl_Titulo.TabIndex = 61;
            this.lbl_Titulo.Text = "Estadísticas VLMOTORS";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "\"txt files (*.txt)|*.txt";
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 523);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_ExportarEstadisticas);
            this.Controls.Add(this.lst_Estadisticas);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas - VLMOTORS";
            this.Load += new System.EventHandler(this.FrmEstadisticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ListBox lst_Estadisticas;
        public System.Windows.Forms.Button btn_ExportarEstadisticas;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}