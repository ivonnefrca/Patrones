namespace Ejercicio2;

public class SeccionMovimientos : ISeccionReporte
{
    public string Nombre => "Movimientos";

    public void Render(DocumentoPDF doc, ContextoDatos ctx)
        => Console.WriteLine($"Renderizando {Nombre}");
}
