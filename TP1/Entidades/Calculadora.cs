using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static public class Calculadora
    {
        #region Validaciones
        /// <summary>
        /// Verifica que el operador seleccionado sea un operador valido.
        /// </summary>
        /// <param name="operador">Operador pasado por parametro</param>
        /// <returns>Retorna el operador en caso de ser valido, caso contrario retorna operador "+"</returns>
        static private char ValidarOperador(char operador)
        {
            char retorno;
            switch (operador)
            {
                case '-':
                    retorno = '-';
                    break;
                case '/':
                    retorno = '/';
                    break;
                case '*':
                    retorno = '*';
                    break;
                default:
                    retorno = '+';
                    break;
            }
            return retorno;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Realiza una operacion determinada sobre dos objetos de tipo Operando
        /// </summary>
        /// <param name="num1">Objeto Operando como primer operando</param>
        /// <param name="num2">Objeto Operando como segundo operando</param>
        /// <param name="operador">Operador</param>
        /// <returns>Retorna el esultado de la operacion entre num1 y num2</returns>
        static public double Operar(Operando num1, Operando num2, char operador)
        {
            double retorno;
            switch (ValidarOperador(operador))
            {
                case '-':
                    retorno = num1 - num2;
                    break;
                case '/':
                    retorno = num1 / num2;
                    break;
                case '*':
                    retorno = num1 * num2;
                    break;
                default:
                    retorno = num1 + num2;
                    break;
            }
            return retorno;
        }
        #endregion
    }
}
