
namespace Formularios
{
    partial class FrmMenuVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuVehiculo));
            this.pnl_Filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GuardarCambios)).BeginInit();
            this.SuspendLayout();
            // 
          
            // 
            // pnl_Filtros
            // 
            this.pnl_Filtros.Location = new System.Drawing.Point(44, 55);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(653, 140);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(861, 141);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(757, 140);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(44, 33);
            // 
            // lbl_Seleccione
            // 
            this.lbl_Seleccione.Location = new System.Drawing.Point(44, 138);
            // 
            // FrmMenuVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 465);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuVehiculo";
            this.Text = "FrmMenuVehiculo";
            this.Load += new System.EventHandler(this.FrmMenuVehiculo_Load);
            this.pnl_Filtros.ResumeLayout(false);
            this.pnl_Filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GuardarCambios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}