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
/// Namespace de la aplicación 1.
/// </summary>
namespace NavajaSuiza.Aplicación_1
{
    /// <summary>
    /// Formulario que ejecuta la lógica de la aplicación 1.
    /// </summary>
    public partial class FrmAplicacion1 : Form
    {
        /// <summary>
        /// Constructor de la clase FrmAplicacion1.
        /// <remarks>----</remarks>
        /// </summary>
        public FrmAplicacion1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Función que verifica si un número positivo introducido es o no es primo.
        /// </summary>
        /// <remarks>----</remarks>
        /// <param name="numIntroducido">Número que introduce el usuario.</param>
        /// <returns>Si es primo o no.</returns>
        public bool EsPrimo(int numIntroducido)
        {
            bool esPrimo = true;

            if (numIntroducido > 0)
            {
                for (int i = 2; i < numIntroducido && esPrimo; i++)
                {
                    if (numIntroducido % i == 0)
                    {
                        esPrimo = false;
                    }
                }
            }
            return esPrimo;
        }

        /// <summary>
        /// Manejador de evento que permite introducir un número entero positivo e 
        /// indicar si es primo o no.
        /// </summary>
        /// <param name="sender">Lanza el botón del evento botonAppPrimo.</param>
        /// <param name="e">Sin uso.</param>
        public void botonAppPrimo_Click(object sender, EventArgs e)
        {
            bool elementoValido = true;
            bool esPrimo;
            int numeroIntroducido;

            elementoValido = int.TryParse(textIntroducNumApp1.Text, out numeroIntroducido);

            if (elementoValido)
            {
                esPrimo = EsPrimo(numeroIntroducido);

                if (esPrimo)
                {
                    MessageBox.Show("El número es primo.");
                }
                else
                {
                    MessageBox.Show("El número no es primo.");
                }
            }
            else
            {
                MessageBox.Show("Introduzca un elemento válido.");
            }
        }
    }
}
