using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace PruebaTest
{
    [TestClass]
    public class Pruebas

    {
        [TestMethod]
        public void CompararCliente()
        {
            Cliente c1 = new(12345677, "juan", "perz");
            Cliente c2 = new(12345677, "juan", "perz");

            Assert.IsTrue(c1 == c2);
        }


        [TestMethod]
        [ExpectedException(typeof(TraerDatosException))]
        public void ExcepcionTraerDatos()
        {
            Cliente.LeerDesdeJson("pruebasss");
        }

    }
}
