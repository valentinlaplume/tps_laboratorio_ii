using Entidades.Enumerados;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Motocicleta : Vehiculo
    {
        static int ultimoId;
        int id;
        EMarcaMotocicleta marca;

        private event Financiar InformarFinanciacion;

        #region Constructores

        /// <summary>
        /// Constructor estatico, inicializa el ultimo Id en 0
        /// </summary>
        static Motocicleta()
        {
            ultimoId = 0;
        }
        public Motocicleta() { }

        public Motocicleta(EMarcaMotocicleta marca, string nombre, int año, int km,
                           ETipoCombustible tipoCombustible, ETipoTransmision tipoTransmision,
                           EColor color, float precio) 
            : base (nombre, año, km, tipoCombustible, tipoTransmision, color, precio)
        {
            try
            {
                ultimoId = ManejadoraSql.GetIdMaxVehiculo("Motocicleta");
                this.id = ultimoId + 1;
                ultimoId = this.id;

                this.Marca = marca;
                InformarFinanciacion += GetCaracteristicasFinanciacion;
            }
            catch(Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Constructor con campo ID, para poder leer datos desde la base de datos
        /// ya que posee ID IDENTITY
        /// </summary>
        public Motocicleta(int id, EMarcaMotocicleta marca, string nombre, int año, int km,
                   ETipoCombustible tipoCombustible, ETipoTransmision tipoTransmision,
                   EColor color, float precio)
                : base(nombre, año, km, tipoCombustible, tipoTransmision, color, precio)
        {
            this.id = id;
            ultimoId = this.id;

            this.Marca = marca;
            InformarFinanciacion += GetCaracteristicasFinanciacion;
        }
        #endregion

        #region Propiedades

        public int Id
        {
            get { return this.id; }
        }

        public EMarcaMotocicleta Marca
        {
            get { return this.marca; }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    throw new AtributoInvalidoException("Ingrese una Marca válida", "Propiedad Marca, en Clase Motocicleta");
                else
                    this.marca = value;
            }
        }
        #endregion

        #region Métodos

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
            sw.Append($"Precio: $ {Precio}");
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
                          $"{Precio}");
            return sw.ToString();
        }

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
        #endregion
    }
}
