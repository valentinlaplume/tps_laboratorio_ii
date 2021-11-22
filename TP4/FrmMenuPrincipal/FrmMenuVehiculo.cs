using Entidades;
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
    public partial class FrmMenuVehiculo : FrmBaseListas
    {
        public FrmMenuVehiculo()
        {
            InitializeComponent();
        }

        private void FrmMenuVehiculo_Load(object sender, EventArgs e)
        {
            lbl_Titulo.Text = "Menú de Vehículos";
            btn_Exportar.Visible = false;
            btn_Agregar.Visible = true;
            btn_Eliminar.Visible = true;
            btn_Modificar.Visible = true;
        }
    }
}
