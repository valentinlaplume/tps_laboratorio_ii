using Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaz
{
    public interface IAutomovil
    {
        public int CantidadPuertas { get; set; }
        public EMarcaAutomovil Marca { get; set; }
    }
}
