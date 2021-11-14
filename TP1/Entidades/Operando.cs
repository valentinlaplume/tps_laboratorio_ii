using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        #region Constructores
        /// <summary>
        /// Constructor por defecto. Setea el valor del atributo numero en 0.
        /// </summary>
        public Operando() : this(0) { }

        /// <summary>
        /// Constructor parametrizado. 
        /// Recibe un valor de tipo double y lo setea como valor para el atributo numero.
        /// </summary>
        /// <param name="numero">Valor pasado por parametro que se asignara al atributo numero.</param>
        public Operando(double numero)
            : this(numero.ToString()) { }

        /// <summary>
        /// Constructor parametrizado.
        /// Recibe un valor de tipo string y valida que sea un numero. 
        /// En caso que sea un numero lo setea como valor para el atributo numero. 
        /// Caso contrario setea el valor del atributo numero en 0.
        /// </summary>
        /// <param name="strNumero">String pasado por parametro que se verificara y asignara al atributo numero</param>
        public Operando(string strNumero)
        {
            Numero = strNumero;
        }
        #endregion

        #region  Propiedades
        /// <summary>
        /// Propiedad privada.
        /// Contiene Setter privado. 
        /// Pasa el valor a setear por el metodo ValidarOperando
        /// y de ser valido lo asigna al atributo numero.
        /// </summary>
        private string Numero
        {
            set
            {
                numero = ValidarOperando(value);
            }
        }
        #endregion

        #region Validaciones
        /// <summary>
        /// Metodo estatico y privado. 
        /// Verifica que un string pasado por parametro sea un numero.
        /// Si contiene '.' remplaza por ',' para operar correctamente-
        /// Intenta parsear el operando, si es valido lo retorna.
        /// </summary>
        /// <param name="strNumero">String a ser validado y convertido</param>
        /// <returns>Retorna valor parseado en caso de ser un numero valido, sino retorna 0</returns>
        private double ValidarOperando(string strNumero)
        {
            double retorno = 0;
            if (!string.IsNullOrEmpty(strNumero))
            {
                double numero;
                string copiaStrNumero;
                copiaStrNumero = strNumero.Replace('.', ',');

                if (double.TryParse(copiaStrNumero, out numero))
                {
                    retorno = numero;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Validará que la cadena de caracteres esté compuesta solamente por caracteres '0' o '1'.
        /// </summary>
        /// <param name="binario">String numero binario pasado por parametro</param>
        /// <returns>True si la cadena contiene solo 0 o 1, False si no es un numero binario</returns>
        private bool EsBinario(string binario)
        {
            bool retorno = false;
            if (!string.IsNullOrEmpty(binario))
            {
                retorno = true;
                for (int i = 0; i < binario.Length; i++)
                {
                    if (binario[i] != '0' && binario[i] != '1')
                    {
                        retorno = false;
                        break;
                    }
                }
            }
            return retorno;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Convierte si es posible el numero binario pasado por parametro a decimal
        /// </summary>
        /// <param name="binario">Numero binario pasado por parameetro</param>
        /// <returns>Retorna el numero decimal convertido si el string sólo contiene 1 y 0,
        ///          de lo contrario retorna "Valor inválido"</returns>
        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor inválido";
            if (!string.IsNullOrEmpty(binario) && EsBinario(binario))
            {
                int acumulador = 0;

                int i;
                int j = binario.Length;

                for (i = 0; i < binario.Length; i++)
                {
                    j--;
                    if (binario[j] == '0')
                    {
                        continue;
                    }
                    else if (binario[j] == '1')
                    {
                        acumulador += (int)Math.Pow(1 * 2, i);
                    }
                }
                retorno = acumulador.ToString();
            }
            return retorno;
        }

        /// <summary>
        /// Realiza la conversion de un numero a un numero binario de ser posible.
        /// Reutiliza el metodo DecimalBinario.
        /// </summary>
        /// <param name="numero">Numero pasado por parametro a ser convertido a binario</param>
        /// <returns>Si el numero pasado por parametro es valido retorna numero binario convertido.
        ///          Si no retorna "Valor inválido"</returns>
        public string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }

        /// <summary>
        /// Verifica que el string pasado por parametro no sea null ni vacio y intenta parsear el numero string a int.
        /// Una vez validado realiza la conversion del numero decimal a un numero binario.
        /// </summary>
        /// <param name="numero">Numero string pasado por parametro a ser converitido a entero y luego a binario</param>
        /// <returns>Si el string pasado por parametro es valido retorna numero binario convertido.
        /// Si no retorna "Valor inválido" si lo ingresado es (nullo, vacio, numero negativo, o no se puede convertir a entero)</returns>
        public string DecimalBinario(string numero)
        {
            string retorno = "Valor inválido";
            int intNumero;
            if (!string.IsNullOrEmpty(numero) && int.TryParse(numero, out intNumero) &&
                intNumero > 0)
            {
                string strBinario = "";
                while (intNumero > 0) // cambiar a 1
                {
                    if (intNumero % 2 == 0)
                    {
                        strBinario = "0" + strBinario;
                    }
                    else
                    {
                        strBinario = "1" + strBinario;
                    }
                    intNumero = (int)(intNumero / 2);// probar sacando esta linea
                }
                retorno = strBinario;
            }
            return retorno;
        }
        #endregion

        #region Sobrecarga de Operadores
        /// <summary>
        /// Sobrecarga de operador para poder operar con Objetos de tipo Operando.
        /// Realiza una suma utilizando el atributo numero.
        /// </summary>
        /// <param name="num1">Objeto Operando en posicion del primer numero ingresado</param>
        /// <param name="num2">Objeto Operando en posicion del segundo numero ingresado</param>
        /// <returns>Retorna el resultado de la suma</returns>
        public static double operator +(Operando num1, Operando num2)
        {
            return num1.numero + num2.numero;
        }

        /// <summary>
        /// Sobrecarga de operador para poder operar con Objetos de tipo Operando.
        /// Realiza una resta utilizando el atributo numero.
        /// </summary>
        /// <param name="num1">Objeto Operando en posicion del primer numero ingresado</param>
        /// <param name="num2">Objeto Operando en posicion del segundo numero ingresado</param>
        /// <returns>Retorna el resultado de la resta</returns>
        public static double operator -(Operando num1, Operando num2)
        {
            return num1.numero - num2.numero;
        }

        /// <summary>
        /// Sobrecarga de operador para poder operar con Objetos de tipo Operando.
        /// No acepta dividir por 0;
        /// Realiza una division utilizando el atributo numero.
        /// </summary>
        /// <param name="num1">Objeto Operando en posicion de dividendo</param>
        /// <param name="num2">Objeto Operando en posicion de divisor</param>
        /// <returns>De ser posible retorna el resultado de la division, de lo contrario retorna double.MinValue</returns>
        public static double operator /(Operando num1, Operando num2)
        {
            if (num2.numero != 0)
            {
                return num1.numero / num2.numero;
            }
            else
            {
                return double.MinValue;
            }
        }

        /// <summary>
        /// Sobrecarga de operador para poder operar con Objetos de tipo Operando.
        /// Realiza una multiplicacion utilizando el atributo numero.
        /// </summary>
        /// <param name="num1">Objeto Operando en posicion del primer numero ingresado</param>
        /// <param name="num2">Objeto Operando en posicion del segundo numero ingresado</param>
        /// <returns>Retorna el resultado de la multiplicacion</returns>
        public static double operator *(Operando num1, Operando num2)
        {
            return num1.numero * num2.numero;
        }
        #endregion

    }
}
