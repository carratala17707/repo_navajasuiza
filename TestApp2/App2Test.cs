using System;
using NavajaSuiza;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>
/// Namespace del proyecto de pruebas de la Aplicación 2.
/// </summary>
namespace TestApp2
{
    /// <summary>
    /// Clase de pruebas App2Test.
    /// </summary>
    [TestClass]
    public class App2Test
    {
        /// <summary>
        /// Caso de prueba App2.1PU.
        /// Los datos son correctos y espero que devuelva la cadena de múltiplos.
        /// </summary>
        [TestMethod]
        public void SerieMultiplosCorrecta6()
        {
            int numeroIntroducido = 6;
            string cadenaTextoEsperada = "3, 5, 6, ";

            string cadenaTextoObtenida = NavajaSuiza.Aplicación_2.Logica.LogicaApp2.
                MostrarSerieMultiplos(numeroIntroducido);

            Assert.AreEqual(cadenaTextoEsperada, cadenaTextoObtenida);
        }

        /// <summary>
        /// Caso de prueba App2.2PU.
        /// Los datos son correctos y espero que no se añadan a la cadena
        /// porque no son múltiplos ni de 3 ni de 5.
        /// </summary>
        [TestMethod]
        public void SerieMultiplosCorrecta2()
        {
            int numeroIntroducido = 2;
            string cadenaTextoEsperada = "";

            string cadenaTextoObtenida = NavajaSuiza.Aplicación_2.Logica.LogicaApp2.
                MostrarSerieMultiplos(numeroIntroducido);

            Assert.AreEqual(cadenaTextoEsperada, cadenaTextoObtenida);
        }

        /// <summary>
        /// Caso de prueba App2.3PU.
        /// Los datos no son correctos porque el 0 no entra dentro del 
        /// rango de intérvalos permitidos. Espero que me lance la excepción
        /// y me indique que introduzca un número válido.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SerieMultiplosIncorrecta0()
        {
            int numeroIntroducido = 0;

            NavajaSuiza.Aplicación_2.Logica.LogicaApp2.
                MostrarSerieMultiplos(numeroIntroducido);
        }

        /// <summary>
        /// Caso de prueba App2.4PU.
        /// Los datos no son correctos porque el 101 no entra dentro del 
        /// rango de intérvalos permitidos.Espero que me lance la excepción
        /// y me indique que introduzca un número válido.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SerieMultiplosIncorrecta101()
        {
            int numeroIntroducido = 101; 

            NavajaSuiza.Aplicación_2.Logica.LogicaApp2.
                MostrarSerieMultiplos(numeroIntroducido);
        }

        /// <summary>
        /// Caso de prueba App2.5PU.
        /// Los datos no son correctos porque el máximo valor no entra dentro del 
        /// rango de intérvalos permitidos.Espero que me lance la excepción
        /// y me indique que introduzca un número válido.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SerieMultiplosIncorrectaMaxValor()
        {
            int numeroIntroducido = int.MaxValue;

            NavajaSuiza.Aplicación_2.Logica.LogicaApp2.
                MostrarSerieMultiplos(numeroIntroducido);
        }

        /// <summary>
        /// Caso de prueba App2.6PU.
        /// Los datos no son correctos porque el mínimo valor no entra dentro del 
        /// rango de intérvalos permitidos.Espero que me lance la excepción
        /// y me indique que introduzca un número válido.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SerieMultiplosIncorrectaMinValor()
        {
            int numeroIntroducido = int.MinValue;

            NavajaSuiza.Aplicación_2.Logica.LogicaApp2.
                MostrarSerieMultiplos(numeroIntroducido);
        }
    }
}
