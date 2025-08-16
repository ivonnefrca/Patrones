using Ejercicio4.Visitors;

namespace Ejercicio4.Core
{
    public class Archivo : IBaseElemento
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Carpeta? Padre { get; private set; }
        public string Nombre { get; set; } = string.Empty;
        public long Bytes { get; set; }

        public void Aceptar(IVisitante visitante)
        {
            Console.WriteLine($"[Archivo] Aceptando visitante en '{Nombre}'");
            visitante.VisitarArchivo(this);
        }

        public void EstablecerPadre(Carpeta? carpeta) 
        {
            Padre = carpeta; 
        }
    }
}
