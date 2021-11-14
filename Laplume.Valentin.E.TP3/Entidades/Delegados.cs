using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Delegados<T> where T : class
    {
        public delegate float DeLListaFiltrada(List<T> lista, int total);

        /// <summary>
        /// Obtiene el porcentaje de la lista T pasada por parametro
        /// por sobre el total pasado por parametro
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public static float GetListaFiltrada(IEnumerable<T> lista, int total)
        {
            return (lista.Count() * 100) / total;
        }

    }
}
