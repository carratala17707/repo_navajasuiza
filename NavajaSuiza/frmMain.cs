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
/// Namespace de la aplicación general NavajaSuiza.
/// </summary>
namespace NavajaSuiza
{
    /// <summary>
    /// Formulario principal de mi programa.
    /// </summary>
    public partial class FrmMain : Form
    {
        /// <summary>
        /// Constructor de la clase frmMain.
        /// <remarks>----</remarks>
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Llama a la aplicación 1.
        /// </summary>
        /// <param name="sender">Lanza el botón del evento button1.</param>
        /// <param name="e">Sin uso.</param>
        public void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta aplicación permite indicar si un número es primo o no.");
            Aplicación_1.FrmAplicacion1 oFormulario = new Aplicación_1.FrmAplicacion1();
            oFormulario.ShowDialog();
         }

        /// <summary>
        /// Llama a la aplicación 2.
        /// </summary>
        /// <param name="sender">Lanza el botón del evento button4.</param>
        /// <param name="e">Sin uso.</param>
        public void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta aplicación permite obtener una cadena de números múltiplos de 3 y 5.");
            Aplicación_2.FrmAplicacion2 oFormulario = new Aplicación_2.FrmAplicacion2();
            oFormulario.ShowDialog();
        }

        /// <summary>
        /// Llama a la aplicación 3.
        /// </summary>
        /// <param name="sender">Lanza el botón del evento button3.</param>
        /// <param name="e">Sin uso.</param>
        public void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta aplicación permite introducir números en un vector y modificar los valores repetidos.");
            Aplicación_3.FrmAplicacion3 oFormulario = new Aplicación_3.FrmAplicacion3();
            oFormulario.ShowDialog();
        }

        /// <summary>
        /// Llama a la aplicación 4.
        /// </summary>
        /// <param name="sender">Lanza el botón del evento button2.</param>
        /// <param name="e">Sin uso.</param>
        public void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta aplicación permite introducir números en un vector y mostrarlos al revés.");
            Aplicación_4.FrmAplicacion4 oFormulario = new Aplicación_4.FrmAplicacion4();
            oFormulario.ShowDialog();
        }
    }
}
