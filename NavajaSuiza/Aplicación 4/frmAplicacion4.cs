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
/// Namespace de la aplicación4
/// </summary>
namespace NavajaSuiza.Aplicación_4
{
    /// <summary>
    /// Formulario que ejecuta la lógica de la aplicación 4.
    /// </summary>
    public partial class FrmAplicacion4 : Form
    {
        /// <summary>
        /// Función que muestra un mensaje en un cuadro de diálogo, 
        /// espera a que el usuario escriba un texto o haga clic en un botón 
        /// y devuelve una cadena con el contenido del cuadro de texto.
        /// </summary>
        /// <remarks>Cuando se introduce un carácter no permitido, 
        /// sale un mensaje de error.</remarks>
        /// <param name="cadenaTexto">Cualquier caracter o cadena que el usuario
        /// introduzca.</param>
        /// <returns>Cadena con el contenido del cuadro de texto.</returns>
        private static string InputBox(string cadenaTexto)
        {
            InputBoxDialog ib = new InputBoxDialog();
            ib.FormPrompt = cadenaTexto;
            ib.DefaultValue = "";
            ib.ShowDialog();
            string s = ib.InputResponse;
            ib.Close();
            return s;
        }

        /// <summary>
        /// Constructor de la clase FrmAplicacion4.
        /// <remarks>----</remarks>
        /// </summary>
        public FrmAplicacion4()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Se inicializa la constante kTamanyo (tamaño del vector)
        /// y los vectores a utilizar.
        /// <remarks>----</remarks>
        /// </summary>
        const int kTamanyo = 10;
        int[] vectorLeido = new int[kTamanyo];
        int[] vectorAlReves = new int[kTamanyo];

        /// <summary>
        /// Función que permite leer un vector de enteros.
        /// <remarks>Permitirá introducir números
        /// hasta que se llegue al tamaño total del vector.</remarks>
        /// </summary>
        /// <param name="vectorLeido">Vector creado.</param>
        public void LeerVector(int[] vectorLeido)
        {
            int numeroIntroducido;
            bool elementoValido = true;

            for (int i = 0; i < kTamanyo; i++)
            {
                do
                {
                    elementoValido = int.TryParse(InputBox("Introduzca el elemento: " + i),
                        out numeroIntroducido);

                    if (elementoValido)
                    {
                        vectorLeido[i] = numeroIntroducido;
                    }
                    else
                    {
                        MessageBox.Show("Introduzca un elemento válido.");
                    }
                } while (!elementoValido);
            }
        }

        /// <summary>
        /// Función que permite darle la vuelta a vectorLeído y 
        /// posicionar los números en vectorAlReves.
        /// </summary>
        /// <remarks>----</remarks>
        /// <param name="vectorLeido">Vector leído.</param>
       public void InvertirVector(int[] vectorLeido)
        {
            int j = vectorLeido.Length - 1;

            for (int i = 0; i < vectorLeido.Length; i++)
            {
                vectorAlReves[j] = vectorLeido[i];
                j--;
            }
        }

        /// <summary>
        /// Función que permite mostrar la cadena de números de 
        /// vectorAlReves, con los números en sus nuevas posiciones.
        /// </summary>
        /// <remarks>----</remarks>
        /// <param name="vectorAlReves">Vector con las modificaciones.</param>
        /// <returns>Cadena con los números que conforman vectorAlReves.</returns>
        public string MostrarVectorReves(int[] vectorAlReves)
        {
            string cadenaTexto = "";

            for (int i = 0; i < kTamanyo; i++)
            {
                cadenaTexto = cadenaTexto + vectorAlReves[i] + ", ";
            }
            return cadenaTexto;
        }

        /// <summary>
        /// Manejador de evento que permite leer un vector (vectorLeido), darle la 
        /// vuelta (vectorAlReves) y mostrarlo.
        /// </summary>
        /// <param name="sender">Lanza el botón del evento button1</param>
        /// <param name="e">Sin uso</param>
        public void button1_Click(object sender, EventArgs e)
        {
            string cadenaTexto;

            LeerVector(vectorLeido);
            InvertirVector(vectorLeido);
            cadenaTexto = MostrarVectorReves(vectorAlReves);

            MessageBox.Show(cadenaTexto);
        }
    }
}
