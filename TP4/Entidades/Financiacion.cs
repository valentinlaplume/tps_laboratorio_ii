using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Financiacion
    {

        /// <summary>
        /// Obtiene cantidad de cuotas y recargo dependiendo el año del vehiculo.
        /// </summary>
        public static void GetCuotasYRecargo(int añosVehiculo, out int cuotas, out int porcentajeRecargo)
        {
            cuotas = 0;
            porcentajeRecargo = 0;
            if (añosVehiculo < 4) { cuotas = 36; porcentajeRecargo = 40; }
            else if (añosVehiculo < 10) { cuotas = 24; porcentajeRecargo = 30; }
            else if (añosVehiculo > 7) { cuotas = 12; porcentajeRecargo = 20; }
        }

        /// <summary>
        /// Obtiene precio final, se le suma el precio del vehiculo mas el recargo
        /// </summary>
        /// <param name="porcentajeRecargo"></param>
        /// <param name="precioVehiculo"></param>
        /// <returns> precio final </returns>
        public static float GetPrecioFinalConRecargo(int porcentajeRecargo, float precioVehiculo)
        {
            float precioRecargo = (float)(porcentajeRecargo * precioVehiculo) / 100;
            return precioVehiculo + precioRecargo;
        }

        /// <summary>
        /// Obtiene en cuantos años se paga el vehiculo
        /// </summary>
        /// <param name="cuotas"></param>
        /// <returns> años a pagar vehiculo </returns>
        public static int GetAñosCuotas(int cuotas)
        {
            int añosCuotas = 0;
            for (int años = cuotas; años > 0;)
            {
                años -= 12;
                añosCuotas++;
            }

            return añosCuotas;
        }

        /// <summary>
        /// Obtiene el pago por cada cuota de la financiacion
        /// </summary>
        /// <returns> el pago por cada cuota de la financiacion </returns>
        public static float GetPagoPorCuotas(float precioFinalVehiculo, int cuotas)
        {
            return precioFinalVehiculo / cuotas; ;
        }

    }
}
