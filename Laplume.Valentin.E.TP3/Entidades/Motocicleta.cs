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

        public Motocicleta()
        {
        }

        /// <summary>
        /// Constructor estatico, inicializa el ultimo Id en 0
        /// </summary>
        static Motocicleta()
        {
            ultimoId = 0;
        }

        public Motocicleta(EMarcaMotocicleta marca, string nombre, int año, int km,
                           ETipoCombustible tipoCombustible, ETipoTransmision tipoTransmision,
                           EColor color, float precio) 
            : base (nombre, año, km, tipoCombustible, tipoTransmision, color, precio)
        {
            this.id = ultimoId + 1;
            ultimoId = this.id;

            this.Marca = marca;
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
        }
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
    }
}
