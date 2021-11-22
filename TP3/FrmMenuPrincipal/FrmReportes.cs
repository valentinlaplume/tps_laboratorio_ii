using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmReportes : FrmBaseListas
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento load, esconde Botones ABM Vehiculo y 
        /// hace visible el boton de EXPORTAR para los reportes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReportes_Load(object sender, EventArgs e)
        {
            btn_Agregar.Visible = false;
            btn_Eliminar.Visible = false;
            btn_Modificar.Visible = false;
            btn_Exportar.Visible = true;
            lbl_Titulo.Text = "Menú de Reportes";
        }
    }
}
