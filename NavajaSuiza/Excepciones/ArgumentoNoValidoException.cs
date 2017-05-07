using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Namespace de la excepción creada. 
/// </summary>
namespace NavajaSuiza.Excepciones
{
    /// <summary>
    /// Clase de la excepción que hemos creado. Esta excepción será lanzada
    /// cuando el programa identifique un elemento introducido que no es
    /// válido (letras, sígnos, etc.).
    /// </summary>
    public class ArgumentoNoValidoException : System.Exception
    {
        /// <summary>
        /// Constructor de nuestra excepción.
        /// </summary>
        public ArgumentoNoValidoException() { }

        /// <summary>
        /// Constructor de nuestra excepción.
        /// </summary>
        /// <param name="message">Mensaje que devolverá.</param>
        public ArgumentoNoValidoException(string message) : base(message) { }
    }
}
