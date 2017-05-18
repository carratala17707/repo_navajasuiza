using System;
using NavajaSuiza;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestApp1
{
    
    [TestClass]
    public class App1Test
    {
        /// <summary>
        /// Caso de prueba App1.1PU. 
        /// Los datos son correctos y espero que me señale que el número es primo.
        /// </summary>
        [TestMethod]
        public void NumeroEsPrimo2()
        {
            int numeroIntroducido = 2;

            bool esPrimoObtenido = NavajaSuiza.Aplicación_1.Logica.LogicaApp1.
                EsPrimo(numeroIntroducido);

            Assert.IsTrue(esPrimoObtenido);
        }

        /// <summary>
        /// Caso de prueba App1.2PU. 
        /// Los datos son correctos y espero que me señale que el número es primo.
        /// </summary>
        [TestMethod]
        public void NumeroEsPrimo3()
        {
            int numeroIntroducido = 3;

            bool esPrimoObtenido = NavajaSuiza.Aplicación_1.Logica.LogicaApp1.
                EsPrimo(numeroIntroducido);

            Assert.IsTrue(esPrimoObtenido);
        }

        /// <summary>
        /// Caso de prueba App1.3PU.
        /// Los datos son correctos y espero que me señale que el número no es primo.
        /// </summary>
        [TestMethod]
        public void NumeroNoEsPrimo4()
        {
            int numeroIntroducido = 4;

            bool esPrimoObtenido = NavajaSuiza.Aplicación_1.Logica.LogicaApp1.
                EsPrimo(numeroIntroducido);

            Assert.IsFalse(esPrimoObtenido);
        }

        /// <summary>
        /// Caso de prueba App1.4PU.
        /// Los datos no son correctos (debe ser un número mayor que 1)
        /// y espero que me señale que el número no es primo.
        /// </summary>
        [TestMethod]
        public void NumeroNoEsPrimo1()
        {
            int numeroIntroducido = 1;

            bool esPrimoObtenido = NavajaSuiza.Aplicación_1.Logica.LogicaApp1.
                EsPrimo(numeroIntroducido);

            Assert.IsFalse(esPrimoObtenido);
        }

        /// <summary>
        /// Caso de prueba App1.5PU.
        /// Los datos no son correctos (debe ser un número mayor que 1)
        /// y espero que me señale que el número no es primo.
        /// </summary>
        [TestMethod]
        public void NumeroNoEsPrimo0()
        {
            int numeroIntroducido = 0;

            bool esPrimoObtenido = NavajaSuiza.Aplicación_1.Logica.LogicaApp1.
                EsPrimo(numeroIntroducido);

            Assert.IsFalse(esPrimoObtenido);
        }

        /// <summary>
        /// Caso de prueba App1.6PU.
        /// Los datos son correctos y espero que me señale que el número es primo.
        /// </summary>
        [TestMethod]
        public void NumeroEsPrimoMaxValor() 
        {
            int numeroIntroducido = int.MaxValue;

            bool esPrimoObtenido = NavajaSuiza.Aplicación_1.Logica.LogicaApp1.
                EsPrimo(numeroIntroducido);

            Assert.IsTrue(esPrimoObtenido);
        }

        /// <summary>
        /// Caso de prueba App1.7PU.
        /// Los datos son correctos y espero que me señale que el número es primo.
        /// </summary>
        [TestMethod]
        public void NumeroNoEsPrimoMaxValorMenos1()
        {
            int numeroIntroducido = int.MaxValue - 1;

            bool esPrimoObtenido = NavajaSuiza.Aplicación_1.Logica.LogicaApp1.
                EsPrimo(numeroIntroducido);

            Assert.IsFalse(esPrimoObtenido);
        }

        /// <summary>
        /// Caso de prueba App1.8PU.
        /// Los datos no son correctos (debe ser un número mayor que 1)
        /// y espero que me señale que el número no es primo.
        /// </summary>
        [TestMethod]
        public void NumeroNoEsPrimoMinValor()
        {
            int numeroIntroducido = int.MinValue;

            bool esPrimoObtenido = NavajaSuiza.Aplicación_1.Logica.LogicaApp1.
                EsPrimo(numeroIntroducido);

            Assert.IsFalse(esPrimoObtenido);
        }

        /// <summary>
        /// Caso de prueba App1.9PU.
        /// Los datos no son correctos (debe ser un número mayor que 1)
        /// y espero que me señale que el número no es primo.
        /// </summary>
        [TestMethod]
        public void NumeroNoEsPrimoMinValorMas1()
        {
            int numeroIntroducido = int.MinValue + 1;

            bool esPrimoObtenido = NavajaSuiza.Aplicación_1.Logica.LogicaApp1.
                EsPrimo(numeroIntroducido);

            Assert.IsFalse(esPrimoObtenido);
        }
    }
}
