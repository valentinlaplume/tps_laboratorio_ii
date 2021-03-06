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
    public class Camioneta : Vehiculo, IAutomovil
    {
        static int ultimoId;
        int id;
        EMarcaAutomovil marca;
        int cantidadPuertas;

        /// <summary>
        /// Constructor estatico, inicializa el ultimo Id en 0
        /// </summary>
        static Camioneta()
        {
            ultimoId = 0;
        }

        public Camioneta(EMarcaAutomovil marca, string nombre, int año, int km, ETipoCombustible tipoCombustible, ETipoTransmision tipoTransmision,
                         EColor color, float precio, int cantidadPuertas)
            : base (nombre, año, km, tipoCombustible, tipoTransmision, color, precio)
        {
            this.id = ultimoId + 1;
            ultimoId = this.id;

            this.Marca = marca;
            this.cantidadPuertas = cantidadPuertas;
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
                    throw new AtributoInvalidoException("Ingrese cantidad de puertas válidas (3 o 5)", "Propiedad CantidadPuertas, en Clase Camioneta");
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
                    throw new AtributoInvalidoException("Ingrese una Marca válida", "Propiedad Marca, en Clase Camioneta");
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
            sw.Append($"Cantidad de puertas: {cantidadPuertas}");
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
