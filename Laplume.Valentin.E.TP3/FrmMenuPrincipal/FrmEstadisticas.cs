using Entidades;
using Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Formularios
{

    public partial class FrmEstadisticas : Form
    {
        static StringBuilder sbEstadisticas;
        public FrmEstadisticas()
        {
            InitializeComponent();
            sbEstadisticas = new StringBuilder();
        }

        public static float GetPorcentaje(int cantidadParcial, int cantidadTotal)
        {
            return (cantidadParcial * 100) / cantidadTotal;
        }

        private void LoadDatosEstadisticos()
        {
            try
            {
                AddDatosEstadisticosListBox("================================  ESTADÍSTICAS EN VLMOTORS  ================================");
                AddDatosEstadisticosListBox("============================================================================================");
                AddDatosEstadisticosListBox("");

                #region TIPO DE VEHÍCULOS
                AddDatosEstadisticosListBox("===================== TIPO DE VEHÍCULOS");
                AddDatosEstadisticosListBox($"AUTOS: % {GetPorcentaje(Concesionaria.CantidadAutos, Concesionaria.CantidadTotalVehiculos)} ({Concesionaria.CantidadAutos} de {Concesionaria.CantidadTotalVehiculos})");
                AddDatosEstadisticosListBox($"CAMIONETAS: % {GetPorcentaje(Concesionaria.CantidadCamionetas, Concesionaria.CantidadTotalVehiculos)} ({Concesionaria.CantidadCamionetas} de {Concesionaria.CantidadTotalVehiculos})");
                AddDatosEstadisticosListBox($"MOTOCICLETAS: % {GetPorcentaje(Concesionaria.CantidadMotocicletas, Concesionaria.CantidadTotalVehiculos)} ({Concesionaria.CantidadMotocicletas} de {Concesionaria.CantidadTotalVehiculos})");
                AddDatosEstadisticosListBox("");
                #endregion

                #region COLOR QUE MAS ABUNDA
                AddDatosEstadisticosListBox("===================== COLOR QUE MAS ABUNDA");
                AddDatosEstadisticosListBox($"AUTOS: {Concesionaria.listAutos.MaxColor()}");
                AddDatosEstadisticosListBox($"CAMIONETAS: {Concesionaria.listCamionetas.MaxColor()}");
                AddDatosEstadisticosListBox($"MOTOCICLETAS: {Concesionaria.listMotocicletas.MaxColor()}");
                AddDatosEstadisticosListBox("");
                #endregion

                #region TIPO DE COMBUSTIBLES
                AddDatosEstadisticosListBox("=====================  TIPO DE COMBUSTIBLES");
                AddDatosEstadisticosListBox("AUTOS:");
                AddDatosEstadisticosListBox(Estadistica<Auto>.GetPorcentajesVehiculosPorCombustible(Concesionaria.listAutos));
                AddDatosEstadisticosListBox("CAMIONETAS:");
                AddDatosEstadisticosListBox(Estadistica<Camioneta>.GetPorcentajesVehiculosPorCombustible(Concesionaria.listCamionetas));
                AddDatosEstadisticosListBox("MOTOCICLETAS:");
                AddDatosEstadisticosListBox(Estadistica<Motocicleta>.GetPorcentajesVehiculosPorCombustible(Concesionaria.listMotocicletas));
                AddDatosEstadisticosListBox("");
                #endregion

                #region TIPO DE TRANSMISIÓN
                AddDatosEstadisticosListBox("=====================  TIPO DE TRANSMISIÓN");
                AddDatosEstadisticosListBox("AUTOS:");
                AddDatosEstadisticosListBox(Estadistica<Auto>.GetPorcentajesVehiculosPorTransimison(Concesionaria.listAutos));
                AddDatosEstadisticosListBox("CAMIONETAS:");
                AddDatosEstadisticosListBox(Estadistica<Camioneta>.GetPorcentajesVehiculosPorTransimison(Concesionaria.listCamionetas));
                AddDatosEstadisticosListBox("CAMIONETAS:");
                AddDatosEstadisticosListBox(Estadistica<Motocicleta>.GetPorcentajesVehiculosPorTransimison(Concesionaria.listMotocicletas));
                AddDatosEstadisticosListBox("");
                #endregion

                #region MARCA AUTOMÓVIL
                AddDatosEstadisticosListBox("===================== MARCA AUTOMÓVIL");
                Array marcasAutomoviles = Enum.GetNames(typeof(EMarcaAutomovil));
                foreach (string marca in marcasAutomoviles)
                {
                    int cantidadParcialAutos = Concesionaria.listAutos.Where(x => x.Marca.ToString() == marca).ToList().Count();
                    AddDatosEstadisticosListBox($"AUTOS {marca}: % " +
                    $"{GetPorcentaje(cantidadParcialAutos, Concesionaria.CantidadAutos)} ({cantidadParcialAutos} de {Concesionaria.CantidadAutos})");

                    int cantidadParcialCamionetas = Concesionaria.listCamionetas.Where(x => x.Marca.ToString() == marca).ToList().Count();
                    AddDatosEstadisticosListBox($"CAMIONETAS {marca}: % " +
                    $"{GetPorcentaje(cantidadParcialCamionetas, Concesionaria.CantidadCamionetas)} ({cantidadParcialCamionetas} de {Concesionaria.CantidadCamionetas})");
                    AddDatosEstadisticosListBox("");
                }
                #endregion

                #region MARCA MOTOCICLETA
                AddDatosEstadisticosListBox("===================== MARCA MOTOCICLETA");
                Array marcasMotocicletas = Enum.GetNames(typeof(EMarcaMotocicleta));
                foreach (string marca in marcasMotocicletas)
                {
                    int cantidadParcialAutos = Concesionaria.listMotocicletas.Where(x => x.Marca.ToString() == marca).ToList().Count();
                    AddDatosEstadisticosListBox($"{marca}: % " +
                    $"{GetPorcentaje(cantidadParcialAutos, Concesionaria.CantidadMotocicletas)} ({cantidadParcialAutos} de {Concesionaria.CantidadMotocicletas})");
                }
                AddDatosEstadisticosListBox("");
                #endregion

                #region VEHÍCULOS QUE SUPERAN EL $ 1.000.000
                AddDatosEstadisticosListBox("=====================  VEHÍCULOS QUE SUPERAN EL $ 1.000.000");
                AddDatosEstadisticosListBox("AUTOS:");
                AddDatosEstadisticosListBox(Estadistica<Auto>.GetPorcentajesVehiculosPorPrecio(Concesionaria.listAutos, true, 1000000));
                AddDatosEstadisticosListBox("CAMIONETAS:");
                AddDatosEstadisticosListBox(Estadistica<Camioneta>.GetPorcentajesVehiculosPorPrecio(Concesionaria.listCamionetas, true, 1000000));
                AddDatosEstadisticosListBox("MOTOCICLETAS:");
                AddDatosEstadisticosListBox(Estadistica<Motocicleta>.GetPorcentajesVehiculosPorPrecio(Concesionaria.listMotocicletas, true, 1000000));
                AddDatosEstadisticosListBox("");
                #endregion

                #region VEHÍCULOS QUE NO SUPERAN EL $ 1.000.000
                AddDatosEstadisticosListBox("=====================  VEHÍCULOS QUE NO SUPERAN EL $ 1.000.000");
                AddDatosEstadisticosListBox("AUTOS:");
                AddDatosEstadisticosListBox(Estadistica<Auto>.GetPorcentajesVehiculosPorPrecio(Concesionaria.listAutos, false, 1000000));
                AddDatosEstadisticosListBox("CAMIONETAS:");
                AddDatosEstadisticosListBox(Estadistica<Camioneta>.GetPorcentajesVehiculosPorPrecio(Concesionaria.listCamionetas, false, 1000000));
                AddDatosEstadisticosListBox("MOTOCICLETAS:");
                AddDatosEstadisticosListBox(Estadistica<Motocicleta>.GetPorcentajesVehiculosPorPrecio(Concesionaria.listMotocicletas, false, 1000000));
                AddDatosEstadisticosListBox("");
                #endregion

                #region VEHÍCULOS QUE SUPERAN LOS 100.000 KILÓMETROS
                AddDatosEstadisticosListBox("=====================  VEHÍCULOS QUE SUPERAN LOS 100.000 KILÓMETROS");
                AddDatosEstadisticosListBox("AUTOS:");
                AddDatosEstadisticosListBox(Estadistica<Auto>.GetPorcentajesVehiculosPorKilometros(Concesionaria.listAutos, true, 100000));
                AddDatosEstadisticosListBox("CAMIONETAS:");
                AddDatosEstadisticosListBox(Estadistica<Camioneta>.GetPorcentajesVehiculosPorKilometros(Concesionaria.listCamionetas, true, 100000));
                AddDatosEstadisticosListBox("MOTOCICLETAS:");
                AddDatosEstadisticosListBox(Estadistica<Motocicleta>.GetPorcentajesVehiculosPorKilometros(Concesionaria.listMotocicletas, true, 100000));
                AddDatosEstadisticosListBox("");
                #endregion

                #region VEHÍCULOS QUE NO SUPERAN LOS 100.000 KILÓMETROS
                AddDatosEstadisticosListBox("=====================  VEHÍCULOS QUE NO SUPERAN LOS 100.000 KILÓMETROS");
                AddDatosEstadisticosListBox("AUTOS:");
                AddDatosEstadisticosListBox(Estadistica<Auto>.GetPorcentajesVehiculosPorKilometros(Concesionaria.listAutos, false, 100000));
                AddDatosEstadisticosListBox("CAMIONETAS:");
                AddDatosEstadisticosListBox(Estadistica<Camioneta>.GetPorcentajesVehiculosPorKilometros(Concesionaria.listCamionetas, false, 100000));
                AddDatosEstadisticosListBox("MOTOCICLETAS:");
                AddDatosEstadisticosListBox(Estadistica<Motocicleta>.GetPorcentajesVehiculosPorKilometros(Concesionaria.listMotocicletas, false, 100000));
                AddDatosEstadisticosListBox("");
                #endregion

                #region VEHÍCULOS SUPERIORES AL AÑO 2010
                AddDatosEstadisticosListBox("=====================  VEHÍCULOS SUPERIORES AL AÑO 2010");
                AddDatosEstadisticosListBox("AUTOS:");
                AddDatosEstadisticosListBox(Estadistica<Auto>.GetPorcentajesVehiculosPorAño(Concesionaria.listAutos, true, 2010));
                AddDatosEstadisticosListBox("CAMIONETAS:");
                AddDatosEstadisticosListBox(Estadistica<Camioneta>.GetPorcentajesVehiculosPorAño(Concesionaria.listCamionetas, true, 2010));
                AddDatosEstadisticosListBox("MOTOCICLETAS:");
                AddDatosEstadisticosListBox(Estadistica<Motocicleta>.GetPorcentajesVehiculosPorAño(Concesionaria.listMotocicletas, true, 2010));
                AddDatosEstadisticosListBox("");
                #endregion

                #region VEHÍCULOS INFERIORES AL AÑO 2010
                AddDatosEstadisticosListBox("=====================  VEHÍCULOS INFERIORES AL AÑO 2010");
                AddDatosEstadisticosListBox("AUTOS:");
                AddDatosEstadisticosListBox(Estadistica<Auto>.GetPorcentajesVehiculosPorAño(Concesionaria.listAutos, false, 2010));
                AddDatosEstadisticosListBox("CAMIONETAS:");
                AddDatosEstadisticosListBox(Estadistica<Camioneta>.GetPorcentajesVehiculosPorAño(Concesionaria.listCamionetas, false, 2010));
                AddDatosEstadisticosListBox("MOTOCICLETAS:");
                AddDatosEstadisticosListBox(Estadistica<Motocicleta>.GetPorcentajesVehiculosPorAño(Concesionaria.listMotocicletas, false, 2010));
                AddDatosEstadisticosListBox("");
                #endregion
            }
            catch (Exception)
            {
                throw new Exception($"Ocurrió un error al obtener los datos estadísticos.");
            }
        }

        /// <summary>
        /// Evento load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDatosEstadisticos();
                SaveDatosEstadisticos(lst_Estadisticas, sbEstadisticas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Agrega los datos al listbox
        /// </summary>
        /// <param name="dato"></param>
        public void AddDatosEstadisticosListBox(string dato)
        {
            try
            {
                lst_Estadisticas.Items.Add(dato);
            }
            catch (Exception)
            {
                throw new Exception($"Ocurrió un error al mostrar datos por pantalla de datos estadísticos.");
            }
        }

        /// <summary>
        /// Guarda los datos del listbox al stringbuilder statico
        /// Éste es utilizao para exportar informacion.
        /// </summary>
        /// <param name="listBox"></param>
        /// <param name="stringBuilder"></param>
        public void SaveDatosEstadisticos(ListBox listBox, StringBuilder stringBuilder)
        {
            try
            {
                stringBuilder.Clear();
                for (int i = 0; i < listBox.Items.Count; i++)
                {
                    stringBuilder.AppendLine((string)listBox.Items[i]);
                }
            }
            catch (Exception)
            {
                throw new Exception($"Ocurrió un error al guardar datos estadísticos.");
            }
        }

        /// <summary>
        /// Boton para exportar estadisticas en pantalla y alojadas en la variable estatica sbEstadisticas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ExportarEstadisticas_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog.FileName = string.Empty;
                saveFileDialog.Title = "Estadísticas - VLMOTORS";
                if (!string.IsNullOrEmpty(sbEstadisticas.ToString()) && saveFileDialog.ShowDialog() == DialogResult.OK &&
                    !string.IsNullOrEmpty(saveFileDialog.FileName))
                {
                    string pathArchivo = saveFileDialog.FileName;
                    using (StreamWriter sw = new StreamWriter(pathArchivo)) { sw.WriteLine(sbEstadisticas.ToString()); }
                    MessageBox.Show($"Estadísticas exportadas en {pathArchivo} correctamente.", "¡Información!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                throw new Exception($"Ocurrió un error al exportar datos estadísticos.");
            }
        }
    }
}
