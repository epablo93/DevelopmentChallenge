using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Tests.Factories
{
    using DevelopmentChallenge.Data.Classes;

    public static class DummyFormaFactory
    {
        public static List<FormaGeometrica> GetListaVacia()
        {
            return new List<FormaGeometrica>();
        }

        public static List<FormaGeometrica> GetUnCuadrado()
        {
            return new List<FormaGeometrica> { new Cuadrado(5) };
        }

        public static List<FormaGeometrica> GetUnTrapecio()
        {
            return new List<FormaGeometrica> { new Trapecio(6, 4, 3, 5, 5) };
        }

        public static List<FormaGeometrica> GetMasCuadrados()
        {
            return new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };
        }

        public static List<FormaGeometrica> GetMasTipos()
        {
            return new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };
        }

        public static List<FormaGeometrica> GetTrapeciosYCuadrados()
        {
            return new List<FormaGeometrica>
            {
                new Trapecio(8, 4, 5, 6, 6),
                new Trapecio(10, 6, 4, 7, 7),
                new Cuadrado(3)
            };
        }
    }
}
