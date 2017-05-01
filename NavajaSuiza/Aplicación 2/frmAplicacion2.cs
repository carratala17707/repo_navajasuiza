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
/// Namespace de la aplicación 2.
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
        /// Manejador de evento que permite introducir un número, validarlo para que
        /// esté comprendido entre el 1 y el 100 y si lo está, que devuelva
        /// los múltiplos de 3 y 5 que puedan haber hasta ese número introducido.
        /// </summary>
        /// <param name="sender">Lanza el botón del evento botonAppMultiplos.</param>
        /// <param name="e">Sin uso.</param>
        public void botonAppMultiplos_Click(object sender, EventArgs e)
        {
            string mensaje = Logica.LogicaApp2.ComprobarNumero(textIntroducNumApp2.Text);
            MessageBox.Show(mensaje);
        }
    }
}
