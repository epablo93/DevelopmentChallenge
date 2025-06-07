using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Formas
{
    [TestFixture]
    public class CuadradoTests
    {
        [Test]
        public void TestAreaYPerimetroCuadrado()
        {
            var cuadrado = new Cuadrado(7);
            Assert.AreEqual(49, cuadrado.CalcularArea());
            Assert.AreEqual(28, cuadrado.CalcularPerimetro());
        }
    }
}
