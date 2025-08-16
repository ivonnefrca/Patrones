namespace Ejercicio2;

public class SeccionTendencias : ISeccionReporte
{
    public string Nombre => "Tendencias";
    public void Render(DocumentoPDF doc, ContextoDatos ctx)
        => Console.WriteLine($"Renderizando {Nombre}");
}
