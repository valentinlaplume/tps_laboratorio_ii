
namespace Formularios
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            this.btn_VerEstadisticas = new System.Windows.Forms.Button();
            this.pnl_Filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GuardarCambios)).BeginInit();
            this.SuspendLayout();
                
            // 
            // pnl_Filtros
            // 
            this.pnl_Filtros.Location = new System.Drawing.Point(44, 55);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(615, 19);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(823, 19);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(719, 20);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(44, 33);
            // 
            // lbl_Seleccione
            // 
            this.lbl_Seleccione.Location = new System.Drawing.Point(44, 138);
            // 
            // btn_VerEstadisticas
            // 
            this.btn_VerEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_VerEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VerEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VerEstadisticas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_VerEstadisticas.Location = new System.Drawing.Point(647, 140);
            this.btn_VerEstadisticas.Name = "btn_VerEstadisticas";
            this.btn_VerEstadisticas.Size = new System.Drawing.Size(202, 30);
            this.btn_VerEstadisticas.TabIndex = 59;
            this.btn_VerEstadisticas.Text = "VER ESTADÍSTICAS";
            this.btn_VerEstadisticas.UseVisualStyleBackColor = false;
            this.btn_VerEstadisticas.Visible = false;
            this.btn_VerEstadisticas.Click += new System.EventHandler(this.btn_VerEstadisticas_Click);
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 465);
            this.Controls.Add(this.btn_VerEstadisticas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportes";
            this.Text = "-";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lbl_Seleccione, 0);
            this.Controls.SetChildIndex(this.lbl_Titulo, 0);
            this.Controls.SetChildIndex(this.pnl_Filtros, 0);
            this.Controls.SetChildIndex(this.btn_Exportar, 0);
            this.Controls.SetChildIndex(this.lbl_Errores, 0);
            this.Controls.SetChildIndex(this.lbl_GuardarCambios, 0);
            this.Controls.SetChildIndex(this.pb_GuardarCambios, 0);
            this.Controls.SetChildIndex(this.btn_Modificar, 0);
            this.Controls.SetChildIndex(this.btn_Eliminar, 0);
            this.Controls.SetChildIndex(this.btn_Agregar, 0);
            this.Controls.SetChildIndex(this.btn_VerEstadisticas, 0);
            this.pnl_Filtros.ResumeLayout(false);
            this.pnl_Filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GuardarCambios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_VerEstadisticas;
    }
}