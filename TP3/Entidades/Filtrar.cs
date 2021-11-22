using Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public static class Filtrar<T> where T : Vehiculo
    {
        /// <summary>
        /// Filtra una lista por color del tipo vehiculo especificada en T y la devuelve
        /// </summary>
        /// <param name="listaAFiltrar"></param>
        /// <param name="color"></param>
        /// <returns></returns>
        public static List<T> FiltrarListaPorColor(List<T> listaAFiltrar, EColor color)
        {
            List<T> retorno = listaAFiltrar;
            try
            {
                retorno = listaAFiltrar.Where(x => x.Color == color && x.Estado == 1).ToList();
                if (retorno.Count == 0)
                    throw new AtributoInvalidoException($"No se encontraron vehiculos con el color {color}.", "FiltrarListaPorColor, Clase Filtrar");
            }
            catch (AtributoInvalidoException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new Exception($"Ocurrió un error al querer filtrar la lista por color {color}.");
            }
            return retorno;
        }
    }
}
