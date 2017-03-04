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
/// Namespace de la aplicación general NavajaSuiza
/// </summary>
namespace NavajaSuiza
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// Constructor de la clase frmMain.
        /// <remarks>----</remarks>
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Llama a la aplicación 1.
        /// </summary>
        /// <param name="sender">Lanza el botón del evento button1.</param>
        /// <param name="e">Sin uso.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            Aplicación_1.frmAplicacion1 oFormulario = new Aplicación_1.frmAplicacion1();
            oFormulario.ShowDialog();
         }

        /// <summary>
        /// Llama a la aplicación 2.
        /// </summary>
        /// <param name="sender">Lanza el botón del evento button4.</param>
        /// <param name="e">Sin uso.</param>
        private void button4_Click(object sender, EventArgs e)
        {
            Aplicación_2.frmAplicacion2 oFormulario = new Aplicación_2.frmAplicacion2();
            oFormulario.ShowDialog();
        }

        /// <summary>
        /// Llama a la aplicación 3.
        /// </summary>
        /// <param name="sender">Lanza el botón del evento button3.</param>
        /// <param name="e">Sin uso.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            Aplicación_3.frmAplicacion3 oFormulario = new Aplicación_3.frmAplicacion3();
            oFormulario.ShowDialog();
        }

        /// <summary>
        /// Llama a la aplicación 4.
        /// </summary>
        /// <param name="sender">Lanza el botón del evento button2.</param>
        /// <param name="e">Sin uso.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            Aplicación_4.frmAplicacion4 oFormulario = new Aplicación_4.frmAplicacion4();
            oFormulario.ShowDialog();
        }
    }
}
