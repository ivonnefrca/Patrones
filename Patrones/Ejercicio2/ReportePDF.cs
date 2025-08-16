namespace Ejercicio2;

public class ReportePDF
{
    public Guid Id{ get; set; }
    public string Cliente { get; set; }
    public Periodo Periodo { get; set; }
    public DateTime GeneradoEn { get; set; }
    private readonly List<ISeccionReporte> _secciones;
    public IReadOnlyList<ISeccionReporte> Secciones => _secciones.AsReadOnly();

    internal ReportePDF(string cliente, Periodo periodo, List<ISeccionReporte> secciones)
    {
        Id = Guid.NewGuid();
        Cliente = cliente;
        Periodo = periodo;
        GeneradoEn = DateTime.Now;
        _secciones = secciones ?? new List<ISeccionReporte>();
    }

    public void Render(DocumentoPDF doc, ContextoDatos ctx)
    {
        Console.WriteLine($"Generando reporte para {Cliente} del periodo {Periodo.Desde.ToShortDateString()} al {Periodo.Hasta.ToShortDateString()}");
        Console.WriteLine($"ID Reporte: {Id} | Generado en : {GeneradoEn}");
        _secciones.ForEach(s => 
        {
            Console.WriteLine($"--- Seccion: {s.Nombre} ---");
            s.Render(doc, ctx);
        });
        Console.WriteLine("Reporte generado exitosamente.");
    }
}
