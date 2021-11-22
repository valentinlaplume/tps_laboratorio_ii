using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using FrmMenuPrincipal;

namespace Formularios
{
    public partial class FrmLoadTask : Form
    {
        public FrmLoadTask()
        {
            InitializeComponent();
        }

        private void CargarDatosVehiculos()
        {
            Concesionaria.listAutos = ManejadoraSql.GetAutos();
            Concesionaria.listCamionetas = ManejadoraSql.GetCamionetas();
            Concesionaria.listMotocicletas = ManejadoraSql.GetMotocicletas();

            if (this.lbl_CargandoDatos.InvokeRequired)
            {
                this.lbl_CargandoDatos.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.Cargando();
                    this.lbl_CargandoDatos.Text = "Datos cargados con éxito !!!";
                    this.Refresh();
                    Thread.Sleep(3000);
                    this.lbl_CargandoDatos.Visible = false;
                });
            }

        }

        public bool BarraInicioSesion()
        {
            prg_BarraInicioPrograma.Minimum = 1;
            prg_BarraInicioPrograma.Maximum = 10000;
            prg_BarraInicioPrograma.Step = 2;
            for (int i = 0; i < 15000; i++)
            {
                prg_BarraInicioPrograma.PerformStep();
                if (i == 14999)
                    return true;
            }
            return false;
        }

        private bool Cargando()
        {

            if (this.prg_BarraInicioPrograma.InvokeRequired)
            {
                this.prg_BarraInicioPrograma.BeginInvoke((MethodInvoker)delegate ()
                {
                    Thread.Sleep(1000);
                    Concesionaria.listAutos = ManejadoraSql.GetAutos();
                    Concesionaria.listCamionetas = ManejadoraSql.GetCamionetas();
                    Concesionaria.listMotocicletas = ManejadoraSql.GetMotocicletas();

                    prg_BarraInicioPrograma.Minimum = 1;
                    prg_BarraInicioPrograma.Maximum = 25;
                    prg_BarraInicioPrograma.Step = 2;
                    this.Refresh();
                    for (int i = 100; i < 1500;)
                    {
                        Thread.Sleep(i); 
                        prg_BarraInicioPrograma.PerformStep();
                        this.Refresh();
                        i += 100;
                    }
                });
            }else
            {
                this.Refresh();
            }

            return true;
        }

        private async void FrmLoadTask_Load(object sender, EventArgs e)
        {
            await Task.Run(Cargando);

            FrmMenuPrincipal.FrmMenuPrincipal frmMenuPrincipalnew = new FrmMenuPrincipal.FrmMenuPrincipal();
            frmMenuPrincipalnew.Text = "Menu Principal - VL MOTORS" + " - " + DateTime.Now.ToString("d");
            frmMenuPrincipalnew.Show();
            this.Hide();
        }
    }

}
