using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        #region Constructores
        /// <summary>
        /// Constructor por defecto de FormCalculadora.
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo privado. Deja vacios los textBox, comboBox y label de la Calculadora, ademas inhabilita los botones de conversion.
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = string.Empty;
            cmbOperador.Text = string.Empty;
            lblResultado.Text = "0";
        }

        /// <summary>
        /// Metodo estatico. Realiza una operacion matematica haciendo uso del metodo Operar de la clase Calculadora
        /// </summary>
        /// <param name="numero1">Numero recibido mediante el txtOperando1</param>
        /// <param name="numero2">Numero recibido mediante el txtOperando2</param>
        /// <param name="operador">Operador recibido mediante el cmbOperador</param>
        /// <returns>Retorna el resultado de la operacion en caso de que los parametros no sean null.
        ///          Si no retorna 0.</returns>
        static private double Operar(string numero1, string numero2, string operador)
        {
            double retornoResultado = 0;
            if (numero1 != null && numero2 != null && operador != null)
            {
                Operando num1 = new Operando(numero1);
                Operando num2 = new Operando(numero2);
                char operadorChar;
                char.TryParse(operador, out operadorChar);
                retornoResultado = Calculadora.Operar(num1, num2, operadorChar);
            }
            return retornoResultado;
        }
        #endregion

        #region Botones aplicacion
        /// <summary>
        /// Hace uso del metodo Limpiar al hacer click en este boton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Hace uso del metodo estatico Operar al hacer click en este boton.
        /// Valida que complete todos los campos asignados, caso contrario muestra error.
        /// Valida que no se pueda dividir por 0, caso contrario muestra error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string operadorStr = cmbOperador.Text;

            if(txtNumero1.Text == string.Empty || txtNumero2.Text == string.Empty)
            {
                MessageBox.Show("Por favor complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double resultado = Operar(txtNumero1.Text, txtNumero2.Text, operadorStr);
                if (resultado == double.MinValue)
                {
                    MessageBox.Show("No es posible dividir por 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(operadorStr == string.Empty)
                    {
                        operadorStr = "+";
                    }
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.AppendFormat($"{txtNumero1.Text} {operadorStr} {txtNumero2.Text} = {resultado}");
                    lblResultado.Text = resultado.ToString();
                    lstOperaciones.Items.Add(stringBuilder.ToString()); 
                }
            }

        }

        /// <summary>
        /// Cierra la calculadora al hacer click en el boton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Al hacer click al boton "Convertir a Binario" realiza la operacion de los campos ingresados y
        /// al resultado lo convierte en binario.
        /// Luego lo muestra por el label y la listBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando decimalABinario = new Operando();
            Operando num1 = new Operando(txtNumero1.Text);
            Operando num2 = new Operando(txtNumero2.Text);

            char operador;
            char.TryParse(cmbOperador.Text, out operador);

            double resultado = Calculadora.Operar(num1, num2, operador);

            lblResultado.Text = decimalABinario.DecimalBinario(resultado);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Decimal a Binario: {lblResultado.Text}");
            lstOperaciones.Items.Add(stringBuilder.ToString());
        }
        /// <summary>
        /// Al hacer click al boton "Convertir a Decimal" realiza la operacion de los campos ingresados y
        /// al resultado lo convierte en Decimal.
        /// Luego lo muestra por el label y la listBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando binarioADecimal = new Operando();
            Operando num1 = new Operando(txtNumero1.Text);
            Operando num2 = new Operando(txtNumero2.Text);

            char operador;
            char.TryParse(cmbOperador.Text, out operador);

            double resultado = Calculadora.Operar(num1, num2, operador);

            lblResultado.Text = binarioADecimal.BinarioDecimal(resultado.ToString());
           
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Binario a Decimal: {lblResultado.Text}");
            lstOperaciones.Items.Add(stringBuilder.ToString());
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Evento que cuando el formulario recibió el mensaje para ser cerrado 
        /// le muestro un mensaje preguntandole si está seguro de cerrar la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// El evento load, se activa antes de mostrar la Calculadora y en este caso limpia los campos asignados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
        #endregion
    }
}
