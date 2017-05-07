using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Namespace de la lógica de la aplicación 2.
/// </summary>
namespace NavajaSuiza.Aplicación_2.Logica
{
    /// <summary>
    /// Clase con la lógica de negocio de la aplicación 2.
    /// </summary>
    public class LogicaApp2
    {
        /// <summary>
        /// Cadena constante para la excepción ArgumentOutOfRangeException.
        /// </summary>
        public const string numeroFueraDeRango = "Introduzca un número entre 1 y 100.";
        /// <summary>
        /// Cadena constante para la excepción ArgumentoNoValidoException.
        /// </summary>
        public const string elementoNoValido = "Introduzca un elemento válido.";

        /// <summary>
        /// Función que verifica si un número está comprendido entre el 1 y el 100.
        /// de ser así, se considera válido.
        /// </summary>
        /// <remarks>---</remarks>
        /// <param name="numeroIntroducido">Número que introduce el usuario.</param>
        /// <returns>Si es válido o no.</returns>
        public static bool ValidarNumero(int numeroIntroducido)
        {
            bool numeroValido = false;

            if (numeroIntroducido >= 1 && numeroIntroducido <= 100)
            {
                numeroValido = true;
            }
            return numeroValido;
        }

        /// <summary>
        /// Función que devuelve la cadena de números múltiplos de 3 y 5 
        /// comprendidos hasta el número que introduzca el usuario.
        /// </summary>
        /// <remarks>Si introduzco un número no válido, me lanza una 
        /// excepción para que introduzca un número entre el 1 y el 100.</remarks>
        /// <param name="numeroIntroducido">Número que introduce el usuario.</param>
        /// <returns>Cadena con los múltiplos de 3 y 5.</returns>
        public static string MostrarSerieMultiplos(int numeroIntroducido)
        {
            string cadenaTexto = "";
            bool numeroValido = true;

            numeroValido = ValidarNumero(numeroIntroducido);

            if (numeroValido == false)
            {
                throw new ArgumentOutOfRangeException(numeroFueraDeRango);
            }
            else
            {
                for (int i = 1; i <= numeroIntroducido; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        cadenaTexto = cadenaTexto + i + ", ";
                    }
                }
            }
            return cadenaTexto;
        }

        /// <summary>
        /// Función que comprueba si un elemento introducido es válido o no 
        /// y devuelve un mensaje con el resultado. 
        /// </summary>
        /// <remarks>Si es válido y está en el intérvalo devuelve la cadena de múltiplos.
        /// Si es válido pero está fuera del intérvalo se lanzará una excepción que
        /// indicará que se introduzca otro número y si no es válido se lanzará la excepción 
        /// indicando que se introduzca un elemento válido.</remarks>
        /// <param name="numero">Elemento introducido en el textbox.</param>
        /// <returns>El mensaje de resultado.</returns>
        public static string ComprobarNumero(string numero)
        {
            int numeroIntroducido;
            string cadenaTexto;

            bool elementoValido = int.TryParse(numero, out numeroIntroducido);

            if (elementoValido)
            {
                cadenaTexto = MostrarSerieMultiplos(numeroIntroducido);
            }
            else
            {
                throw new Excepciones.ArgumentoNoValidoException(elementoNoValido);
            }
            return cadenaTexto;
        }
    }
}
