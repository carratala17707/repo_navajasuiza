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
/// Namespace de la aplicación 3.
/// </summary>
namespace NavajaSuiza.Aplicación_3
{
    /// <summary>
    /// Formulario que ejecuta la lógica de la aplicación 3.
    /// </summary>
    public partial class FrmAplicacion3 : Form
    {
        /// <summary>
        /// Constructor de la clase FrmAplicacion3.
        /// <remarks>----</remarks>
        /// </summary>
        public FrmAplicacion3()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Manejador de evento que permite leer un vector, contar el número de valores
        /// repetidos modificados por -1 y mostrarlo con las modificaciones.
        /// Si se introduce un elemento no válido se lanza una excepción.
        /// </summary>
        /// <param name="sender">Lanza el botón del evento botonAppRepetidos.</param>
        /// <param name="e">Sin uso.</param>
        public void botonAppRepetidos_Click(object sender, EventArgs e)
        {
            try
            {
                int modificaciones = 0;
                int[] vectorNumeros = Logica.LogicaApp3.ComprobarValoresEntrada(
                    textIntroducNumApp3.Text, out modificaciones);
                string mensaje = Logica.LogicaApp3.MostrarVector(vectorNumeros) + 
                    " el número de valores modificados es: " +
                    modificaciones;

                MessageBox.Show(mensaje);
            }
            catch (Excepciones.ArgumentoNoValidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
