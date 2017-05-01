using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaSuiza.Util
{
    /// <summary>
    /// 
    /// </summary>
    public class ArgumentoNoValidoException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public ArgumentoNoValidoException() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public ArgumentoNoValidoException(string message) : base(message) { }

         //try
         //   {
         //       NavajaSuiza.Aplicación_1.Logica.LogicaApp1.Almendra(-3);
         //   }
         //   catch (Util.ArgumentoNoValidoException ex)
         //   {
         //       MessageBox.Show(ex.Message, "Oieeee!", MessageBoxButtons.OK);
         //   }
    }
}
