using System;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
        public abstract string NombreSingular(IIdioma idioma);
        public abstract string NombrePlural(IIdioma idioma);
    }
}