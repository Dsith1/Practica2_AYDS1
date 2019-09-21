using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica2_AYDS1;
using System.Collections;

namespace Practica2_AYDS1.Tests
{
    /// <summary>
    /// Descripción resumida de PlanillaTest
    /// </summary>
    [TestClass]
    public class PlanillaTest
    {
        public PlanillaTest()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void InsertarValoresCorrectosShouldReturnTrue()
        {
            

            ArrayList valuesTest = new ArrayList();
            valuesTest.Add("2931974320101");
            valuesTest.Add("Juan");
            valuesTest.Add("Pablo");
            valuesTest.Add("Gomez");
            valuesTest.Add("Perez");
            valuesTest.Add("3500");
            Planilla planilla = new Planilla();

            planilla.coneccion = new Coneccion();
            String cadena = "data source = LAPTOP-IFGR27P8; initial catalog = Taller; integrated security = True;";
            planilla.Conexion(cadena);


            Assert.IsTrue(planilla.IngresoDB(valuesTest));
        }
        [TestMethod]
        public void InsertarValoresIncorrectosShouldReturnFalse()
        {
            ArrayList valuesTest = new ArrayList();
            valuesTest.Add("2931974320101");
            valuesTest.Add("Juan");
            valuesTest.Add("Pablo");
            valuesTest.Add("Gomez");
            valuesTest.Add("Perez");
            valuesTest.Add("%$");
            Planilla planilla = new Planilla();

            planilla.coneccion = new Coneccion();
            String cadena = "data source = You Shoul not Pass; initial catalog = Taller; integrated security = True;";
            planilla.Conexion(cadena);

            Assert.IsFalse(planilla.IngresoDB(valuesTest));
        }

        [TestMethod]
        public void CadenaConexionCorrectaShouldReturnTrue()
        {
            String cadena = "data source = LAPTOP-IFGR27P8; initial catalog = Taller; integrated security = True;";
            Planilla p = new Planilla();
            p.coneccion = new Coneccion();
            Assert.IsTrue(p.Conexion(cadena));
        }

        [TestMethod]
        public void CadenaConexionIncorrectaShouldReturnFalse()
        {
            String cadena = "data source = Aqui Fallo; initial catalog = Taller; integrated security = True;";
            Planilla p = new Planilla();
            p.coneccion = new Coneccion();
            Assert.IsFalse(p.Conexion(cadena));
        }
    }
}
