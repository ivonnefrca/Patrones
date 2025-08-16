namespace Ejercicio2;

public class SeccionPieAsesor : ISeccionReporte
{
    public string Contacto { get; set; }
    public string Nombre => "Pie del Asesor";
    public void Render(DocumentoPDF doc, ContextoDatos ctx)
        => Console.WriteLine($"Renderizando {Nombre} Contacto : {Contacto}");
}
