using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Formas
{
    [TestFixture]
    public class CirculoTests
    {
        [Test]
        public void TestAreaYPerimetroCirculo()
        {
            var circulo = new Circulo(10);
            Assert.AreEqual((decimal)System.Math.PI * 25, circulo.CalcularArea());
            Assert.AreEqual((decimal)System.Math.PI * 10, circulo.CalcularPerimetro());
        }
    }
}
