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
        /// Manejador de evento que permite introducir un número entero positivo e 
        /// indicar si es primo o no. Si se introduce un elemento no válido se lanza
        /// una excepción.
        /// </summary>
        /// <param name="sender">Lanza el botón del evento botonAppPrimo.</param>
        /// <param name="e">Sin uso.</param>
        public void botonAppPrimo_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = Logica.LogicaApp1.ComprobarNumero(textIntroducNumApp1.Text);
                MessageBox.Show(mensaje);
            }
            catch (Excepciones.ArgumentoNoValidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
