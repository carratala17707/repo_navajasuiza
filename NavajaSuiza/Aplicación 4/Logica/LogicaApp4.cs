using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Namespace de la lógica de la aplicación 4.
/// </summary>
namespace NavajaSuiza.Aplicación_4.Logica
{
    /// <summary>
    /// Clase con la lógica de negocio de la aplicación 4.
    /// </summary>
    public class LogicaApp4
    {
        /// <summary>
        /// Cadena constante para la excepción ArgumentException.
        /// </summary>
        public const string cantidadNumerosNoValida = "Introduzca 10 números separados por comas.";
        /// <summary>
        /// Cadena constante para la excepción ArgumentoNoValidoException.
        /// </summary>
        public const string elementoNoValido = "Se ha introducido algún elemento no numérico.";

        /// <summary>
        /// Función que acepta una cadena de valores, determina
        /// si la cadena de valores introducidos es válida y devuelve la cadena de
        /// valores al revés.
        /// <remarks>Si no se han introducido 10 números (kTamanyo) se lanza una excepción 
        /// para que se introduzcan los 10 números separados por comas. Si se han
        /// introducido otros valores, se lanza una excepción indicandolo.</remarks>
        /// </summary>
        /// <param name="cadenaValores">Cadena de valores introducida.</param>
        /// <returns>cadena con el resultado.</returns>
        public static int[] ComprobarValoresEntrada(string cadenaValores)
        {
            string[] numerosIntroducidos = cadenaValores.Split(',');
            bool elementoValido = true;
            const int kTamanyo = 10;
            int[] vectorLeido = new int[kTamanyo];
            int[] vectorAlReves;

            if (numerosIntroducidos.Length != kTamanyo)
            {
                throw new ArgumentException(cantidadNumerosNoValida);
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
                    throw new Excepciones.ArgumentoNoValidoException(elementoNoValido);
                }
                vectorAlReves = InvertirVector(vectorLeido);
            }
            return vectorAlReves;
        }

        /// <summary>
        /// Función que permite darle la vuelta a vectorLeído y 
        /// posicionar los números en vectorAlReves.
        /// </summary>
        /// <remarks>----</remarks>
        /// <param name="vectorLeido">Vector leído.</param>
        public static int[] InvertirVector(int[] vectorLeido)
        {
            int j = vectorLeido.Length - 1;
            int[] vectorAlReves = new int[vectorLeido.Length];

            for (int i = 0; i < vectorLeido.Length; i++)
            {
                vectorAlReves[j] = vectorLeido[i];
                j--;
            }
            return vectorAlReves;
        }

        /// <summary>
        /// Función que permite mostrar la cadena de números de 
        /// vectorAlReves, con los números en sus nuevas posiciones.
        /// </summary>
        /// <remarks>----</remarks>
        /// <param name="vectorAlReves">Vector con las modificaciones.</param>
        /// <returns>Cadena con los números que conforman vectorAlReves.</returns>
        public static string MostrarVectorReves(int[] vectorAlReves)
        {
            string cadenaVector = "";

            for (int i = 0; i < vectorAlReves.Length; i++)
            {
                cadenaVector = cadenaVector + vectorAlReves[i] + ",";
            }
            return cadenaVector;
        }
    }
}
