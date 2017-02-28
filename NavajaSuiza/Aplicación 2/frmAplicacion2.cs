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
/// Namespace de la aplicación2.
/// </summary>
namespace NavajaSuiza.Aplicación_2
{
    public partial class frmAplicacion2 : Form
    {
        /// <summary>
        /// Constructor de la clase frmAplicacion2.
        /// <remarks>----</remarks>
        /// </summary>
        public frmAplicacion2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Función que verifica si un número está comprendido entre el 1 y el 100.
        /// de ser así, se considera válido.
        /// </summary>
        /// <remarks>Si el número no es válido, saltará un mensaje para que
        /// se introduzca otro número.</remarks>
        /// <param name="numeroIntroducido">Número que introduce el usuario.</param>
        /// <returns>Si es válido o no.</returns>
        bool ValidarNumero(int numeroIntroducido)
        {
            bool numeroValido;

            numeroValido = false;

            if (numeroIntroducido >= 1 && numeroIntroducido <= 100)
            {
                numeroValido = true;
            }
            return numeroValido;
        }

        /// <summary>
        /// Función que devuelve la cadena de números múltiplos de 3 y 5 
        /// comprendidos hasta el número que introduzca el usuario.
        /// </summary>
        /// <remarks>----</remarks>
        /// <param name="numeroIntroducido">Número que introduce el usuario.</param>
        /// <returns>Cadena con los múltiplos de 3 y 5.</returns>
        string SerieMultiplos(int numeroIntroducido)
        {
            string cadenaTexto;
            int i;

            cadenaTexto = "";
            i = 1;

            for (i = 1; i <= numeroIntroducido; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    cadenaTexto = cadenaTexto + i + ", ";
                }
            }
            return cadenaTexto;
        }

        /// <summary>
        /// Evento que permite introducir un número, validarlo para que
        /// esté comprendido entre el 1 y el 100 y si lo está, que devuelva
        /// los múltiplos de 3 y 5 que puedan haber hasta ese número introducido.
        /// </summary>
        /// <param name="sender">Lanza el botón del evento button1.</param>
        /// <param name="e">Sin uso.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            int numeroIntroducido;
            string cadenaTexto;
            bool numeroValido;

            numeroIntroducido = int.Parse(textBox1.Text);
            numeroValido = true;

            numeroValido = ValidarNumero(numeroIntroducido);

            if (numeroValido == false)
            {
                MessageBox.Show("Introduzca otro número.");
            }
            else
            {
                cadenaTexto = SerieMultiplos(numeroIntroducido);
                MessageBox.Show(cadenaTexto);
            }
        }
    }
}
