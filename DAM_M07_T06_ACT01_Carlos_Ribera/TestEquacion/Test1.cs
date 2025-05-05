using Microsoft.VisualStudio.TestTools.UnitTesting;
using Equacion;
using System.Drawing;
using System.Linq;

namespace TestEquacion
{
    [TestClass]
    public class Test1
    {
        // Prueba para comprobar que el vértice
        [TestMethod]
        public void TestVertice()
        {
            // Creo la ecuación
            var eq = new Eq2(1, -2, -3);

            // Llamo al método vertice y guardo el resultado
            PointF v = eq.vertice();

            // Compruebo que el vértice sea el esperado: (1, -4)
            Assert.AreEqual(1f, v.X);
            Assert.AreEqual(-4f, v.Y);
        }

        // Prueba para verificar que el foco se calcula bien
        [TestMethod]
        public void TestFoco()
        {
            // Ecuación
            var eq = new Eq2(1, -2, -3);

            // Llamo al método foco y guardo el punto que devuelve
            PointF f = eq.foco();

            // El foco debería estar en (1, -3.75)
            Assert.AreEqual(1f, f.X);
            Assert.AreEqual(-3.75f, f.Y);
        }

        // Prueba de los puntos de corte
        [TestMethod]
        public void TestCortes()
        {
            // Ecuación
            var eq = new Eq2(1, -2, -3);

            // Llamo al método cortes y recojo el array de soluciones
            double[] r = eq.cortes();

            // Verifico que no es null y que tiene exactamente 2 soluciones
            Assert.IsNotNull(r);
            Assert.AreEqual(2, r.Length);

            // Las soluciones deben ser 3 y -1
            Assert.IsTrue(r.Contains(3.0));
            Assert.IsTrue(r.Contains(-1.0));
        }

        // Prueba para una ecuación sin soluciones reales
        [TestMethod]
        public void TestCortesSinSoluciones()
        {
            // Ecuación
            var eq = new Eq2(1, 1, 1);

            // Llamo a cortes y debería devolver null
            double[] r = eq.cortes();

            // Confirmo que devuelve null al no haber cortes reales
            Assert.IsNull(r);
        }
    }
}
