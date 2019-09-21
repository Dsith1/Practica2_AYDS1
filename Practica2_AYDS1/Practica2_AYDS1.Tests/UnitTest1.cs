using System;
using System.Data;
using System.Data.SqlClient;
using System.Fabric;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Web_Practica2_AYD1;

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
        public void Prueba_Cambio_Cadena_Connecion()
        {
            Coneccion a = new Coneccion();
            a.SetCadena("hola");

            StringAssert.Contains(a.resultado, "hola");
        }

        [TestMethod]
        public void Prueba_Cadena_Coneccion_Exito()
        {


            Coneccion a = new Coneccion();

            a.SetCadena("data source = LAPTOP-IFGR27P8; initial catalog = Taller; integrated security = True;");



            Assert.IsNotNull(a.conectar());

        }

        [TestMethod]
        public void Prueba_Cadena_Coneccion_Fracaso()
        {


            Coneccion a = new Coneccion();

            a.SetCadena("data source = JAJA XD XD; initial catalog = Taller; integrated security = True;");



            Assert.IsNull(a.conectar());

        }

        [TestMethod]
        public void Prueba_Cadena_DesConeccion_Exito()
        {


            Coneccion a = new Coneccion();

            a.SetCadena("data source = LAPTOP-IFGR27P8; initial catalog = Taller; integrated security = True;");

            SqlConnection probando= a.conectar();

            probando = a.desconectar();

            Assert.IsNotNull(probando);

        }

        [TestMethod]
        public void Prueba_Cadena_DesConeccion_Fracaso()
        {


            Coneccion a = new Coneccion();

            a.SetCadena("data source = JAJA XD XD; initial catalog = Taller; integrated security = True;");

            SqlConnection probando = a.conectar();

            probando = a.desconectar();

            Assert.IsNull(probando);

        }

        [TestMethod]
        public void Prueba_ObtenerCLientes()
        {
            WebForm1 a = new WebForm1();

            Assert.IsNull(a.getClientes());







        }

    }
}
