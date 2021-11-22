using Entidades;
using Entidades.Enumerados;
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

namespace Formularios
{
    public partial class FrmAltaModificar : Form
    {
        Auto autoSeleccionado;
        Camioneta camionetataSeleccionada;
        Motocicleta motocicletaSeleccionada;
        Vehiculo vehiculoSeleccionado;
        bool quieroModificar;

        public FrmAltaModificar()
        {
            InitializeComponent();
        }
        public FrmAltaModificar(bool quieroModificar) : this()
        {
            this.quieroModificar = quieroModificar;
        }
        public FrmAltaModificar(bool quieroModificar, Vehiculo vehiculoSeleccionado) : this (quieroModificar)
        {
            this.vehiculoSeleccionado = vehiculoSeleccionado;
        }

        /// <summary>
        /// Da de alta un vehiculo del tipo especificado en el combo box
        /// </summary>
        /// <returns></returns>
        private bool DarAltaVehiculo()
        {
            bool retorno = false;
            try
            {
                if (ValidarCampos())
                {
                    switch (cmb_TipoVehiculo.Text)
                    {
                        case "Auto":
                            Concesionaria.listAutos.Add(new Auto((EMarcaAutomovil)cmb_MarcaAutomovil.SelectedIndex,
                                                        txt_Nombre.Text,
                                                        int.Parse(txt_Año.Text),
                                                        int.Parse(txt_Km.Text),
                                                        (ETipoCombustible)cmb_TipoDeCombustible.SelectedIndex,
                                                        (ETipoTransmision)cmb_TipoDeTransmision.SelectedIndex,
                                                        (EColor)cmb_Color.SelectedIndex,
                                                        float.Parse(txt_Precio.Text),
                                                        int.Parse(cmb_CantidadPuertas.Text)));
                            retorno = true;
                            break;
                        case "Camioneta":
                            Concesionaria.listCamionetas.Add(new Camioneta((EMarcaAutomovil)cmb_MarcaAutomovil.SelectedIndex,
                                                                            txt_Nombre.Text,
                                                                            int.Parse(txt_Año.Text),
                                                                            int.Parse(txt_Km.Text),
                                                                            (ETipoCombustible)cmb_TipoDeCombustible.SelectedIndex,
                                                                            (ETipoTransmision)cmb_TipoDeTransmision.SelectedIndex,
                                                                            (EColor)cmb_Color.SelectedIndex,
                                                                            float.Parse(txt_Precio.Text),
                                                                            int.Parse(cmb_CantidadPuertas.Text)));
                            retorno = true;
                            break;
                        case "Motocicleta":
                            Concesionaria.listMotocicletas.Add(new Motocicleta((EMarcaMotocicleta)cmb_MarcaMotocicleta.SelectedIndex,
                                                                                txt_Nombre.Text,
                                                                                int.Parse(txt_Año.Text),
                                                                                int.Parse(txt_Km.Text),
                                                                                (ETipoCombustible)cmb_TipoDeCombustible.SelectedIndex,
                                                                                (ETipoTransmision)cmb_TipoDeTransmision.SelectedIndex,
                                                                                (EColor)cmb_Color.SelectedIndex,
                                                                                float.Parse(txt_Precio.Text)));
                            retorno = true;
                            break;
                    }
                }
            }
            catch (AtributoInvalidoException ex)
            {
                lbl_Informar.Visible = true;
                lbl_Informar.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lbl_Informar.Visible = true;
                lbl_Informar.Text = ex.Message;
            }
            return retorno;
        }

        /// <summary>
        /// Modifica un vehiculo del tipo especificado en el combo box
        /// </summary>
        private void ModificarVehiculo()
        {
            try
            { 
                if(ValidarCampos())
                {
                    switch (cmb_TipoVehiculo.Text)
                    {
                        case "Auto":
                            if (autoSeleccionado != null)
                            {
                                autoSeleccionado.Nombre = txt_Nombre.Text;
                                autoSeleccionado.Marca = (EMarcaAutomovil)cmb_MarcaAutomovil.SelectedIndex;
                                autoSeleccionado.Precio = float.Parse(txt_Precio.Text);
                                autoSeleccionado.Km = int.Parse(txt_Km.Text);
                                autoSeleccionado.Año = int.Parse(txt_Año.Text);
                                autoSeleccionado.Color = (EColor)cmb_Color.SelectedIndex;
                                autoSeleccionado.TipoCombustible = (ETipoCombustible)cmb_TipoDeCombustible.SelectedIndex;
                                autoSeleccionado.TipoTransmision = (ETipoTransmision)cmb_TipoDeTransmision.SelectedIndex;
                                autoSeleccionado.CantidadPuertas = int.Parse(cmb_CantidadPuertas.Text);
                            }
                            break;
                        case "Camioneta":
                            if (camionetataSeleccionada != null)
                            {
                                camionetataSeleccionada.Nombre = txt_Nombre.Text;
                                camionetataSeleccionada.Marca = (EMarcaAutomovil)cmb_MarcaAutomovil.SelectedIndex;
                                camionetataSeleccionada.Precio = float.Parse(txt_Precio.Text);
                                camionetataSeleccionada.Km = int.Parse(txt_Km.Text);
                                camionetataSeleccionada.Año = int.Parse(txt_Año.Text);
                                camionetataSeleccionada.Color = (EColor)cmb_Color.SelectedIndex;
                                camionetataSeleccionada.TipoCombustible = (ETipoCombustible)cmb_TipoDeCombustible.SelectedIndex;
                                camionetataSeleccionada.TipoTransmision = (ETipoTransmision)cmb_TipoDeTransmision.SelectedIndex;
                                camionetataSeleccionada.CantidadPuertas = int.Parse(cmb_CantidadPuertas.Text);
                            }
                            break;
                        case "Motocicleta":
                            if (motocicletaSeleccionada != null)
                            {
                                motocicletaSeleccionada.Nombre = txt_Nombre.Text;
                                motocicletaSeleccionada.Marca = (EMarcaMotocicleta)cmb_MarcaMotocicleta.SelectedIndex;
                                motocicletaSeleccionada.Precio = float.Parse(txt_Precio.Text);
                                motocicletaSeleccionada.Km = int.Parse(txt_Km.Text);
                                motocicletaSeleccionada.Año = int.Parse(txt_Año.Text);
                                motocicletaSeleccionada.Color = (EColor)cmb_Color.SelectedIndex;
                                motocicletaSeleccionada.TipoCombustible = (ETipoCombustible)cmb_TipoDeCombustible.SelectedIndex;
                                motocicletaSeleccionada.TipoTransmision = (ETipoTransmision)cmb_TipoDeTransmision.SelectedIndex;
                            }
                            break;
                    }
                }
            }
            catch (AtributoInvalidoException ex)
            {
                lbl_Informar.Visible = true;
                lbl_Informar.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lbl_Informar.Visible = true;
                lbl_Informar.Text = ex.Message;
            }
        }

        /// <summary>
        /// Valida los campos asignados
        /// </summary>
        private bool ValidarCampos()
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Nombre.Text))
                    throw new AtributoInvalidoException("Nombre ingresado inválido.", "txt_Nombre, en método ValidarCampos, formulario AltaModificar");

                if (!float.TryParse(txt_Precio.Text, out float precioValido) || precioValido < 0 || precioValido > 999999999)
                    throw new AtributoInvalidoException("Precio ingresado inválido.", "txt_Precio, en método ValidarCampos, formulario AltaModificar");

                if (cmb_TipoVehiculo.Text != "Motocicleta" && 
                    !int.TryParse(cmb_CantidadPuertas.Text, out int puertas))
                    throw new AtributoInvalidoException("Cantidad puertas ingresado inválido.", "cmb_CantidadPuertas, en método ValidarCampos, formulario AltaModificar");

                if (!int.TryParse(txt_Km.Text, out int km) || km < 0 || km > 999999)
                    throw new AtributoInvalidoException("Kilómetros ingresados inválido.", "txt_Km, en método ValidarCampos, formulario AltaModificar");

                if (!int.TryParse(txt_Año.Text, out int año) || año < 1900 || año > DateTime.Now.Year)
                    throw new AtributoInvalidoException("Año ingresado inválido.", "txt_Km, en método ValidarCampos, formulario AltaModificar");
               
                return true;
            }
            catch(AtributoInvalidoException ex)
            {
                lbl_Informar.Visible = true;
                lbl_Informar.Text = ex.Message;
            }
            catch(Exception ex)
            {
                lbl_Informar.Visible = true;
                lbl_Informar.Text = "Verifique que los datos ingresados sean válidos.";
            }
            return false;
        }

        /// <summary>
        /// Prepara el entorno del formulario para poder modificar el vehiculo seleccionado
        /// </summary>
        private void PrepararModificacionVehiculo()
        {
            try
            {
                btn_Accion.Text = "Modificar";

                if(this.vehiculoSeleccionado is null)
                    throw new AtributoInvalidoException("No se ha seleccionado un vehículo.", "vehiculoSeleccionado, en método PrepararModificacionVehiculo (FrmAltaModificar).");

                switch (this.vehiculoSeleccionado)
                {
                    case Auto:
                        autoSeleccionado = (Auto)vehiculoSeleccionado;
                        cmb_TipoVehiculo.DataSource = new List<string> { "Auto" };
                        cmb_MarcaAutomovil.Visible = true;
                        lbl_CantidadDePuertas.Visible = true;
                        cmb_CantidadPuertas.Visible = true;

                        cmb_MarcaAutomovil.DataSource = Enum.GetValues(typeof(EMarcaAutomovil));
                        cmb_MarcaAutomovil.SelectedIndex = (int)autoSeleccionado.Marca;

                        cmb_Color.DataSource = Enum.GetValues(typeof(EColor));
                        cmb_Color.SelectedIndex = (int)autoSeleccionado.Color;

                        cmb_TipoDeCombustible.DataSource = Enum.GetValues(typeof(ETipoCombustible));
                        cmb_TipoDeCombustible.SelectedIndex = (int)autoSeleccionado.TipoCombustible;

                        cmb_TipoDeTransmision.DataSource = Enum.GetValues(typeof(ETipoTransmision));
                        cmb_TipoDeTransmision.SelectedIndex = (int)autoSeleccionado.TipoTransmision;

                        cmb_CantidadPuertas.DataSource = new List<string> { $"{autoSeleccionado.CantidadPuertas.ToString()}" };

                        txt_Nombre.Text = autoSeleccionado.Nombre;
                        txt_Km.Text = autoSeleccionado.Km.ToString();
                        txt_Precio.Text = autoSeleccionado.Precio.ToString();
                        txt_Año.Text = autoSeleccionado.Año.ToString();
                        break;
                    case Camioneta:
                        camionetataSeleccionada = (Camioneta)vehiculoSeleccionado;
                        cmb_TipoVehiculo.DataSource = new List<string> { "Camioneta" };
                        cmb_MarcaAutomovil.Visible = true;
                        lbl_CantidadDePuertas.Visible = true;
                        cmb_CantidadPuertas.Visible = true;

                        cmb_MarcaAutomovil.DataSource = Enum.GetValues(typeof(EMarcaAutomovil));
                        cmb_MarcaAutomovil.SelectedIndex = (int)camionetataSeleccionada.Marca;

                        cmb_Color.DataSource = Enum.GetValues(typeof(EColor));
                        cmb_Color.SelectedIndex = (int)camionetataSeleccionada.Color;

                        cmb_TipoDeCombustible.DataSource = Enum.GetValues(typeof(ETipoCombustible));
                        cmb_TipoDeCombustible.SelectedIndex = (int)camionetataSeleccionada.TipoCombustible;

                        cmb_TipoDeTransmision.DataSource = Enum.GetValues(typeof(ETipoTransmision));
                        cmb_TipoDeTransmision.SelectedIndex = (int)camionetataSeleccionada.TipoTransmision;

                        cmb_CantidadPuertas.DataSource = new List<string> { $"{camionetataSeleccionada.CantidadPuertas.ToString()}" };

                        txt_Nombre.Text = camionetataSeleccionada.Nombre;
                        txt_Km.Text = camionetataSeleccionada.Km.ToString();
                        txt_Precio.Text = camionetataSeleccionada.Precio.ToString();
                        txt_Año.Text = camionetataSeleccionada.Año.ToString();
                        break;
                    case Motocicleta:
                        motocicletaSeleccionada = (Motocicleta)vehiculoSeleccionado;
                        cmb_TipoVehiculo.DataSource = new List<string> { "Motocicleta" };
                        cmb_MarcaMotocicleta.Visible = true;

                        cmb_MarcaMotocicleta.DataSource = Enum.GetValues(typeof(EMarcaMotocicleta));
                        cmb_MarcaMotocicleta.SelectedIndex = (int)motocicletaSeleccionada.Marca;

                        cmb_Color.DataSource = Enum.GetValues(typeof(EColor));
                        cmb_Color.SelectedIndex = (int)motocicletaSeleccionada.Color;

                        cmb_TipoDeCombustible.DataSource = Enum.GetValues(typeof(ETipoCombustible));
                        cmb_TipoDeCombustible.SelectedIndex = (int)motocicletaSeleccionada.TipoCombustible;

                        cmb_TipoDeTransmision.DataSource = Enum.GetValues(typeof(ETipoTransmision));
                        cmb_TipoDeTransmision.SelectedIndex = (int)motocicletaSeleccionada.TipoTransmision;

                        txt_Nombre.Text = motocicletaSeleccionada.Nombre;
                        txt_Km.Text = motocicletaSeleccionada.Km.ToString();
                        txt_Precio.Text = motocicletaSeleccionada.Precio.ToString();
                        txt_Año.Text = motocicletaSeleccionada.Año.ToString();
                        break;
                }
            }
            catch (AtributoInvalidoException ex)
            {
                lbl_Informar.Visible = true;
                lbl_Informar.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lbl_Informar.Visible = true;
                lbl_Informar.Text = "Ocurrió al intentar preparar el entorno de modificación del vehículo.";
            }
        }


        /// <summary>
        /// Prepara el entorno del formulario para poder dar de alta un nuevo vehiculo 
        /// </summary>
        private void PrepararAltaVehiculo()
        {
            btn_Accion.Text = "AGREGAR";
            cmb_MarcaAutomovil.Visible = true;
            cmb_TipoVehiculo.DataSource = new List<string> { "Auto", "Camioneta", "Motocicleta" };
            cmb_CantidadPuertas.DataSource = new List<string> { "3", "5" };
            cmb_MarcaAutomovil.DataSource = Enum.GetValues(typeof(EMarcaAutomovil));
            cmb_MarcaMotocicleta.DataSource = Enum.GetValues(typeof(EMarcaMotocicleta));
            cmb_Color.DataSource = Enum.GetValues(typeof(EColor));
            cmb_TipoDeCombustible.DataSource = Enum.GetValues(typeof(ETipoCombustible));
            cmb_TipoDeTransmision.DataSource = Enum.GetValues(typeof(ETipoTransmision));
        }

        /// <summary>
        /// Evento load, verifica si el formulario es para modificar o dar de alta 
        /// y prepara el entorno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltaModificar_Load(object sender, EventArgs e)
        {
            try
            {
                switch (quieroModificar)
                {
                    case true:
                        PrepararModificacionVehiculo();
                        break;
                    case false:
                        PrepararAltaVehiculo();
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "¡Error!", MessageBoxButtons.OK,  MessageBoxIcon.Error);
                this.Close();
            }
        }

        /// <summary>
        /// Boton que realiza la accion especificada, alta o modificacion de un vehiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Accion_Click(object sender, EventArgs e)
        {
            try
            {
                switch (this.quieroModificar)
                {
                    case true:
                        if(ValidarCampos())
                        {
                            ModificarVehiculo();
                            MessageBox.Show("Modificación del vehículo con éxito.");
                            this.Close();
                        }
                        break;
                    case false:
                        if (ValidarCampos() && DarAltaVehiculo())
                        {
                            MessageBox.Show("Alta del vehículo con éxito.");
                            this.Close();
                        }
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al querer confirmar acción.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        /// <summary>
        /// Hace visible las marcas dependiendo el tipo de Vehículo que se eliga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_TipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_TipoVehiculo.Text)
            {
                case "Auto":
                case "Camioneta":
                    cmb_MarcaMotocicleta.Visible = false;
                    cmb_MarcaAutomovil.Visible = true;
                    break;
                case "Motocicleta":
                    cmb_MarcaAutomovil.Visible = false;
                    cmb_MarcaMotocicleta.Visible = true;
                    break;
            }
        }
    }
}
