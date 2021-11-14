using Entidades.Enumerados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Estadistica<T> where T : Vehiculo
    {
        public static float GetPorcentaje(int cantidadParcial, int cantidadTotal)
        {
            return (cantidadParcial * 100) / cantidadTotal;
        }

        public static string GetPorcentajesVehiculosPorCombustible(List<T> vehiculos)
        {
            StringBuilder sb = new StringBuilder();
            Array combustibles = Enum.GetNames(typeof(ETipoCombustible));
            int cantidadTotal = vehiculos.Count();
            foreach (string combustible in combustibles)
            {
                int cantidadParcial = vehiculos.Where(x => x.TipoCombustible.ToString() == combustible && x.Estado == 1).ToList().Count();
                sb.AppendLine($"{combustible}: % " +
                $"{GetPorcentaje(cantidadParcial, cantidadTotal)} ({cantidadParcial} de {cantidadTotal}).   ");
            }
            return sb.ToString();
        }

        public static string GetPorcentajesVehiculosPorTransimison(List<T> vehiculos)
        {
            StringBuilder sb = new StringBuilder();
            Array transmisiones = Enum.GetNames(typeof(ETipoTransmision));
            int cantidadTotal = vehiculos.Count();
            foreach (string transmision in transmisiones)
            {
                int cantidadParcial = vehiculos.Where(x => x.TipoTransmision.ToString() == transmision && x.Estado == 1).ToList().Count();
                sb.AppendLine($"{transmision}: % " +
                $"{GetPorcentaje(cantidadParcial, cantidadTotal)} ({cantidadParcial} de {cantidadTotal}).   ");
            }
            return sb.ToString();
        }

        public static string GetPorcentajesVehiculosPorPrecio(List<T> vehiculos, bool mayorAlPrecio, float precio)
        {
            StringBuilder sb = new StringBuilder();
            int cantidadTotal = vehiculos.Count();
            int cantidadParcial;

            if (mayorAlPrecio){
                cantidadParcial = vehiculos.Where(x => x.Precio >= precio && x.Estado == 1).ToList().Count();
            }
            else{
                cantidadParcial = vehiculos.Where(x => x.Precio <= precio && x.Estado == 1).ToList().Count();
            }

            sb.AppendLine($"% {GetPorcentaje(cantidadParcial, cantidadTotal)} ({cantidadParcial} de {cantidadTotal}).");
            return sb.ToString();
        }

        public static string GetPorcentajesVehiculosPorKilometros(List<T> vehiculos, bool mayorAKilometros, int kilometros)
        {
            StringBuilder sb = new StringBuilder();
            int cantidadTotal = vehiculos.Count();
            int cantidadParcial;

            if (mayorAKilometros)
            {
                cantidadParcial = vehiculos.Where(x => x.Km >= kilometros && x.Estado == 1).ToList().Count();
            }
            else
            {
                cantidadParcial = vehiculos.Where(x => x.Km <= kilometros && x.Estado == 1).ToList().Count();
            }

            sb.AppendLine($"% {GetPorcentaje(cantidadParcial, cantidadTotal)} ({cantidadParcial} de {cantidadTotal}).");
            return sb.ToString();
        }

        public static string GetPorcentajesVehiculosPorAño(List<T> vehiculos, bool mayorA_Año, int año)
        {
            StringBuilder sb = new StringBuilder();
            int cantidadTotal = vehiculos.Count();
            int cantidadParcial;

            if (mayorA_Año)
            {
                cantidadParcial = vehiculos.Where(x => x.Año >= año && x.Estado == 1).ToList().Count();
            }
            else
            {
                cantidadParcial = vehiculos.Where(x => x.Año <= año && x.Estado == 1).ToList().Count();
            }

            sb.AppendLine($"% {GetPorcentaje(cantidadParcial, cantidadTotal)} ({cantidadParcial} de {cantidadTotal}).");
            return sb.ToString();
        }

    }
}
