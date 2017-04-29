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
        /// Se inicializa la constante kTamanyo (tamaño del vector)
        /// y los vectores a utilizar.
        /// <remarks>----</remarks>
        /// </summary>
        const int kTamanyo = 10;
        int[] vectorLeido = new int[kTamanyo];
        int[] vectorAlReves = new int[kTamanyo];

        /// <summary>
        /// Función que permite leer un vector de enteros y determinar
        /// si los elementos introducidos son válidos.
        /// <remarks>Si no se han introducido 10 números (kTamanyo) se
        /// pide que se introduzcan.</remarks>
        /// </summary>
        /// <param name="vectorLeido">Vector creado.</param>
        /// <returns>Si los elementos del vector son válidos.</returns>
        public bool LeerVector(int[] vectorLeido)
        {
            string cadenaNumeros = textIntroducNumApp4.Text;
            string[] numerosIntroducidos = cadenaNumeros.Split(',');
            bool elementoValido = true;

            if (numerosIntroducidos.Length != kTamanyo)
            {
                MessageBox.Show("Introduzca 10 números");
                elementoValido = false;
            }
            else
            {
                for (int i = 0; i < kTamanyo && elementoValido; i++)
                {
                    int numero;

                    elementoValido = int.TryParse(numerosIntroducidos[i], out numero);

                    if (elementoValido)
                    {
                        vectorLeido[i] = numero;
                    }
                }

                if (!elementoValido)
                {
                    MessageBox.Show("Se ha introducido algún elemento no numérico.");
                }
            }
            return elementoValido;
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
        /// <param name="sender">Lanza el botón del evento botonAppVectorReves.</param>
        /// <param name="e">Sin uso.</param>
        public void botonAppVectorReves_Click(object sender, EventArgs e)
        {
            string cadenaTexto;
            bool datosValidos = LeerVector(vectorLeido);

            if (datosValidos)
            {
                InvertirVector(vectorLeido);
                cadenaTexto = MostrarVectorReves(vectorAlReves);

                MessageBox.Show(cadenaTexto);
            }   
        }
    }
}
