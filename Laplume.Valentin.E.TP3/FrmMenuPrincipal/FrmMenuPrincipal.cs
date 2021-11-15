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

namespace FrmMenuPrincipal
{

   
    public partial class FrmMenuPrincipal : FrmDatos
    {
        /// <summary>
        /// Constructor por defecto sin parametros
        /// </summary>
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Evento load, carga los archivos con las listas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                Concesionaria.listAutos = Json<List<Auto>>.LeerDatos("Autos_JSON");
                Concesionaria.listCamionetas = Json<List<Camioneta>>.LeerDatos("Camionetas_JSON");
                Concesionaria.listMotocicletas = Xml<Motocicleta>.LeerDatos("Motocicletas_XML");
                //foreach (Motocicleta item in Concesionaria.listMotocicletas)
                //{
                //    ManejadoraSql.Insertar2(
                //                            (int)item.Marca,
                //                            item.Nombre,
                //                            item.Año,
                //                            item.Km,
                //                            (int)item.TipoCombustible,
                //                            (int)item.TipoTransmision,
                //                            (int)item.Color,
                //                            item.Precio,
                //                            item.Estado);
                //}

                //EColor colormax = Concesionaria.listMotocicletas.Max(x => x.Color);
                //Concesionaria.listMotocicletas.MaxColor();

                //ManejadoraSql.InsertarAutos(Concesionaria.listAutos);
                //MessageBox.Show($"COLOR MAXIMO: {Concesionaria.listMotocicletas.MaxColor()}");

                //string sdasdaa = ManejadoraSql.GetQueryInsert("camioneta");
                //string nsdasda = ManejadoraSql.GetQueryInsert("motocicleta");

                //List<Auto> n = ManejadoraSql.GetDatosDBAutos("SELECT * FROM Autos");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
