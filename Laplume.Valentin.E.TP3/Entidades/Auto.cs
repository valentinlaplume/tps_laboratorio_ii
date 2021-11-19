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
    public delegate string Financiable();

    public class Auto : Vehiculo, IAutomovil
    {
        static int ultimoId;
        int id;
        EMarcaAutomovil marca;
        int cantidadPuertas;

        public event Financiable InformarFinanciacion;

        /// <summary>
        /// Calcula financiacion del vehiculo dependiendo sus años de antiguedad
        /// </summary>
        /// <returns> Datos de financiacion </returns>
        private string GetNotificacionFinanciacion()
        {
            StringBuilder financiacion = new StringBuilder();
            float añosVehiculo = int.Parse(DateTime.Now.ToString("yyyy")) - this.Año;
            int cuotas = 0;
            int recargo = 0;

            if (añosVehiculo < 4)        { cuotas = 36; recargo = 40; } 
            else if (añosVehiculo < 10)  { cuotas = 24; recargo = 30; } 
            else if (añosVehiculo > 7)   { cuotas = 12; recargo = 20; }

            float precioRecargo = (recargo* this.Precio) / 100;
            float precioFinaVehiculo = this.Precio + precioRecargo;

            int añosCuotas = 0;
            for (int años = cuotas; años > 0; )
            {
                años -= 12;
                añosCuotas++;
            }

            float pagoPorCuota = precioFinaVehiculo / cuotas;

            financiacion.AppendLine($"Financiable en {cuotas} cuotas de $ {pagoPorCuota}.");
            financiacion.AppendLine($"Con un recargo del % {recargo}.");
            financiacion.Append($"Precio final del Vehículo: $ {precioFinaVehiculo}, a pagar en {añosCuotas} ");
            if (añosCuotas == 1) { financiacion.Append("año."); } else { financiacion.AppendLine("años."); }

            return financiacion.ToString();
        }

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
            this.id = ultimoId + 1;
            ultimoId = this.id;

            this.Marca = marca;
            this.cantidadPuertas = cantidadPuertas;
            InformarFinanciacion = GetNotificacionFinanciacion;
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
            InformarFinanciacion = GetNotificacionFinanciacion;
        }

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
                    throw new AtributoInvalidoException("Ingrese cantidad de puertas válidas (3 o 5)", "Propiedad CantidadPuertas, en Clase Auto");
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
                    throw new Exception("Ingrese una Marca válida");
                else
                    this.marca = value;
            }
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
    }
}
