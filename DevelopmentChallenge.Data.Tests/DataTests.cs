using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Tests.Factories;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                ReporteFormas.Imprimir(DummyFormaFactory.GetListaVacia(), new Castellano()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                ReporteFormas.Imprimir(DummyFormaFactory.GetListaVacia(), new Ingles()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                ReporteFormas.Imprimir(DummyFormaFactory.GetListaVacia(), new Italiano()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = DummyFormaFactory.GetUnCuadrado();
            var resumen = ReporteFormas.Imprimir(cuadrados, new Castellano());
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioEnItaliano()
        {
            var trapecios = DummyFormaFactory.GetUnTrapecio();
            var resumen = ReporteFormas.Imprimir(trapecios, new Italiano());
            Assert.AreEqual("<h1>Rapporto sulle forme</h1>1 Trapezio | Area 15 | Perimetro 20 <br/>TOTALE:<br/>1 forme Perimetro 20 Area 15", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = DummyFormaFactory.GetMasCuadrados();
            var resumen = ReporteFormas.Imprimir(cuadrados, new Ingles());
            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = DummyFormaFactory.GetMasTipos();
            var resumen = ReporteFormas.Imprimir(formas, new Ingles());
            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = DummyFormaFactory.GetMasTipos();
            var resumen = ReporteFormas.Imprimir(formas, new Castellano());
            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConTrapeciosYCuadradosEnCastellano()
        {
            var formas = DummyFormaFactory.GetTrapeciosYCuadrados();
            var resumen = ReporteFormas.Imprimir(formas, new Castellano());
            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Trapecios | Area 62 | Perimetro 54 <br/>1 Cuadrado | Area 9 | Perimetro 12 <br/>TOTAL:<br/>3 formas Perimetro 66 Area 71",
                resumen);
        }
    }
}
