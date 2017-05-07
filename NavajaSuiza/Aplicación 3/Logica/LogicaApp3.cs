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
    public class LogicaApp3
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
        /// si dicha cadena es válida y devuelve la cadena con los números
        /// repetidos cambiados por -1, además del contador de repeticiones.
        /// </summary>
        /// <remarks>Si no se han introducido 10 números (kTamanyo) se lanza una excepción 
        /// para que se introduzcan los 10 números separados por comas. Si se han
        /// introducido otros valores, se lanza una excepción indicandolo.</remarks>
        /// <param name="cadenaValores">Cadena de valores introducida.</param>
        /// <param name="modificaciones">Modificaciones realizadas en el vector.</param>
        /// <returns>cadena con el resultado.</returns>
        public static int[] ComprobarValoresEntrada(string cadenaValores, out int modificaciones)
        {
            string[] numerosIntroducidos = cadenaValores.Split(',');
            bool elementoValido = true;
            const int kTamanyo = 10;
            int[] vectorNumeros = new int[kTamanyo];

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
                        vectorNumeros[i] = numero;
                    }
                }

                if (!elementoValido)
                {
                    throw new Excepciones.ArgumentoNoValidoException(elementoNoValido);
                }
                modificaciones = ModificarRepetidos(vectorNumeros);
            }
            return vectorNumeros;
        }

        /// <summary>
        /// Función que permite intercambiar los números introducidos que
        /// estén repetidos por -1 y contar la cantidad de números modificados.
        /// </summary>
        /// <remarks>----</remarks>
        /// <param name="vectorNumeros">Vector leído.</param>
        /// <returns>Contador de números modificados.</returns>
        private static int ModificarRepetidos(int[] vectorNumeros)
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
        /// Función que permite mostrar la cadena de números.
        /// </summary>
        /// <remarks>----</remarks>
        /// <param name="vectorNumeros">Vector leído y modificado.</param>
        /// <returns>Cadena con los números del vector.</returns>
        public static string MostrarVector(int[] vectorNumeros)
        {
            string cadenaVector = "";

            for (int i = 0; i < vectorNumeros.Length; i++)
            {
                cadenaVector = cadenaVector + vectorNumeros[i] + ",";
            }
            return cadenaVector;
        }
    }
}
