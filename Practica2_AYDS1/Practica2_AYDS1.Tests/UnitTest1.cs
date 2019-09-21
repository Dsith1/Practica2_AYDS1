using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practica2_AYDS1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Inicio a = new Inicio();
            a.prueba();

            StringAssert.Contains(a.a, "hola");
        }
        [TestMethod]
        public void TestMethodConexion()
        {
            //Arrange
            var cadena = "Data Source=HILBERTPC;Initial Catalog=Taller; Integrated Security=True";
            var resultadoEsperado = "Correcto";
            CrearRepuesto conec = new CrearRepuesto();
            //Act 
            var result = conec.Conexion(cadena);

            //Result
            Assert.AreEqual(resultadoEsperado, result);
        }
    }
}
