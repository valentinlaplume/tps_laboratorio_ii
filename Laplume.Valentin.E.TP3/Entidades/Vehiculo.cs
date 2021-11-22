using Entidades.Enumerados;
using Excepciones;
using System;
using System.Text;

namespace Entidades
{
    public abstract class Vehiculo
    {
        string nombre;
        int año;
        int km;
        ETipoCombustible tipoCombustible;
        ETipoTransmision tipoTransmision;
        EColor color;
        float precio;
        int estado;

        public Vehiculo() { }

        public Vehiculo(string nombre, int año, int km, ETipoCombustible tipoCombustible,
                        ETipoTransmision tipoTransmision, EColor color, float precio)
        {
            this.Nombre = nombre;
            this.Año = año;
            this.Km = km;
            this.TipoCombustible = tipoCombustible;
            this.TipoTransmision = tipoTransmision;
            this.Color = color;
            this.Precio = precio;
            this.Estado = 1;
        }

        public abstract string MostrarEnFormatoCSV();
        public abstract string MostrarDetalle();
        public abstract string GetCaracteristicasFinanciacion();

        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new AtributoInvalidoException("Ingrese un Nombre válido.", "Propiedad Nombre, en Clase Vehiculo");
                else
                    this.nombre = value;
            }
        }

        public int Año
        {
            get { return this.año; }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                    throw new AtributoInvalidoException($"Ingrese un Año válido (1900 al {DateTime.Now.Year}.", "Propiedad Año, en Clase Vehiculo");
                else
                    this.año = value;
            }
        }
        public int Km
        {
            get { return this.km; }
            set
            {
                if (value < 0 || value > 999999)
                    throw new AtributoInvalidoException("Ingrese Kilometros válidos (0 al 999.999).", "Propiedad Km, en Clase Vehiculo");
                else
                    this.km = value;
            }
        }
        public ETipoCombustible TipoCombustible
        {
            get { return this.tipoCombustible; }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    throw new AtributoInvalidoException("Ingrese un Tipo de Combustible válido.", "Propiedad TipoCombustible, en Clase Vehiculo");
                else
                    this.tipoCombustible = value;
            }
        }
        public ETipoTransmision TipoTransmision
        {
            get { return this.tipoTransmision; }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    throw new AtributoInvalidoException("Ingrese un Tipo de Transmision válido.", "Propiedad TipoTransmision, en Clase Vehiculo");
                else
                    this.tipoTransmision = value;
            }
        }
        public EColor Color
        {
            get { return this.color; }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    throw new AtributoInvalidoException("Ingrese un Tipo de Color válido.", "Propiedad Color, en Clase Vehiculo");
                else
                    this.color = value;
            }
        }
        public float Precio
        {
            get { return this.precio; }
            set
            {
                if (string.IsNullOrEmpty(value.ToString()) || !float.TryParse(value.ToString(), out float precioValido) || precioValido < 0 || precioValido > 999999999)
                    throw new AtributoInvalidoException("Ingrese un precio válido.", "Propiedad Precio, en Clase Vehiculo");
                else
                    this.precio = value;
            }
        }

        public int Estado
        {
            get { return this.estado; }
            set
            {
                if (!string.IsNullOrEmpty(value.ToString()) && value > -1 && value < 2)
                    this.estado = value;
                else
                    throw new AtributoInvalidoException("Estado inválido.", "Propiedad Estado, en Clase Vehiculo");
            }
        }
    }
}
