using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ArchivosException() : base("Ocurrio un error en el archivo de datos.") { }


        /// <summary>
        /// Paso el msj de error personalizado y la clase que provoco la excepcion
        /// </summary>
        /// <param name="mensaje"> mensaje error personalizado </param>
        /// <param name="origenError"> origen que provoco la excepcion </param>
        public ArchivosException(string mensaje, string origenError)
                                        : base(mensaje)
        {
            base.Source = origenError;
        }

        /// <summary>
        /// Paso el msj de error personalizado y la excepcion
        /// </summary>
        /// <param name="mensaje"> mensaje error personalizado </param>
        /// <param name="innerException">clase que provoco la excepcion</param>
        public ArchivosException(string mensaje, Exception innerException)
                                        : base(mensaje, innerException) { }
    }
}

