namespace Ejercicio2;

public class SeccionGraficos : ISeccionReporte
{
    public TipoGrafico Tipo { get; set; }
    public string Nombre => "Grafico";

    public void Render(DocumentoPDF doc, ContextoDatos ctx) 
        => Console.WriteLine($"Renderizando {Nombre} de tipo {Tipo}");
}
