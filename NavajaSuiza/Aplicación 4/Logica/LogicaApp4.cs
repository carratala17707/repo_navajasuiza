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
    class LogicaApp4
    {
        /// <summary>
        /// Función que permite leer un vector, determinar
        /// si la cadena de valores introducidos es válida y dar un mensaje
        /// con el resultado.
        /// <remarks>Si no se han introducido 10 números (kTamanyo) se lanza una excepción 
        /// para que se introduzcan los 10 números separados por comas. Si se han
        /// introducido otros valores, se lanza una excepción indicandolo.</remarks>
        /// </summary>
        /// <param name="cadenaValores">Cadena de valores introducida.</param>
        /// <returns>Mensaje con el resultado.</returns>
        public static string ComprobarValoresEntrada(string cadenaValores)
        {
            string[] numerosIntroducidos = cadenaValores.Split(',');
            bool elementoValido = true;
            string mensaje;
            string cadenaVector;
            const int kTamanyo = 10;
            int[] vectorLeido = new int[kTamanyo];
            int[] vectorAlReves = new int[kTamanyo];

            if (numerosIntroducidos.Length != kTamanyo)
            {
                throw new Util.ArgumentoNoValidoException(
                    "Introduzca 10 números separados por comas.");
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
                    throw new Util.ArgumentoNoValidoException(
                        "Se ha introducido algún elemento no numérico.");
                }
                else
                {
                    InvertirVector(vectorLeido, vectorAlReves);
                    cadenaVector = MostrarVectorReves(vectorAlReves);
                    mensaje = "El vector al revés queda: \n" + cadenaVector;
                }
            }
            return mensaje;
        }

        /// <summary>
        /// Función que permite darle la vuelta a vectorLeído y 
        /// posicionar los números en vectorAlReves.
        /// </summary>
        /// <remarks>----</remarks>
        /// <param name="vectorLeido">Vector leído.</param>
        /// <param name="vectorAlReves">Vector al revés.</param>
        public static void InvertirVector(int[] vectorLeido, int[] vectorAlReves)
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
        public static string MostrarVectorReves(int[] vectorAlReves)
        {
            string cadenaVector = "";

            for (int i = 0; i < vectorAlReves.Length; i++)
            {
                cadenaVector = cadenaVector + vectorAlReves[i] + ", ";
            }
            return cadenaVector;
        }
    }
}
