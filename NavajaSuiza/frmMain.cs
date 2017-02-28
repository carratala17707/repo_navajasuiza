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
/// namespace de la aplicación general NavajaSuiza
/// </summary>
namespace NavajaSuiza
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// llama a la aplicación 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Aplicación_1.frmAplicacion1 oFormulario = new Aplicación_1.frmAplicacion1();
            oFormulario.ShowDialog();
         }

        /// <summary>
        /// llama a la aplicación 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            Aplicación_2.frmAplicacion2 oFormulario = new Aplicación_2.frmAplicacion2();
            oFormulario.ShowDialog();
        }

        /// <summary>
        /// llama a la aplicación 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Aplicación_3.frmAplicacion3 oFormulario = new Aplicación_3.frmAplicacion3();
            oFormulario.ShowDialog();
        }

        /// <summary>
        /// llama a la aplicación 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Aplicación_4.frmAplicacion4 oFormulario = new Aplicación_4.frmAplicacion4();
            oFormulario.ShowDialog();
        }
    }
}
