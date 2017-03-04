using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Namespace de la aplicación1.
/// </summary>
namespace NavajaSuiza.Aplicación_1
{
    public partial class frmAplicacion1 : Form
    {
        /// <summary>
        /// Constructor de la clase frmAplicacion1.
        /// <remarks>----</remarks>
        /// </summary>
        public frmAplicacion1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Función que mediante la introducción de numeroBase y númeroExponente permite
        /// calcular potencias.
        /// </summary>
        /// <param name="numeroBase">Numero introducido que será la base.</param>
        /// <param name="numeroExponente">Numero introducido que será el exponente.</param>
        /// <remarks>----</remarks>
        /// <returns>El resultado de la potencia.</returns>
        int CalcularPotencia(int numeroBase, int numeroExponente)
        {
            int resultadoPotencia, i;

            resultadoPotencia = 1;

            for (i = 1; i <= numeroExponente; i++)
            {
                resultadoPotencia = resultadoPotencia * numeroBase;
            }
            return resultadoPotencia;
        }

        /// <summary>
        /// Evento que permite la introducción de un número que actúa de base
        /// y otro como exponente y se muestra el resultado. 
        /// </summary>
        /// <param name="sender">Lanza el botón del evento button1.</param>
        /// <param name="e">Sin uso.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            int numeroBase, numeroExponente, resultadoPotencia;

            numeroBase = int.Parse(textBox1.Text);
            numeroExponente = int.Parse(textBox2.Text);

            resultadoPotencia = CalcularPotencia(numeroBase, numeroExponente);

            MessageBox.Show("El resultado es: " + resultadoPotencia);
        }
    }
}
