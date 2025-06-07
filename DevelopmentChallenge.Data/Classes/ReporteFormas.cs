using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace DevelopmentChallenge.Data.Classes
{
    public static class ReporteFormas
    {
        public static string Imprimir(List<FormaGeometrica> formas, IIdioma idioma)
        {
            var sb = new StringBuilder();
            if (formas == null || !formas.Any())
                return idioma.ListaVacia;

            sb.Append(idioma.ReporteTitulo);
            var culture = new CultureInfo("es-ES");

            var resumen = formas
                .GroupBy(f => f.GetType())
                .Select(g => new
                {
                    Cantidad = g.Count(),
                    Area = g.Sum(f => f.CalcularArea()),
                    Perimetro = g.Sum(f => f.CalcularPerimetro()),
                    Forma = g.First()
                })
                .ToList();

            foreach (var r in resumen)
            {
                var nombre = r.Cantidad == 1 ? r.Forma.NombreSingular(idioma) : r.Forma.NombrePlural(idioma);
                sb.AppendFormat("{0} {1} | {2} {3} | {4} {5} <br/>",
                    r.Cantidad, nombre, idioma.Area, r.Area.ToString("#.##", culture), idioma.Perimetro, r.Perimetro.ToString("#.##", culture));
            }

            sb.Append(idioma.Total);
            sb.AppendFormat("{0} {1} {2} {3} {4} {5}",
                formas.Count, idioma.Formas,
                idioma.Perimetro, formas.Sum(f => f.CalcularPerimetro()).ToString("#.##", culture),
                idioma.Area, formas.Sum(f => f.CalcularArea()).ToString("#.##", culture));
            return sb.ToString();
        }
    }
}