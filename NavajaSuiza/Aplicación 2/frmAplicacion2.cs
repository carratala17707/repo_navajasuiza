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
    /// <summary>
    /// Formulario que ejecuta la lógica de la aplicación 2.
    /// </summary>
    public partial class FrmAplicacion2 : Form
    {
        /// <summary>
        /// Constructor de la clase FrmAplicacion2.
        /// <remarks>----</remarks>
        /// </summary>
        public FrmAplicacion2()
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
        public bool ValidarNumero(int numeroIntroducido)
        {
            bool numeroValido = false;

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
        public string MostrarSerieMultiplos(int numeroIntroducido)
        {
            string cadenaTexto = "";

            for (int i = 1; i <= numeroIntroducido; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    cadenaTexto = cadenaTexto + i + ", ";
                }
            }
            return cadenaTexto;
        }

        /// <summary>
        /// Manejador de evento que permite introducir un número, validarlo para que
        /// esté comprendido entre el 1 y el 100 y si lo está, que devuelva
        /// los múltiplos de 3 y 5 que puedan haber hasta ese número introducido.
        /// </summary>
        /// <param name="sender">Lanza el botón del evento button1.</param>
        /// <param name="e">Sin uso.</param>
        public void button1_Click(object sender, EventArgs e)
        {
            string cadenaTexto = "";
            bool numeroValido = true;
            bool elementoValido = true;
            int numeroIntroducido;

            elementoValido = int.TryParse(textBox1.Text, out numeroIntroducido);

            if (elementoValido)
            {
                numeroValido = ValidarNumero(numeroIntroducido);

                if (numeroValido == false)
                {
                    MessageBox.Show("Introduzca un número entre 1 y 100.");
                }
                else
                {
                    cadenaTexto = MostrarSerieMultiplos(numeroIntroducido);
                    MessageBox.Show(cadenaTexto);
                }
            }
            else
            {
                MessageBox.Show("Introduzca un elemento válido.");
            }
        }
    }
}
