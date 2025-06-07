using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Formas
{
    [TestFixture]
    public class TrianguloEquilateroTests
    {
        [Test]
        public void TestAreaYPerimetroTriangulo()
        {
            var triangulo = new TrianguloEquilatero(6);
            Assert.AreEqual(((decimal)System.Math.Sqrt(3) / 4) * 36, triangulo.CalcularArea());
            Assert.AreEqual(18, triangulo.CalcularPerimetro());
        }
    }
}
