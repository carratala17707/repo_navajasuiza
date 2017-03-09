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
/// Namespace de la aplicación3
/// </summary>
namespace NavajaSuiza.Aplicación_3
{
    /// <summary>
    /// Formulario que ejecuta la lógica de la aplicación 3.
    /// </summary>
    public partial class FrmAplicacion3 : Form
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
        /// Función que permite leer un vector de enteros.
        /// </summary>
        /// <remarks>Permitirá introducir números
        /// hasta que se llegue al tamaño total del vector.</remarks>
        /// <param name="vectorNumeros">Vector creado.</param>
        public void LeerVector(int[] vectorNumeros)
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
                        vectorNumeros[i] = numeroIntroducido;
                    }
                    else
                    {
                        MessageBox.Show("Introduzca un elemento válido.");
                    }
                } while (!elementoValido);
            }
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
        /// <param name="sender">Lanza el botón del evento button1</param>
        /// <param name="e">Sin uso</param>
        public void button1_Click(object sender, EventArgs e)
        {
            LeerVector(vectorNumeros);
            int contador = ModificarRepetidos(vectorNumeros);
            string texto = MostrarVector(vectorNumeros);

            MessageBox.Show(texto + " el número de valores modificados es: " + 
                contador);
        }
    }
}
