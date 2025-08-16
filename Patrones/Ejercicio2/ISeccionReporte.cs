namespace Ejercicio2;

public interface ISeccionReporte
{
    string Nombre { get; }
    void Render(DocumentoPDF doc , ContextoDatos ctx);
}
