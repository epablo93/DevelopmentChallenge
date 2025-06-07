namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        private readonly decimal _baseMayor, _baseMenor, _altura, _lado1, _lado2;
        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal lado1, decimal lado2)
        {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
            _lado1 = lado1;
            _lado2 = lado2;
        }
        public override decimal CalcularArea()
        {
            return ((_baseMayor + _baseMenor) * _altura) / 2;
        }
        public override decimal CalcularPerimetro()
        {
            return _baseMayor + _baseMenor + _lado1 + _lado2;
        }
        public override string NombreSingular(IIdioma idioma)
        {
            return idioma.TrapecioSingular;
        }
        public override string NombrePlural(IIdioma idioma)
        {
            return idioma.TrapecioPlural;
        }
    }
}