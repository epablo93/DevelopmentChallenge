using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Formas
{
    [TestFixture]
    public class TrapecioTests
    {
        [Test]
        public void TestAreaYPerimetroTrapecio()
        {
            var trapecio = new Trapecio(10, 6, 4, 7, 7);
            Assert.AreEqual(32, trapecio.CalcularArea());
            Assert.AreEqual(30, trapecio.CalcularPerimetro());
        }
    }
}
