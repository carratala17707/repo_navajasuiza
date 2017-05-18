using System;
using NavajaSuiza;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestApp3
{
    
    [TestClass]
    public class App3Test
    {
        /// <summary>
        /// Caso de prueba App3.1PU.
        /// Los datos son correctos y espero que me devuelva el vector 
        /// con los números repetidos del vector modificados a -1.
        /// </summary>
        [TestMethod]
        public void VectorModificadoCorrecto()
        {
            string cadenaValores = "1,2,4,4,5,6,7,1,9,7";
            int[] vectorEsperado = new int[] { 1, 2, 4, -1, 5, 6, 7, -1, 9, -1 };
            int valoresModificados = 3;

            int[] vectorObtenido = NavajaSuiza.Aplicación_3.Logica.LogicaApp3.
                ComprobarValoresEntrada(cadenaValores, out valoresModificados);

            CollectionAssert.AreEqual(vectorEsperado, vectorObtenido);
        }

        /// <summary>
        /// Caso de prueba App3.2PU.
        /// Los datos son correctos y espero que me devuelva el número de valores
        /// modificados (número de valores que se han repetido).
        /// </summary>
        [TestMethod]
        public void NumValoresModificadosCorrecto()
        {
            string cadenaValores = "1,2,4,4,5,6,7,1,9,7";
            int valoresModificadosEsperados = 3;
            int valoresModificadosObtenidos = 3;

            int[] vectorObtenido = NavajaSuiza.Aplicación_3.Logica.LogicaApp3.
                ComprobarValoresEntrada(cadenaValores, out valoresModificadosObtenidos);

            Assert.AreEqual(valoresModificadosEsperados, valoresModificadosObtenidos);
        }

        /// <summary>
        /// Caso de prueba App3.3PU.
        /// Los datos no son correctos porque no se han introducido los 10
        /// números. Espero que me lance una excepción.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void VectorModificadoFaltanNumeros()
        {
            string cadenaValores = "1,2,4,4,5,6,7,1";
            int valoresModificados = 0;

            NavajaSuiza.Aplicación_3.Logica.LogicaApp3.ComprobarValoresEntrada(
                cadenaValores, out valoresModificados);
        }

        /// <summary>
        /// Caso de prueba App3.4PU.
        /// Los datos no son correctos porque se han introducido más de 10
        /// números. Espero que me lance una excepción.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void VectorModificadoSobranNumeros()
        {
            string cadenaValores = "1,2,4,4,5,6,7,1,9,7,2,1,8";
            int valoresModificados = 0;

            NavajaSuiza.Aplicación_3.Logica.LogicaApp3.ComprobarValoresEntrada(
                cadenaValores, out valoresModificados);
        }

        /// <summary>
        /// Caso de prueba App3.5PU.
        /// Los datos no son correctos porque se ha introducido algún carácter
        /// no numérico. Espero que me lance una excepción.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NavajaSuiza.Excepciones.ArgumentoNoValidoException))]
        public void VectorModificadoElementoNoValido()
        {
            string cadenaValores = "1,2,4,4,5,6,7,1,9,t";
            int valoresModificados = 0;

            NavajaSuiza.Aplicación_3.Logica.LogicaApp3.ComprobarValoresEntrada(
                cadenaValores, out valoresModificados);
        }
    }
}
