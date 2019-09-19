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
    }
}
