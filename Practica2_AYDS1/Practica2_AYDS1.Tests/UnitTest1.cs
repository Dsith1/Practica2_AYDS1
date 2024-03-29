﻿using System;
using System.Data;
using System.Data.SqlClient;
//using System.Fabric;
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

            a.SetCadena("data source = HILBERTPC; initial catalog = Taller; integrated security = True;");



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

            a.SetCadena("data source = HILBERTPC; initial catalog = Taller; integrated security = True;");

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

            a.coneccion = new Coneccion();

            a.coneccion.SetCadena("data source = HILBERTPC; initial catalog = Taller; integrated security = True;");
            

            Assert.IsNotNull(a.getClientes());


        }

        [TestMethod]
        public void Prueba_nuevo_Cliente()
        {
            WebForm1 a = new WebForm1();

            a.coneccion = new Coneccion();

            a.coneccion.SetCadena("data source = HILBERTPC; initial catalog = Taller; integrated security = True;");

            Assert.IsTrue(a.AgregarCliente("Juan", "Pedro", "Casas", "Casas","2222222"));
            

        }

        [TestMethod]
        public void Prueba_nuevo_Cliente_fail()
        {
            WebForm1 a = new WebForm1();

            a.coneccion = new Coneccion();

            a.coneccion.SetCadena("data source = Otra vez falle; initial catalog = Taller; integrated security = True;");

            Assert.IsFalse(a.AgregarCliente("Juan", "Pedro", "Casas", "Casas", "2222222"));


        }


        [TestMethod]
        public void Prueba_ObtenerProveedor()
        {
            AddProveedor a = new AddProveedor();

            a.coneccion = new Coneccion();

            a.coneccion.SetCadena("data source = LAPTOP-IFGR27P8; initial catalog = Taller; integrated security = True;");


            Assert.IsNotNull(a.getProeveedores());


        }

        [TestMethod]
        public void Prueba_nuevo_Proveedor()
        {
            AddProveedor a = new AddProveedor();

            a.coneccion = new Coneccion();

            a.coneccion.SetCadena("data source = HILBERTPC; initial catalog = Taller; integrated security = True;");

            Assert.IsTrue(a.AgregarProveedor("Juan", "2222222"));


        }

        [TestMethod]
        public void Prueba_nuevo_Proveedor_fail()
        {
            AddProveedor a = new AddProveedor();

            a.coneccion = new Coneccion();

            a.coneccion.SetCadena("data source = Otra vez falle; initial catalog = Taller; integrated security = True;");

            Assert.IsFalse(a.AgregarProveedor("Juan", "2222222"));


        }


        [TestMethod]
        public void Prueba_Conecion_Repuesto()
        {
            CrearRepuesto a = new CrearRepuesto();

            a.coneccion = new Coneccion();

            string resultado=a.Conexion("data source = LAPTOP-IFGR27P8; initial catalog = Taller; integrated security = True;");


            StringAssert.Equals(resultado, "Correcto");


        }

        [TestMethod]
        public void Prueba_Conecion_Repuesto_Fail()
        {
            CrearRepuesto a = new CrearRepuesto();

            a.coneccion = new Coneccion();

            string resultado = a.Conexion("data source = No pasa; initial catalog = Taller; integrated security = True;");


            StringAssert.Equals(resultado, "INCorrecto");


        }

        [TestMethod]
        public void Prueba_nuevo_Repuesto()
        {
            CrearRepuesto a = new CrearRepuesto();

            a.coneccion = new Coneccion();


            a.Conexion("data source = LAPTOP-IFGR27P8; initial catalog = Taller; integrated security = True;");

            Assert.IsTrue(a.IngresarRepuestoM("eje","yaris",2010,"5"));


        }

        [TestMethod]
        public void Prueba_nuevo_Repuesto_fail()
        {
            CrearRepuesto a = new CrearRepuesto();

            a.coneccion = new Coneccion();

            a.Conexion("data source = ahora si me detengo; initial catalog = Taller; integrated security = True;");

            Assert.IsFalse(a.IngresarRepuestoM("eje", "yaris", 2010, "5"));


        }

        [TestMethod]
        public void Prueba_ObtenerCarro()
        {
            ADDCarro a = new ADDCarro();

            a.coneccion = new Coneccion();

            a.coneccion.SetCadena("data source = LAPTOP-IFGR27P8; initial catalog = Taller; integrated security = True;");


            Assert.IsNotNull(a.getCarros());


        }

        [TestMethod]
        public void Prueba_nuevo_Carror()
        {
            ADDCarro a = new ADDCarro();

            a.coneccion = new Coneccion();

            a.coneccion.SetCadena("data source = LAPTOP-IFGR27P8; initial catalog = Taller; integrated security = True;");

            Assert.IsTrue(a.Agregar_Carro("451jkl", "2222222","Negro","Supra",2009,1,1));


        }

        [TestMethod]
        public void Prueba_nuevo_Carro_fail()
        {
            ADDCarro a = new ADDCarro();

            a.coneccion = new Coneccion();

            a.coneccion.SetCadena("data source = Otra vez falle; initial catalog = Taller; integrated security = True;");

            Assert.IsFalse(a.Agregar_Carro("451jkl", "2222222", "Negro","supra", 2009, 1, 1));


        }

        [TestMethod]
        public void Prueba_ObtenerFactura()
        {
            AddFactura a = new AddFactura();

            a.coneccion = new Coneccion();

            a.coneccion.SetCadena("data source = LAPTOP-IFGR27P8; initial catalog = Taller; integrated security = True;");


            Assert.IsNotNull(a.getFacturas());


        }

        [TestMethod]
        public void Prueba_nuevo_Factura()
        {
            AddFactura a = new AddFactura();

            a.coneccion = new Coneccion();

            a.coneccion.SetCadena("data source = LAPTOP-IFGR27P8; initial catalog = Taller; integrated security = True;");

            Assert.IsTrue(a.AgregarFactura("A", 12, "Juan", "Ciudad", "4566-k"));


        }

        [TestMethod]
        public void Prueba_nuevo_Factura_fail()
        {
            AddFactura a = new AddFactura();

            a.coneccion = new Coneccion();

            a.coneccion.SetCadena("data source = Otra vez falle; initial catalog = Taller; integrated security = True;");

            Assert.IsFalse(a.AgregarFactura("A", 12, "Juan", "Ciudad", "4566-k"));


        }

        [TestMethod]
        public void Prueba_ObtenerEntregas()
        {
            AddEntrega a = new AddEntrega();

            a.coneccion = new Coneccion();

            a.coneccion.SetCadena("data source = LAPTOP-IFGR27P8; initial catalog = Taller; integrated security = True;");


            Assert.IsNotNull(a.getEntregas());


        }

        [TestMethod]
        public void Prueba_nuevo_Entregas()
        {
            AddEntrega a = new AddEntrega();

            a.coneccion = new Coneccion();

            a.coneccion.SetCadena("data source = LAPTOP-IFGR27P8; initial catalog = Taller; integrated security = True;");

            Assert.IsTrue(a.Agregar_Carro(1));


        }

        [TestMethod]
        public void Prueba_nuevo_Entrega_fail()
        {
            AddEntrega a = new AddEntrega();

            a.coneccion = new Coneccion();

            a.coneccion.SetCadena("data source = Otra vez falle; initial catalog = Taller; integrated security = True;");

            Assert.IsFalse(a.Agregar_Carro(1));


        }

    }
}
