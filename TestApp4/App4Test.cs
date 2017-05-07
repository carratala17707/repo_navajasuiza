using System;
using NavajaSuiza;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>
/// Namespace del proyecto de pruebas de la Aplicación 4.
/// </summary>
namespace TestApp4
{
    /// <summary>
    /// Clase de pruebas App4Test.
    /// </summary>
    [TestClass]
    public class App4Test
    {
        /// <summary>
        /// Caso de prueba App4.1PU.
        /// Los datos son correctos y espero que me devuelva el vector 
        /// con los números al revés.
        /// </summary>
        [TestMethod]
        public void VectorRevesCorrecto()
        {
            string cadenaValores = "1,2,3,4,5,6,7,8,9,10";
            int[] vectorAlRevesEsperado = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            int[] vectorAlRevesObtenido = NavajaSuiza.Aplicación_4.Logica.LogicaApp4.
                ComprobarValoresEntrada(cadenaValores);

            CollectionAssert.AreEqual(vectorAlRevesEsperado, vectorAlRevesObtenido);
        }

        /// <summary>
        /// Caso de prueba App4.2PU.
        /// Los datos no son correctos porque no se han introducido los 10
        /// números. Espero que me lance una excepción.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void VectorRevesFaltanNumeros()
        {
            string cadenaValores = "1,2,3,4,5,6,7,8";

            NavajaSuiza.Aplicación_4.Logica.LogicaApp4.ComprobarValoresEntrada(cadenaValores);
        }

        /// <summary>
        /// Caso de prueba App4.3PU.
        /// Los datos no son correctos porque se han introducido más de 10
        /// números. Espero que me lance una excepción.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void VectorRevesSobranNumeros()
        {
            string cadenaValores = "1,2,3,4,5,6,7,8,9,10,11,12,13";

            NavajaSuiza.Aplicación_4.Logica.LogicaApp4.ComprobarValoresEntrada(cadenaValores);
        }

        /// <summary>
        /// Caso de prueba App4.4PU.
        /// Los datos no son correctos porque se ha introducido algún carácter
        /// no numérico. Espero que me lance una excepción.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NavajaSuiza.Excepciones.ArgumentoNoValidoException))]
        public void VectorRevesElementoNoValido()
        {
            string cadenaValores = "1,2,3,4,5,6,7,8,9,t";

            NavajaSuiza.Aplicación_4.Logica.LogicaApp4.ComprobarValoresEntrada(cadenaValores);
        }
    }
}
