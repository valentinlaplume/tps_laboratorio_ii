using Archivos;
using Entidades;
using Entidades.Enumerados;
using Excepciones;
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

namespace Formularios
{
    public partial class FrmBaseListas : FrmDatos
    {
        List<Auto> listAutosReporte;
        List<Camioneta> listCamionetasReporte;
        List<Motocicleta> listMotocicletaReporte;

        /// <summary>
        /// Constructor por defecto sin parametros
        /// </summary>
        public FrmBaseListas()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  Encabezado del reporte de automoviles (auto - camioneta)
        /// </summary>
        /// <returns></returns>
        private string EncabezadoAutomovil()
        {
            return "Marca,Nombre,Año,Km,Tipo de Combustible,Tipo de Transmision,Color,Precio,Puertas";
        }
        /// <summary>
        /// Encabezado del reporte de motocicleta
        /// </summary>
        /// <returns></returns>
        private string EncabezadoMotocicleta()
        {
            return "Marca,Nombre,Año,Km,Tipo de Combustible,Tipo de Transmision,Color,Precio";
        }

        /// <summary>
        /// Verifica que al lista del reporte no sea nulla
        /// </summary>
        /// <param name="tipoVehiculo"></param>
        /// <returns></returns>
        private bool IsNullListaPorExportar(string tipoVehiculo)
        {
            bool isNullLista = false;
            switch (tipoVehiculo)
            {
                case "Motocicleta":
                    if(listMotocicletaReporte == null)
                        isNullLista = true;
                    break;
                case "Auto":
                    if(listAutosReporte == null)
                        isNullLista = true;
                    break;
                case "Camioneta":
                    if(listCamionetasReporte == null)
                        isNullLista = true;
                    break;
            }
            return isNullLista;
        }

        /// <summary>
        /// Metodo que abre una pantalla para guardar el reporte en formato csv
        /// </summary>
        /// <param name="tipoVehiculo"></param>
        private void ExportarReporte(string tipoVehiculo)
        {
            try
            {
                if(IsNullListaPorExportar(tipoVehiculo)) 
                    throw new AtributoInvalidoException("Reporte vacío... verifique que su reporte se muestre en pantalla", "ExportarReporte, en formulario FrmBaseListas");

                saveFileDialog.FileName = string.Empty;
                saveFileDialog.Title = "Reporte " + tipoVehiculo + " - VLMOTORS";
                if (!string.IsNullOrEmpty(tipoVehiculo) && saveFileDialog.ShowDialog() == DialogResult.OK &&
                    !string.IsNullOrEmpty(saveFileDialog.FileName))
                {
                    string pathArchivo = saveFileDialog.FileName;
                    StringBuilder reporte = new StringBuilder();

                    switch (tipoVehiculo)
                    {
                        case "Motocicleta":
                            reporte.AppendLine(EncabezadoMotocicleta());
                            foreach (Motocicleta m in listMotocicletaReporte)
                            {
                                reporte.AppendLine(m.MostrarEnFormatoCSV());
                                reporte.AppendLine(Estadistica<Motocicleta>.GetPorcentajesVehiculosPorCombustible(listMotocicletaReporte));
                            }
                            break;
                        case "Auto":
                            reporte.AppendLine(EncabezadoAutomovil());
                            foreach (Auto a in listAutosReporte)
                            {
                                reporte.AppendLine(a.MostrarEnFormatoCSV());
                            }
                            break;
                        case "Camioneta":
                            reporte.AppendLine(EncabezadoAutomovil());
                            foreach (Camioneta c in listCamionetasReporte)
                            {
                                reporte.AppendLine(c.MostrarEnFormatoCSV());
                            }
                            break;
                    }
                    using (StreamWriter sw = new StreamWriter(pathArchivo)) { sw.WriteLine(reporte.ToString()); }
                }
            }
            catch (AtributoInvalidoException ex)
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = ex.Message;
            }
            catch (Exception)
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = "Ocurrió un error al querer exportar la lista filtrada, verifique que su reporte se muestre en pantalla";
            }
        } 

        /// <summary>
        /// Evento load que inicializa el formulario reportes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReportes_Load(object sender, EventArgs e)
        {
            try
            {
                lbl_GuardarCambios.Visible = false;
                pb_GuardarCambios.Visible = false;

                List<string> tipoAuto = new List<string> { "Auto", "Camioneta", "Motocicleta" };
                List<string> cantidadPuertas = new List<string> { "3", "5" };
                cmb_TipoVehiculo.DataSource = tipoAuto;
                cmb_CantidadPuertas.DataSource = cantidadPuertas;

                cmb_MarcaAutomovil.DataSource = Enum.GetValues(typeof(EMarcaAutomovil));
                cmb_MarcaMotocicleta.DataSource = Enum.GetValues(typeof(EMarcaMotocicleta));
                cmb_Color.DataSource = Enum.GetValues(typeof(EColor));
                cmb_TipoDeCombustible.DataSource = Enum.GetValues(typeof(ETipoCombustible));
                cmb_TipoDeTransmision.DataSource = Enum.GetValues(typeof(ETipoTransmision));

                dgv_Vehiculos.DataSource = null;
            }
            catch(Exception)
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = "Error al cargar listas de reportes.";
            }
        }

        /// <summary>
        /// Boton que llama al metodo exportarReporte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Exportar_Click(object sender, EventArgs e)
        {
            lbl_Errores.Visible = false;
            ExportarReporte(cmb_TipoVehiculo.Text);
        }

        // ------------------------------------------------------------------------------------- ACTUALIZACION DATA GRID FILTRADO
        /// <summary>
        /// Actualiza el data grid por tipo de vehiculo a filtrar, y 
        /// asigna a la lista del tipo elegido para los reportes
        /// </summary>
        /// <param name="tipoVehiculo"></param>
        private void CargarVehiculosPorTipoVehiculo(string tipoVehiculo)
        {
            try
            {
                btn_Eliminar.Enabled = false;
                btn_Modificar.Enabled = false;

                dgv_Vehiculos.DataSource = null;

                lbl_CantidadDePuertas.Visible = true;
                cmb_CantidadPuertas.Visible = true;

                cmb_MarcaAutomovil.Visible = true;
                cmb_MarcaMotocicleta.Visible = false;

                lbl_CantidadDePuertas.Visible = false;
                cmb_CantidadPuertas.Visible = false;

                switch (tipoVehiculo)
                {
                    case "Motocicleta":
                        if(Concesionaria.listMotocicletas.Count > 0)
                        {
                            cmb_MarcaAutomovil.Visible = false;
                            cmb_MarcaMotocicleta.Visible = true;
                            listMotocicletaReporte = Concesionaria.listMotocicletas.Where(c => c.Estado == 1).OrderBy(m => m.Nombre).ToList(); // .Where(m => m.Color == EColor.Rojo)
                            dgv_Vehiculos.DataSource = listMotocicletaReporte;
                        }
                        break;
                    case "Auto":
                        if (Concesionaria.listAutos.Count > 0)
                        {
                            lbl_CantidadDePuertas.Visible = true;
                            cmb_CantidadPuertas.Visible = true;
                            listAutosReporte = Concesionaria.listAutos.Where(c => c.Estado == 1).OrderBy(m => m.Nombre).ToList();
                            dgv_Vehiculos.DataSource = listAutosReporte;
                        }
                        break;
                    case "Camioneta":
                        if (Concesionaria.listCamionetas.Count > 0)
                        {
                            lbl_CantidadDePuertas.Visible = true;
                            cmb_CantidadPuertas.Visible = true;
                            listCamionetasReporte = Concesionaria.listCamionetas.Where(c => c.Estado == 1).OrderBy(m => m.Nombre).ToList();
                            dgv_Vehiculos.DataSource = listCamionetasReporte;
                        }
                        break;
                }
                dgv_Vehiculos.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = $"Ocurrió un error al cargar lista de {tipoVehiculo}s.";
            }
        }

        /// <summary>
        /// Actualiza el data grid por marca de automovil a filtrar (auto - camioneta) y
        /// asigna a la lista del reporte el filtrado
        /// </summary>
        /// <param name="tipoVehiculo"></param>
        /// <param name="marca"></param>
        private void CargarVehiculosPorMarcaAutomovil(string tipoVehiculo, EMarcaAutomovil marca)
        {
            try
            {
                dgv_Vehiculos.DataSource = null;
                btn_Eliminar.Enabled = false;
                btn_Modificar.Enabled = false;
                if (tipoVehiculo == "Auto")
                {
                    listAutosReporte = Concesionaria.listAutos.Where(m => m.Marca == marca && m.Estado == 1).OrderBy(m => m.Nombre).ToList();
                    dgv_Vehiculos.DataSource = listAutosReporte;
                }
                else if (tipoVehiculo == "Camioneta")
                {
                    listCamionetasReporte = Concesionaria.listCamionetas.Where(m => m.Marca == marca && m.Estado == 1).OrderBy(m => m.Nombre).ToList();

                    dgv_Vehiculos.DataSource = listCamionetasReporte;
                }
                dgv_Vehiculos.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = $"Ocurrió un error al cargar lista por marca {marca}.";
            }
        }

        /// <summary>
        /// Actualiza el data grid por marca motocicleta a filtrar y 
        /// asigna a la lista de reporte motocicleta el filtrado
        /// </summary>
        /// <param name="tipoVehiculo"></param>
        /// <param name="marca"></param>
        private void CargarVehiculosPorMarcaMotocicleta(string tipoVehiculo, EMarcaMotocicleta marca)
        {
            try
            {
                btn_Eliminar.Enabled = false;
                btn_Modificar.Enabled = false;
                dgv_Vehiculos.DataSource = null;
                listMotocicletaReporte = Concesionaria.listMotocicletas.Where(m => m.Marca == marca && m.Estado == 1).OrderBy(m => m.Nombre).ToList();
                dgv_Vehiculos.DataSource = listMotocicletaReporte;
                dgv_Vehiculos.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = $"Ocurrió un error al cargar lista por marca {marca}.";
            }
        }

        /// <summary>
        /// Actualiza el data grid por color a filtrar y 
        /// carga la lista el filtrado del tipo del vehiculo elegido 
        /// </summary>
        /// <param name="tipoVehiculo"></param>
        /// <param name="color"></param>
        private void CargarVehiculosPorColor(string tipoVehiculo, EColor color)
        {
            try
            {
                btn_Eliminar.Enabled = false;
                btn_Modificar.Enabled = false;
                dgv_Vehiculos.DataSource = null;
                if (tipoVehiculo == "Auto")
                {
                    listAutosReporte = Concesionaria.listAutos.Where(m => m.Color == color && m.Estado == 1).OrderBy(m => m.Nombre).ToList();
                    dgv_Vehiculos.DataSource = listAutosReporte;
                }
                else if (tipoVehiculo == "Camioneta")
                {
                    listCamionetasReporte = Concesionaria.listCamionetas.Where(m => m.Color == color && m.Estado == 1).OrderBy(m => m.Nombre).ToList();
                    dgv_Vehiculos.DataSource = listCamionetasReporte;
                }
                else if (tipoVehiculo == "Motocicleta")
                {
                    dgv_Vehiculos.DataSource = null;
                    listMotocicletaReporte = Concesionaria.listMotocicletas.Where(m => m.Color == color && m.Estado == 1).OrderBy(m => m.Nombre).ToList();
                    dgv_Vehiculos.DataSource = listMotocicletaReporte;
                }
                dgv_Vehiculos.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = $"Ocurrió un error al cargar lista por color {color}.";
            }
        }

        /// <summary>
        /// Actualiza el data grid por cantidad de puertas a filtrar y 
        /// carga la lista el filtrado del tipo del vehiculo elegido  (auto - camioneta)
        /// </summary>
        /// <param name="tipoVehiculo"></param>
        /// <param name="cantPuertas"></param>
        private void CargarAutomovilesPorCantidadPuertas(string tipoVehiculo, int cantPuertas)
        {
            try
            {
                btn_Eliminar.Enabled = false;
                btn_Modificar.Enabled = false;
                dgv_Vehiculos.DataSource = null;
                if (tipoVehiculo == "Auto")
                {
                    listAutosReporte = Concesionaria.listAutos.Where(m => m.CantidadPuertas == cantPuertas && m.Estado == 1).OrderBy(m => m.Nombre).ToList();
                    dgv_Vehiculos.DataSource = listAutosReporte;
                }
                else if (tipoVehiculo == "Camioneta")
                {
                    listCamionetasReporte = Concesionaria.listCamionetas.Where(m => m.CantidadPuertas == cantPuertas && m.Estado == 1).OrderBy(m => m.Nombre).ToList();
                    dgv_Vehiculos.DataSource = listCamionetasReporte;
                }
                dgv_Vehiculos.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = $"Ocurrió un error al cargar lista por cantidad de puertas [{cantPuertas}].";
            }
        }

        /// <summary>
        /// Actualiza el data grid por tipo de combustible a filtrar y
        /// carga la lista el filtrado del tipo del vehiculo elegido
        /// </summary>
        /// <param name="tipoVehiculo"></param>
        /// <param name="tipoDeCombustible"></param>
        private void CargarVehiculosPorTipoDeCombustible(string tipoVehiculo, ETipoCombustible tipoDeCombustible)
        {
            try
            {
                btn_Eliminar.Enabled = false;
                btn_Modificar.Enabled = false;
                dgv_Vehiculos.DataSource = null;
                switch (tipoVehiculo)
                {
                    case "Auto":
                        listAutosReporte = Concesionaria.listAutos.Where(m => m.TipoCombustible == tipoDeCombustible && m.Estado == 1).OrderBy(m => m.Nombre).ToList();
                        dgv_Vehiculos.DataSource = listAutosReporte;
                        break;
                    case "Camioneta":
                        listCamionetasReporte = Concesionaria.listCamionetas.Where(m => m.TipoCombustible == tipoDeCombustible && m.Estado == 1).OrderBy(m => m.Nombre).ToList();
                        dgv_Vehiculos.DataSource = listCamionetasReporte;
                        break;
                    case "Motocicleta":
                        listMotocicletaReporte = Concesionaria.listMotocicletas.Where(m => m.TipoCombustible == tipoDeCombustible && m.Estado == 1).OrderBy(m => m.Nombre).ToList();
                        dgv_Vehiculos.DataSource = listMotocicletaReporte;
                        break;
                }
                dgv_Vehiculos.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = $"Ocurrió un error al cargar lista por tipo de combustible {tipoDeCombustible}.";
            }
        }

        /// <summary>
        /// Actualiza el data grid por tipo de transmision a filtrar y
        /// carga la lista el filtrado del tipo del vehiculo elegido
        /// </summary>
        /// <param name="tipoVehiculo"></param>
        /// <param name="tipoDeTransmision"></param>
        private void CargarVehiculosPorTipoDeTransmision(string tipoVehiculo, ETipoTransmision tipoDeTransmision)
        {
            try
            {
                btn_Eliminar.Enabled = false;
                btn_Modificar.Enabled = false;
                dgv_Vehiculos.DataSource = null;
                switch (tipoVehiculo)
                {
                    case "Auto":
                        listAutosReporte = Concesionaria.listAutos.Where(m => m.TipoTransmision == tipoDeTransmision && m.Estado == 1).OrderBy(m => m.Nombre).ToList();
                        dgv_Vehiculos.DataSource = listAutosReporte;
                        break;
                    case "Camioneta":
                        listCamionetasReporte = Concesionaria.listCamionetas.Where(m => m.TipoTransmision == tipoDeTransmision && m.Estado == 1).OrderBy(m => m.Nombre).ToList();
                        dgv_Vehiculos.DataSource = listCamionetasReporte;
                        break;
                    case "Motocicleta":
                        listMotocicletaReporte = Concesionaria.listMotocicletas.Where(m => m.TipoTransmision == tipoDeTransmision && m.Estado == 1).OrderBy(m => m.Nombre).ToList();
                        dgv_Vehiculos.DataSource = listMotocicletaReporte;
                        break;
                }
                dgv_Vehiculos.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = $"Ocurrió un error al cargar lista por tipo de transmisión {tipoDeTransmision}.";
            }
        }

        // ------------------------------------------------------------------------------------- COMBO BOX
        /// <summary>
        /// Combo box que llama al metodo para filtrar por marca motocicleta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_MarcaMotocicleta_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Errores.Visible = false;
            CargarVehiculosPorMarcaMotocicleta(cmb_TipoVehiculo.Text, (EMarcaMotocicleta)cmb_MarcaMotocicleta.SelectedItem);
        }

        /// <summary>
        /// Combo box que llama al metodo para filtrar por tipo de vehiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_TipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbl_Errores.Visible = false;
            CargarVehiculosPorTipoVehiculo(cmb_TipoVehiculo.Text);

        }

        /// <summary>
        /// Combo box que llama al metodo para filtrar por marca automovil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_MarcaAutomovil_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lbl_Errores.Visible = false;
            CargarVehiculosPorMarcaAutomovil(cmb_TipoVehiculo.Text, (EMarcaAutomovil)cmb_MarcaAutomovil.SelectedItem);
        }

        /// <summary>
        /// Combo box que llama al metodo para filtrar por color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_Color_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Errores.Visible = false;
            try
            {
                //CargarVehiculosPorColor(cmb_TipoVehiculo.Text, (EColor)cmb_Color.SelectedItem);
                switch (cmb_TipoVehiculo.Text)
                {
                    case "Auto":
                        listAutosReporte = Filtrar<Auto>.FiltrarListaPorColor(Concesionaria.listAutos, (EColor)cmb_Color.SelectedItem);
                        dgv_Vehiculos.DataSource = listAutosReporte;
                        break;
                    case "Camioneta":
                        listCamionetasReporte = Filtrar<Camioneta>.FiltrarListaPorColor(Concesionaria.listCamionetas, (EColor)cmb_Color.SelectedItem);
                        dgv_Vehiculos.DataSource = listCamionetasReporte;
                        break;
                    case "Motocicleta":
                        listMotocicletaReporte = Filtrar<Motocicleta>.FiltrarListaPorColor(Concesionaria.listMotocicletas, (EColor)cmb_Color.SelectedItem);
                        dgv_Vehiculos.DataSource = listMotocicletaReporte;
                        break;
                }
            }
            catch (AtributoInvalidoException ex)
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = ex.Message;
            }
        }

        /// <summary>
        /// Combo box que llama al metodo para filtrar por cantidad de puertas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_CantidadPuertas_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Errores.Visible = false;
            CargarAutomovilesPorCantidadPuertas(cmb_TipoVehiculo.Text, int.Parse((string)cmb_CantidadPuertas.SelectedItem));
        }

        /// <summary>
        /// Combo box que llama al metodo para filtrar por tipo de combustible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_TipoDeCombustible_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Errores.Visible = false;
            CargarVehiculosPorTipoDeCombustible(cmb_TipoVehiculo.Text, (ETipoCombustible)cmb_TipoDeCombustible.SelectedItem);
        }

        /// <summary>
        /// Combo box que llama al metodo para filtrar por tipo de transmision
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_TipoDeTransmision_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Errores.Visible = false;
            CargarVehiculosPorTipoDeTransmision(cmb_TipoVehiculo.Text, (ETipoTransmision)cmb_TipoDeTransmision.SelectedItem);
        }

        /// <summary>
        /// Txt que filtra por precio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_PrecioHasta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_PrecioHasta.Text) &&
                     float.TryParse(txt_PrecioHasta.Text, out float precioHasta) && (precioHasta > -1 && precioHasta < 999999999))
                {
                    lbl_Errores.Visible = false;
                    dgv_Vehiculos.DataSource = null;
                    switch (cmb_TipoVehiculo.Text)
                    {
                        case "Auto":
                            listAutosReporte = Concesionaria.listAutos.Where(m => m.Precio <= precioHasta && m.Estado == 1).OrderBy(m => m.Nombre).ToList();
                            dgv_Vehiculos.DataSource = listAutosReporte;
                            break;
                        case "Camioneta":
                            listCamionetasReporte = Concesionaria.listCamionetas.Where(m => m.Precio <= precioHasta && m.Estado == 1).OrderBy(m => m.Nombre).ToList();
                            dgv_Vehiculos.DataSource = listCamionetasReporte;
                            break;
                        case "Motocicleta":
                            listMotocicletaReporte = Concesionaria.listMotocicletas.Where(m => m.Precio <= precioHasta && m.Estado == 1).OrderBy(m => m.Nombre).ToList();
                            dgv_Vehiculos.DataSource = listMotocicletaReporte;
                            break;
                    }
                    dgv_Vehiculos.Columns[0].Visible = false;
                }
                else
                {
                    txt_PrecioHasta.Text = "";
                    throw new AtributoInvalidoException("Ingrese Precio valido.", "txt_PrecioHasta, en Formulario Base Vehículos"); 
                }
            }
            catch (AtributoInvalidoException ex)
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text= ex.Message;
            }
            catch (Exception ex)
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = "Ocurrió un error. Ingrese Precio valido.";
            }
        }

        /// <summary>
        /// Txt que filtra por kilometros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_KmHasta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float kmHasta = 0;
                if (!string.IsNullOrEmpty(txt_KmHasta.Text) &&
                    float.TryParse(txt_KmHasta.Text, out kmHasta) && (kmHasta > -1 && kmHasta < 999999999))
                {
                    lbl_Errores.Visible = false;
                    dgv_Vehiculos.DataSource = null;
                    switch (cmb_TipoVehiculo.Text)
                    {
                        case "Auto":
                            listAutosReporte = Concesionaria.listAutos.Where(m => m.Km <= kmHasta && m.Estado == 1).OrderBy(m => m.Nombre).ToList();
                            dgv_Vehiculos.DataSource = listAutosReporte;
                            break;
                        case "Camioneta":
                            listCamionetasReporte = Concesionaria.listCamionetas.Where(m => m.Km <= kmHasta && m.Estado == 1).OrderBy(m => m.Nombre).ToList();
                            dgv_Vehiculos.DataSource = listCamionetasReporte;
                            break;
                        case "Motocicleta":
                            listMotocicletaReporte = Concesionaria.listMotocicletas.Where(m => m.Km <= kmHasta && m.Estado == 1).OrderBy(m => m.Nombre).ToList();
                            dgv_Vehiculos.DataSource = listMotocicletaReporte;
                            break;
                    }
                    dgv_Vehiculos.Columns[0].Visible = false;

                } else {
                    txt_KmHasta.Text = "";
                    throw new AtributoInvalidoException("Ingrese Kilómetros validos.", "txt_KmHasta, en Formulario Base Vehículos"); 
                }
            }
            catch (AtributoInvalidoException ex)
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = "Ocurrió un error. Ingrese Kilómetros validos.";
            }
        }

        /// <summary>
        /// Boton que llama al formulario FrmAltaModificar para dar de alta un vehiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAltaModificar frmAlta = new FrmAltaModificar(false);
                frmAlta.Text = "Alta de un Vehículo - VL MOTORS" + " - " + DateTime.Now.ToString("d");
                frmAlta.lbl_Titulo.Text = "Alta de un Vehículo";
                frmAlta.ShowDialog();
                btn_Modificar.Enabled = false;
                btn_Eliminar.Enabled = false;
                dgv_Vehiculos.DataSource = null;
            }
            catch (Exception ex)
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = ex.Message;
            }
        }

        /// <summary>
        /// Boton que llama al formulario FrmAltaModificar para dar mofificar un vehiculo seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAltaModificar frmModificar = new FrmAltaModificar(true, GetVehiculoSeleccionado());
                frmModificar.Text = "Modificación de un Vehículo - VL MOTORS" + " - " + DateTime.Now.ToString("d");
                frmModificar.lbl_Titulo.Text = "Modificación de un Vehículo";
                frmModificar.ShowDialog();
                CargarVehiculosPorTipoVehiculo(cmb_TipoVehiculo.Text);
            }
            catch (Exception ex)
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = ex.Message;
            }
        }

        /// <summary>
        /// Boton que llama al formulario FrmAltaModificar para dar de baja logica un vehiculo seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Vehiculo vehiculoBaja = GetVehiculoSeleccionado();
                bool okDeleteDB =  ManejadoraSql.DeleteVehiculo(cmb_TipoVehiculo.Text, GetIdVehiculoSeleccionado());
                vehiculoBaja.Estado = 0;
                if (vehiculoBaja.Estado == 0 && okDeleteDB)
                {
                    MessageBox.Show("Baja del vehículo realizada.", "¡Información!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarVehiculosPorTipoVehiculo(cmb_TipoVehiculo.Text);
                }
            }
            catch (Exception ex)
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = "Ocurrió un error al querer dar de baja el vehiculo.";
            }
        }

        //------------------------------------------------------- Obtencion del vehiculo seleccionado

        /// <summary>
        /// Evento clicl del data grid
        /// Obtiene el vehiculo seleccionado y muestra por pantalla sus datos con detalles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Vehiculos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lbl_Errores.Visible = false;
                Vehiculo vehiculoSeleccionado = GetVehiculoSeleccionado();

                if (vehiculoSeleccionado != null)
                {
                    btn_Eliminar.Enabled = true;
                    btn_Modificar.Enabled = true;
                }

                switch (vehiculoSeleccionado)
                {
                    case Auto:
                        Auto autoSeleccionado = (Auto)vehiculoSeleccionado;
                        MessageBox.Show(autoSeleccionado.MostrarDetalle());
                        break;
                    case Camioneta:
                        Camioneta camionetataSeleccionada = (Camioneta)vehiculoSeleccionado;
                        MessageBox.Show(camionetataSeleccionada.MostrarDetalle());
                        break;
                    case Motocicleta:
                        Motocicleta motocicletaSeleccionada = (Motocicleta)vehiculoSeleccionado;
                        MessageBox.Show(motocicletaSeleccionada.MostrarDetalle());
                        break;
                }
            }
            catch (Exception)
            {
                throw new Exception("Error al obtener vehículo seleccionado.");
            }
        }

        /// <summary>
        /// Obtiene vehiculo seleccionado
        /// </summary>
        /// <returns></returns>
        private Vehiculo GetVehiculoSeleccionado()
        {
            Vehiculo vehiculoSeleccionado = null;
            try
            {
                if(dgv_Vehiculos.CurrentRow.Cells[0].Value is null)
                    throw new Exception("Error, no ha seleccionado un vehículo.");

                switch (cmb_TipoVehiculo.Text)
                {
                    case "Auto":
                        vehiculoSeleccionado =  Concesionaria.listAutos.First(a => a.Id.ToString() == dgv_Vehiculos.CurrentRow.Cells[0].Value.ToString());
                        break;
                    case "Camioneta":
                        vehiculoSeleccionado = Concesionaria.listCamionetas.First(a => a.Id.ToString() == dgv_Vehiculos.CurrentRow.Cells[0].Value.ToString());
                        break;
                    case "Motocicleta":
                        vehiculoSeleccionado = Concesionaria.listMotocicletas.First(a => a.Id.ToString() == dgv_Vehiculos.CurrentRow.Cells[0].Value.ToString());
                        break;
                }

            }
            catch(Exception )
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = "Error al buscar vehículo. Intente haciendo doble click en el vehículo.";
            }
            return vehiculoSeleccionado;
        }

        private int GetIdVehiculoSeleccionado()
        {
            int idSeleccionado = 0;
            try
            {
                if (dgv_Vehiculos.CurrentRow.Cells[0].Value is null)
                    throw new Exception("Error, no ha seleccionado un vehículo.");

                switch (cmb_TipoVehiculo.Text)
                {
                    case "Auto":
                        idSeleccionado = Concesionaria.listAutos.Find(a => (a.Id == (int)dgv_Vehiculos.CurrentRow.Cells[0].Value)).Id;
                        break;
                    case "Camioneta":
                        idSeleccionado = Concesionaria.listCamionetas.Find(a => (a.Id == (int)dgv_Vehiculos.CurrentRow.Cells[0].Value)).Id;
                        break;
                    case "Motocicleta":
                        idSeleccionado = Concesionaria.listMotocicletas.Find(a => (a.Id == (int)dgv_Vehiculos.CurrentRow.Cells[0].Value)).Id;
                        break;
                }
            }
            catch (Exception)
            {
                lbl_Errores.Visible = true;
                lbl_Errores.Text = "Error al buscar vehículo. Intente haciendo doble click en el vehículo de la grilla.";
            }
            return idSeleccionado;
        }


    }
}
