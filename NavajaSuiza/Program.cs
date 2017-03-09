using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Namespace de la aplicación general NavajaSuiza.
/// </summary>
namespace NavajaSuiza
{
    /// <summary>
    /// Clase principal de mi programa.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
