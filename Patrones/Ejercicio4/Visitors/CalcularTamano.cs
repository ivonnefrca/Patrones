using Ejercicio4.Core;

namespace Ejercicio4.Visitors
{
    public class CalcularTamano : IVisitante
    {
        public float Total { get; private set; }

        public void VisitarArchivo(Archivo archivo)
        {
            Total += archivo.Bytes;
            Console.WriteLine($"[CalcularTamano] Archivo '{archivo.Nombre}' suma {archivo.Bytes} bytes");
        }

        public void VisitarCarpeta(Carpeta carpeta)
        {
            Console.WriteLine($"[CalcularTamano] Carpeta '{carpeta.Nombre}'");
            foreach (var hijo in carpeta.Listar())
            { 
                hijo.Aceptar(this); 
            }
        }
    }
}