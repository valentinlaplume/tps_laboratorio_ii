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
using Excepciones;
using Archivos;
using Formularios;
using Entidades.Enumerados;
using System.IO;
using System.Threading;

namespace FrmMenuPrincipal
{

   
    public partial class FrmMenuPrincipal : FrmDatos
    {
        Task tareaCargarDatos;

        /// <summary>
        /// Constructor por defecto sin parametros
        /// </summary>
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        #region TASK BARRA LOAD Y CARGA DE LISTAS DESDE LA DB
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
                    Concesionaria.listAutos = ManejadoraSql.GetAutos();
                    Concesionaria.listCamionetas = ManejadoraSql.GetCamionetas();
                    Concesionaria.listMotocicletas = ManejadoraSql.GetMotocicletas();

                    prg_BarraInicioPrograma.Minimum = 1;
                    prg_BarraInicioPrograma.Maximum = 10;
                    prg_BarraInicioPrograma.Step = 2;
                    this.Refresh();

                    for (int i = 100; i < 1000;)
                    {
                        Thread.Sleep(i);
                        prg_BarraInicioPrograma.PerformStep();
                        this.Refresh();
                        i += 100;
                    }

                    prg_BarraInicioPrograma.Visible = false;
                    this.Refresh();
                    if (this.lbl_CargandoDatos.InvokeRequired){
                        this.lbl_CargandoDatos.BeginInvoke((MethodInvoker)delegate ()
                        {
                            lbl_CargandoDatos.Visible = false;
                            this.Refresh();
                        });
                    }
                });
            }
            else
            {
                this.Refresh();
            }

            return true;
        }
        #endregion

        /// <summary>
        /// Evento load, carga las listas desde la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private async void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                // codigo inactivo
                #region CARGA DE LISTAS POR MEDIO DE ARCHIVOS
                //Concesionaria.listAutos = Json<List<Auto>>.LeerDatos("Autos_JSON");
                //Concesionaria.listCamionetas = Json<List<Camioneta>>.LeerDatos("Camionetas_JSON");
                //Concesionaria.listMotocicletas = Xml<Motocicleta>.LeerDatos("Motocicletas_XML");
                #endregion

                // label.InvokeRequired (te dice si estas en el hilo del control ese, propiedad del control)
                // label.BeginInvoke(delegado que se ejecuta de forma asincrona y nos une con la parte del hilo principal donde se unen las cosas, osea el control de donde fue creado)
                //await Task.Run(CargarDatosVehiculos);
                //tareaCargarDatos.Start();

                await Task.Run(Cargando);
                HabilitarMenuPrincipal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Muestra lo necesario del funcionamiento del programa,
        /// luego de cargar los datos de la task
        /// </summary>
        private void HabilitarMenuPrincipal()
        {
            pb_Logo.Location = new Point(87, 3);
            lbl_CargandoDatos.Visible = false;
            pb_Reportes.Visible = true;
            pb_ABMVehiculos.Visible = true;
            lbl_GuardarCambios.Visible = true;
            lbl_ABMVehiculos.Visible = true;
            lbl_Reportes.Visible = true;
            this.Refresh();
        }

        /// <summary>
        /// Picture box usado como boton para ir al formulario del Alta-Baja-Modifica vehiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_ABMVehiculos_Click(object sender, EventArgs e)
        {
            FrmMenuVehiculo frmMenuVehiculo = new FrmMenuVehiculo();
            frmMenuVehiculo.Text = "Menu Vehiculos - VL MOTORS" + " - " + DateTime.Now.ToString("d");
            Console.Beep(100, 400);
            frmMenuVehiculo.ShowDialog();
        }

        /// <summary>
        /// Picture box usado como boton para ir al formulario de Reportes vehiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_Reportes_Click(object sender, EventArgs e)
        {
            //FrmBaseListas frmReportes = new FrmBaseListas();
            FrmReportes frmReportes = new FrmReportes(); 
            frmReportes.Text = "Reportes - VL MOTORS" + " - " + DateTime.Now.ToString("d");
            Console.Beep(100, 400);
            frmReportes.ShowDialog();
        }

        /// <summary>
        /// Evento closing, pregunta si desea guardar los cambios antes de cerrar 
        /// el programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea guardar los cambios realizados antes de salir del programa?", "Pregunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Xml<List<Auto>>.GuardarDatos("Datos_Autos", Concesionaria.ListAutos);
                    //Xml<List<Camioneta>>.GuardarDatos("Datos_Camionetas", Concesionaria.ListCamionetas);
                    //Xml<List<Motocicleta>>.GuardarDatos("Datos_Motocicletas", Concesionaria.ListMotocicletas);
                    Json<List<Auto>>.GuardarDatos("Autos_JSON", Concesionaria.listAutos);
                    Json<List<Camioneta>>.GuardarDatos("Camionetas_JSON", Concesionaria.listCamionetas);
                    Xml<Motocicleta>.GuardarDatos("Motocicletas_XML", Concesionaria.listMotocicletas);
                }
            }
            catch (ArchivosException ex)
            {
                MessageBox.Show(ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al guardar los cambios realizados.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
