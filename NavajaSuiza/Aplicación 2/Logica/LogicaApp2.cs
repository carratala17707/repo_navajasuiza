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
    class LogicaApp2
    {
        /// <summary>
        /// Función que verifica si un número está comprendido entre el 1 y el 100.
        /// de ser así, se considera válido.
        /// </summary>
        /// <remarks>Si el número no es válido, saltará un mensaje para que
        /// se introduzca otro número.</remarks>
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
        /// <remarks>----</remarks>
        /// <param name="numeroIntroducido">Número que introduce el usuario.</param>
        /// <returns>Cadena con los múltiplos de 3 y 5.</returns>
        public static string MostrarSerieMultiplos(int numeroIntroducido)
        {
            string cadenaTexto = "";

            for (int i = 1; i <= numeroIntroducido; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    cadenaTexto = cadenaTexto + i + ", ";
                }
            }
            return cadenaTexto;
        }

        /// <summary>
        /// Función que comprueba si un elemento introducido es válido o no 
        /// y devuelve un mensaje con el resultado. 
        /// </summary>
        /// <remarks>Si es válido y está en el intérvalo devuelve la cadena de múltiplos
        /// si es válido pero está fuera del intérvalo indicará que se introduzca
        /// otro número y si no es válido indica que se introduzca un elemento válido.</remarks>
        /// <param name="numero">Cadena introducida en el textbox.</param>
        /// <returns>El mensaje de resultado.</returns>
        public static string ComprobarNumero(string numero)
        {
            bool numeroValido = true;
            int numeroIntroducido;
            string mensaje;

            bool elementoValido = int.TryParse(numero, out numeroIntroducido);

            if (elementoValido)
            {
                numeroValido = ValidarNumero(numeroIntroducido);

                if (numeroValido == false)
                {
                    mensaje = "Introduzca un número entre 1 y 100.";
                }
                else
                {
                    mensaje = MostrarSerieMultiplos(numeroIntroducido);
                }
            }
            else
            {
                mensaje = "Introduzca un elemento válido.";
            }
            return mensaje;
        }
    }
}
