using Entidades.Enumerados;
using Entidades.Interfaz;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo, IAutomovil
    {
        static int ultimoId;
        int id;
        EMarcaAutomovil marca;
        int cantidadPuertas;

        event Financiar InformarFinanciacion;

        #region Constructores

        /// <summary>
        /// Constructor estatico, inicializa el ultimo Id en 0
        /// </summary>
        static Auto()
        { 
            ultimoId = 0;
        }

        public Auto(EMarcaAutomovil marca, string nombre, int año, int km, ETipoCombustible tipoCombustible, ETipoTransmision tipoTransmision,
                    EColor color, float precio,  int cantidadPuertas)
            : base(nombre, año, km, tipoCombustible, tipoTransmision, color, precio)
        {
            try
            {
                ultimoId = ManejadoraSql.GetIdMaxVehiculo("Auto");
                this.id = ultimoId + 1;
                ultimoId = this.id;

                this.Marca = marca;
                this.cantidadPuertas = cantidadPuertas;
                InformarFinanciacion += GetCaracteristicasFinanciacion;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Constructor con campo ID, para poder leer datos desde la base de datos
        /// ya que posee ID IDENTITY
        /// </summary>
        public Auto(int id, EMarcaAutomovil marca, string nombre, int año, int km, ETipoCombustible tipoCombustible, ETipoTransmision tipoTransmision,
                    EColor color, float precio, int cantidadPuertas)
                   : base(nombre, año, km, tipoCombustible, tipoTransmision, color, precio)
        {
            this.id = id;
            ultimoId = this.id; // no hace falta

            this.Marca = marca;
            this.cantidadPuertas = cantidadPuertas;

            InformarFinanciacion += GetCaracteristicasFinanciacion;
        }

        #endregion

        #region Propiedades

        public int Id
        {
            get { return this.id; }
        }
        public int CantidadPuertas
        {
            get { return this.cantidadPuertas; } 
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    throw new AtributoInvalidoException("Ingrese cantidad de puertas válidas (3 o 5).", "Propiedad CantidadPuertas, en Clase Auto");
                else
                    this.cantidadPuertas = value;
            }
        }

        public EMarcaAutomovil Marca
        {
            get { return this.marca; }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    throw new Exception("Ingrese una Marca válida.");
                else
                    this.marca = value;
            }
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Calcula financiacion del vehiculo, arma el texto y lo retorna.
        /// </summary>
        /// <returns> Datos de financiacion </returns>
        public override string GetCaracteristicasFinanciacion()
        {
            StringBuilder financiacion = new StringBuilder();
            int añosVehiculo = int.Parse(DateTime.Now.ToString("yyyy")) - this.Año;

            Financiacion.GetCuotasYRecargo(añosVehiculo, out int cuotas, out int porcentajeRecargo);

            if (this.Km == 0)
                porcentajeRecargo += 5;

            float precioFinalVehiculo = Financiacion.GetPrecioFinalConRecargo(porcentajeRecargo, this.Precio);

            int añosCuotas = Financiacion.GetAñosCuotas(cuotas);

            float pagoPorCuota = Financiacion.GetPagoPorCuotas(precioFinalVehiculo, cuotas);

            financiacion.AppendLine($"Financiable en {cuotas} cuotas de $ {pagoPorCuota}.");
            financiacion.Append($"Con un recargo del % {porcentajeRecargo}");
            if (this.Km == 0) { financiacion.AppendLine(", de los cuales % 5 son impuestos por ser 0 Km."); } else { financiacion.AppendLine("."); }
            financiacion.Append($"Precio final del Vehículo: $ {precioFinalVehiculo}, a pagar en {añosCuotas} ");
            if (añosCuotas == 1) { financiacion.Append("año."); } else { financiacion.AppendLine("años."); }

            return financiacion.ToString();
        }

 
        public override string MostrarDetalle()
        {
            StringBuilder sw = new StringBuilder();
            sw.AppendLine($"Marca: {Marca}");
            sw.AppendLine($"Nombre: {Nombre}");
            sw.AppendLine($"Año: {Año}");
            sw.AppendLine($"Kilómetros: {Km}");
            sw.AppendLine($"Tipo de Combustible: {TipoCombustible}");
            sw.AppendLine($"Tipo de Transmisión: {TipoTransmision}");
            sw.AppendLine($"Color: {Color}");
            sw.AppendLine($"Precio: $ {Precio}");
            sw.AppendLine($"Cantidad de puertas: {cantidadPuertas}");
            sw.AppendLine("");
            sw.AppendLine("");
            sw.Append(InformarFinanciacion.Invoke());
            return sw.ToString();
        }

        public override string MostrarEnFormatoCSV()
        {
            StringBuilder sw = new StringBuilder();
            sw.Append($"{Marca}," +
                          $"{Nombre}," +
                          $"{Año}," +
                          $"{Km}," +
                          $"{TipoCombustible}," +
                          $"{TipoTransmision}," +
                          $"{Color}," +
                          $"{Precio}," +
                          $"{CantidadPuertas}");
            return sw.ToString();
        }
        #endregion
    }
}
