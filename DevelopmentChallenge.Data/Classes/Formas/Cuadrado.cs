namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        private readonly decimal _lado;
        public Cuadrado(decimal lado) { _lado = lado; }
        public override decimal CalcularArea()
        {
            return _lado * _lado;
        }
        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }
        public override string NombreSingular(IIdioma idioma)
        {
            return idioma.CuadradoSingular;
        }
        public override string NombrePlural(IIdioma idioma)
        {
            return idioma.CuadradoPlural;
        }
    }
}