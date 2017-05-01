﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Namespace de la aplicación 4.
/// </summary>
namespace NavajaSuiza.Aplicación_4
{
    /// <summary>
    /// Formulario que ejecuta la lógica de la aplicación 4.
    /// </summary>
    public partial class FrmAplicacion4 : Form
    {
        /// <summary>
        /// Constructor de la clase FrmAplicacion4.
        /// <remarks>----</remarks>
        /// </summary>
        public FrmAplicacion4()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Manejador de evento que permite leer un vector (vectorLeido), darle la 
        /// vuelta (vectorAlReves) y mostrarlo.
        /// </summary>
        /// <param name="sender">Lanza el botón del evento botonAppVectorReves.</param>
        /// <param name="e">Sin uso.</param>
        public void botonAppVectorReves_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = Logica.LogicaApp4.ComprobarValoresEntrada(textIntroducNumApp4.Text);
                MessageBox.Show(mensaje);
            }
            catch (Util.ArgumentoNoValidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
