using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Namespace de la lógica de la aplicación 3.
/// </summary>
namespace NavajaSuiza.Aplicación_3.Logica
{
    /// <summary>
    /// Clase con la lógica de negocio de la aplicación 3.
    /// </summary>
    class LogicaApp3
    {
        /// <summary>
        /// Función que permite leer un vector, determinar
        /// si la cadena de valores introducidos es válida y dar un mensaje
        /// con el resultado.
        /// </summary>
        /// <remarks>Si no se han introducido 10 números (kTamanyo) se lanza una excepción 
        /// para que se introduzcan los 10 números separados por comas. Si se han
        /// introducido otros valores, se lanza una excepción indicandolo.</remarks>
        /// <param name="cadenaValores">Cadena de valores introducida.</param>
        /// <returns>Mensaje con el resultado.</returns>
        public static string ComprobarValoresEntrada(string cadenaValores)
        {
            string[] numerosIntroducidos = cadenaValores.Split(',');
            bool elementoValido = true;
            string mensaje;
            int contadorRepeticiones;
            string cadenaVector;
            const int kTamanyo = 10;
            int[] vectorNumeros = new int[kTamanyo];

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
                        vectorNumeros[i] = numero;
                    }
                }

                if (!elementoValido)
                {
                    throw new Util.ArgumentoNoValidoException(
                        "Se ha introducido algún elemento no numérico.");
                }
                else
                {
                    contadorRepeticiones = ModificarRepetidos(vectorNumeros);
                    cadenaVector = MostrarVector(vectorNumeros);
                    mensaje = cadenaVector + " el número de valores modificados es: " +
                        contadorRepeticiones;
                }
            }
            return mensaje;
        }

        /// <summary>
        /// Función que permite intercambiar los números introducidos que
        /// estén repetidos por -1 y contar la cantidad de números modificados.
        /// </summary>
        /// <remarks>----</remarks>
        /// <param name="vectorNumeros">Vector leído.</param>
        /// <returns>Contador de números modificados.</returns>
        public static int ModificarRepetidos(int[] vectorNumeros)
        {
            int contadorRepeticiones = 0;

            for (int i = 0; i < vectorNumeros.Length; i++)
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
        public static string MostrarVector(int[] vectorNumeros)
        {
            string cadenaVector = "";

            for (int i = 0; i < vectorNumeros.Length; i++)
            {
                cadenaVector = cadenaVector + vectorNumeros[i] + ", ";
            }
            return cadenaVector;
        }
    }
}
