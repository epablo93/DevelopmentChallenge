using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests.Formas
{
    [TestFixture]
    public class TrapecioTests
    {
        [TestCase]
        public void TestAreaYPerimetroTrapecio()
        {
            var trapecio = new Trapecio(10, 6, 4, 7, 7);
            Assert.AreEqual(32, trapecio.CalcularArea());
            Assert.AreEqual(30, trapecio.CalcularPerimetro());
        }
    }

    [TestFixture]
    public class CirculoTests
    {
        [TestCase]
        public void TestAreaYPerimetroCirculo()
        {
            var circulo = new Circulo(10);
            Assert.AreEqual((decimal)System.Math.PI * 25, circulo.CalcularArea());
            Assert.AreEqual((decimal)System.Math.PI * 10, circulo.CalcularPerimetro());
        }
    }

    [TestFixture]
    public class TrianguloEquilateroTests
    {
        [TestCase]
        public void TestAreaYPerimetroTriangulo()
        {
            var triangulo = new TrianguloEquilatero(6);
            Assert.AreEqual(((decimal)System.Math.Sqrt(3) / 4) * 36, triangulo.CalcularArea());
            Assert.AreEqual(18, triangulo.CalcularPerimetro());
        }
    }

    [TestFixture]
    public class CuadradoTests
    {
        [TestCase]
        public void TestAreaYPerimetroCuadrado()
        {
            var cuadrado = new Cuadrado(7);
            Assert.AreEqual(49, cuadrado.CalcularArea());
            Assert.AreEqual(28, cuadrado.CalcularPerimetro());
        }
    }
}
