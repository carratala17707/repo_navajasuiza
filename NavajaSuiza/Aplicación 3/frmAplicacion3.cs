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
        /// Se inicializa la constante kTamanyo (tamaño del vector)
        /// y el vector.
        /// <remarks>----</remarks>
        /// </summary>
        const int kTamanyo = 10;
        int[] vectorNumeros = new int[kTamanyo];

        /// <summary>
        /// Función que permite leer un vector de enteros y determinar
        /// si los elementos introducidos son válidos.
        /// </summary>
        /// <remarks>Si no se han introducido 10 números (kTamanyo) se
        /// pide que se introduzcan.</remarks>
        /// <param name="vectorNumeros">Vector creado.</param>
        /// <returns>Si los elementos del vector son válidos.</returns>
        public bool LeerVector(int[] vectorNumeros)
        {
            string cadenaNumeros = textIntroducNumApp3.Text;
            string[] numerosIntroducidos = cadenaNumeros.Split(',');
            bool elementoValido = true;

            if (numerosIntroducidos.Length != kTamanyo)
            {
                MessageBox.Show("Introduzca 10 números.");
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
                        vectorNumeros[i] = numero;
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
        /// Función que permite intercambiar los números introducidos que
        /// estén repetidos por -1 y contar la cantidad de números modificados.
        /// </summary>
        /// <remarks>----</remarks>
        /// <param name="vectorNumeros">Vector leído.</param>
        /// <returns>Contador de números modificados.</returns>
        public int ModificarRepetidos(int[] vectorNumeros)
        {
            int contadorRepeticiones = 0;

            for (int i = 0; i < kTamanyo; i++)
            {
                if (vectorNumeros[i] != -1)
                {
                    for (int j = i + 1; j < vectorNumeros.Length; j++)
                    {
                        if (vectorNumeros[i] == vectorNumeros[j])
                        {
                            vectorNumeros[j] = -1;
                            contadorRepeticiones++;
                        }
                    }
                }
            }
            return contadorRepeticiones;
        }

        /// <summary>
        /// Función que permite mostrar la cadena de números introducidos
        /// con las modificaciones pertinentes.
        /// </summary>
        /// <remarks>----</remarks>
        /// <param name="vectorNumeros">Vector leído y modificado.</param>
        /// <returns>Cadena con los números del vector.</returns>
        public string MostrarVector(int[] vectorNumeros)
        {
            string cadenaTexto = "";

            for (int i = 0; i < kTamanyo; i++)
            {
                cadenaTexto = cadenaTexto + vectorNumeros[i] + ", ";
            }
            return cadenaTexto;
        }

        /// <summary>
        /// Manejador de evento que permite leer un vector, contar el número de valores
        /// repetidos modificados por -1 y mostrarlo con las modificaciones.
        /// </summary>
        /// <param name="sender">Lanza el botón del evento botonAppRepetidos.</param>
        /// <param name="e">Sin uso.</param>
        public void botonAppRepetidos_Click(object sender, EventArgs e)
        {
            bool datosValidos = LeerVector(vectorNumeros);

            if (datosValidos)
            {
                int contador = ModificarRepetidos(vectorNumeros);
                string texto = MostrarVector(vectorNumeros);

                MessageBox.Show(texto + " el número de valores modificados es: " +
                    contador);
            }
        }
    }
}
