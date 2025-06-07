# Refactorizaci�n DevelopmentChallenge

## Resumen

El c�digo fue refactorizado para que sea f�cil agregar nuevas formas geom�tricas y nuevos idiomas. Ahora cada forma y cada idioma es una clase separada. El reporte usa polimorfismo y es f�cil de extender.

## Cambios principales

- Cada forma geom�trica es una clase que hereda de `FormaGeometrica`.
- Cada idioma es una clase que implementa la interfaz `IIdioma`.
- El reporte se genera con la clase `ReporteFormas`.
- Los tests usan una factory (`DummyFormaFactory`) para crear datos de prueba.
- El formato decimal en los reportes es siempre con coma.
- Cada clase/interfaz est� en su propio archivo.

## Principios y patrones

- SOLID (especialmente SRP y OCP)
- Polimorfismo
- Factory para datos de prueba
- C�digo simple y sin duplicaci�n

## Extensi�n

- Para agregar una forma: crear una clase que herede de `FormaGeometrica`.
- Para agregar un idioma: crear una clase que implemente `IIdioma`.
- Para nuevos tests: usar la factory y agregar el test.

## Tests

- Ejecutar desde Visual Studio (Test Explorer) o consola con NUnit.
- Requiere `NUnit3TestAdapter` y `Microsoft.NET.Test.Sdk`.
