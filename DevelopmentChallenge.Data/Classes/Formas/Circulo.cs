using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        private readonly decimal _diametro;
        public Circulo(decimal diametro) { _diametro = diametro; }
        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_diametro / 2) * (_diametro / 2);
        }
        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _diametro;
        }
        public override string NombreSingular(IIdioma idioma)
        {
            return idioma.CirculoSingular;
        }
        public override string NombrePlural(IIdioma idioma)
        {
            return idioma.CirculoPlural;
        }
    }
}