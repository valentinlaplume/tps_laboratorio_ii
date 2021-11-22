using Archivos;
using Entidades;
using Excepciones;
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
    public partial class FrmDatos : Form
    {
        public FrmDatos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Guarda los cambios realizados
        /// Lista de autos y camionetas en formato JSON
        /// Lista motocicleta en formato XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_GuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                //openFileDialog.Title = "Busque archivo - VLMOTORS";
                //openFileDialog.ShowDialog();

                //string pathLeer = openFileDialog.FileName;
                //if (File.Exists(openFileDialog.FileName))
                //{
                //    string path = openFileDialog.FileName;


                //}
                Json<List<Auto>>.GuardarDatos("Autos_JSON", Concesionaria.listAutos);
                Json<List<Camioneta>>.GuardarDatos("Camionetas_JSON", Concesionaria.listCamionetas);
                Xml<Motocicleta>.GuardarDatos("Motocicletas_XML", Concesionaria.listMotocicletas);

                MessageBox.Show("Se guardaron los cambios correctamente.");
            }
            catch (ArchivosException ex)
            {
                MessageBox.Show(ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
