namespace Ejercicio2;

public class SeccionPortada : ISeccionReporte
{
    public string LogoPath { get; set; }
    public string Cliente { get; set; }

    public string Nombre => "Portada";

    public void Render(DocumentoPDF doc, ContextoDatos ctx) 
        => Console.WriteLine($"Renderizando {Nombre} para {Cliente} con logo {LogoPath}");
}
