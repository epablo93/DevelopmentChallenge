namespace DevelopmentChallenge.Data.Classes
{
    public class Italiano : IIdioma
    {
        public string ReporteTitulo => "<h1>Rapporto sulle forme</h1>";
        public string ListaVacia => "<h1>Elenco vuoto di forme!</h1>";
        public string Total => "TOTALE:<br/>";
        public string Formas => "forme";
        public string Area => "Area";
        public string Perimetro => "Perimetro";
        public string CuadradoSingular => "Quadrato";
        public string CuadradoPlural => "Quadrati";
        public string CirculoSingular => "Cerchio";
        public string CirculoPlural => "Cerchi";
        public string TrianguloSingular => "Triangolo";
        public string TrianguloPlural => "Triangoli";
        public string TrapecioSingular => "Trapezio";
        public string TrapecioPlural => "Trapezi";
    }
}