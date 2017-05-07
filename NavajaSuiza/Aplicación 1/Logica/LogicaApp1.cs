using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Namespace de la lógica de la aplicación 1.
/// </summary>
namespace NavajaSuiza.Aplicación_1.Logica
{
    /// <summary>
    /// Clase con la lógica de negocio de la aplicación 1.
    /// </summary>
    public class LogicaApp1
    {
        /// <summary>
        /// Cadena constante para la excepción ArgumentoNoValidoException.
        /// </summary>
        public const string elementoNoValido = "Introduzca un elemento válido.";

        /// <summary>
        /// Función que verifica si un número positivo introducido es o no es primo.
        /// </summary>
        /// <remarks>----</remarks>
        /// <param name="numeroIntroducido">Número que introduce el usuario.</param>
        /// <returns>Si es primo o no.</returns>
        public static bool EsPrimo(int numeroIntroducido)
        {
            bool esPrimo = true;

            if (numeroIntroducido > 1)
            {
                for (int i = 2; i < numeroIntroducido && esPrimo; i++)
                {
                    if (numeroIntroducido % i == 0)
                    {
                        esPrimo = false;
                    }
                }
            }
            else
            {
                esPrimo = false;
            }
            return esPrimo;
        }

        /// <summary>
        /// Función que comprueba si un elemento introducido es válido o no 
        /// y devuelve un mensaje con el resultado. 
        /// </summary>
        /// <remarks>Si es válido devuelve si es primo o no y si no es válido
        /// se lanza una excepción indicando que se introduzca un elemento válido.
        /// </remarks>
        /// <param name="numero">Elemento introducido en el textbox.</param>
        /// <returns>El mensaje de resultado.</returns>
        public static string ComprobarNumero(string numero)
        {
            bool esPrimo;
            int numeroIntroducido;
            string mensaje;

            bool elementoValido = int.TryParse(numero, out numeroIntroducido);

            if (elementoValido)
            {
                esPrimo = EsPrimo(numeroIntroducido);

                if (esPrimo)
                {
                    mensaje = "El número es primo.";
                }
                else
                {
                    mensaje = "El número no es primo.";
                }
            }
            else
            {
                throw new Excepciones.ArgumentoNoValidoException(
                    elementoNoValido);
            }
            return mensaje;
        }
    }
}
