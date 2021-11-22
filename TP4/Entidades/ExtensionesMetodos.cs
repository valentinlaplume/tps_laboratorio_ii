using Entidades;
using Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExtensionesMetodos
    {
        /// <summary>
        /// Recorre la lista de motocicletas y cuenta cual es el color que mas abunda
        /// </summary>
        /// <param name="motocicletas"></param>
        /// <returns> El color que mas abunda en la lista de Motocicletas </returns>
        public static string MaxColor(this List<Motocicleta> motocicletas)
        {
            if(motocicletas.Where(x => x.Estado == 1).ToList().Count > 0)
            {
                string[] arrayColores = Enum.GetNames(typeof(EColor));
                int cantidadColores = arrayColores.Length;
                int[] posicionColores = new int[cantidadColores];

                for (int i = 0; i < cantidadColores; i++) { posicionColores[i] = 0; }

                foreach (Motocicleta item in motocicletas)
                {
                    for (int i = 0; i < cantidadColores; i++)
                    {
                        if (item.Estado == 1 && (int)item.Color == i)
                        {
                            posicionColores[i]++;
                            break;
                        }
                    }
                }

                int repiteMax = posicionColores[0];
                int indiceMax = 0;
                for (int i = 0; i < posicionColores.Length; i++)
                {
                    if (posicionColores[i] > repiteMax)
                    {
                        repiteMax = posicionColores[i];
                        indiceMax = i;
                    }
                }
                return ((EColor)indiceMax).ToString();
            }
            return "No hay Motocicletas en la Concesionaria.";
        }

        /// <summary>
        /// Recorre la lista de Autos y cuenta cual es el color que mas abunda
        /// </summary>
        /// <param name="motocicletas"></param>
        /// <returns> El color que mas abunda en la lista de Autos </returns>
        public static string MaxColor(this List<Auto> autos)
        {
            if (autos.Where(x => x.Estado == 1).ToList().Count > 0)
            {
                string[] arrayColores = Enum.GetNames(typeof(EColor));
                int cantidadColores = arrayColores.Length;
                int[] posicionColores = new int[cantidadColores];

                for (int i = 0; i < cantidadColores; i++) { posicionColores[i] = 0; }

                foreach (Auto item in autos)
                {
                    for (int i = 0; i < cantidadColores; i++)
                    {
                        if (item.Estado == 1 && (int)item.Color == i)
                        {
                            posicionColores[i]++;
                            break;
                        }
                    }
                }

                int repiteMax = posicionColores[0];
                int indiceMax = 0;
                for (int i = 0; i < posicionColores.Length; i++)
                {
                    if (posicionColores[i] > repiteMax)
                    {
                        repiteMax = posicionColores[i];
                        indiceMax = i;
                    }
                }
                return ((EColor)indiceMax).ToString();
            }
            return "No hay Autos en la Concesionaria.";
        }

        /// <summary>
        /// Recorre la lista de Camionetas y cuenta cual es el color que mas abunda
        /// </summary>
        /// <param name="motocicletas"></param>
        /// <returns> El color que mas abunda en la lista de Camionetas </returns>
        public static string MaxColor(this List<Camioneta> camionetas)
        {
            if(camionetas.Where(x => x.Estado == 1).ToList().Count > 0)
            { 
                string[] arrayColores = Enum.GetNames(typeof(EColor));
                int cantidadColores = arrayColores.Length;
                int[] posicionColores = new int[cantidadColores];

                for (int i = 0; i < cantidadColores; i++) { posicionColores[i] = 0; }

                foreach (Camioneta item in camionetas) {
                    for (int i = 0; i < cantidadColores; i++) {
                        if (item.Estado == 1 && (int)item.Color == i) {
                            posicionColores[i]++;
                            break;
                        }
                    }
                }

                int repiteMax = posicionColores[0];
                int indiceMax = 0;
                for (int i = 0; i < posicionColores.Length; i++) {
                    if (posicionColores[i] > repiteMax) {
                        repiteMax = posicionColores[i];
                        indiceMax = i;
                    }
                }
                return ((EColor)indiceMax).ToString();
            }
            return "No hay Camionetas en la Concesionaria.";
        }
    }
}
