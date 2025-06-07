using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        private readonly decimal _lado;
        public TrianguloEquilatero(decimal lado) { _lado = lado; }
        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }
        public override decimal CalcularPerimetro()
        {
            return _lado * 3;
        }
        public override string NombreSingular(IIdioma idioma)
        {
            return idioma.TrianguloSingular;
        }
        public override string NombrePlural(IIdioma idioma)
        {
            return idioma.TrianguloPlural;
        }
    }
}