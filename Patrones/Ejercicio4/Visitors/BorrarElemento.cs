using Ejercicio4.Core;

namespace Ejercicio4.Visitors
{
    public class BorrarElemento : IVisitante
    {
        public void VisitarArchivo(Archivo archivo)
        {
            archivo.Padre?.Remover(archivo);
            Console.WriteLine($"[BorrarElemento] Archivo '{archivo.Nombre}' borrado");
        }

        public void VisitarCarpeta(Carpeta carpeta)
        {
            carpeta.Padre?.Remover(carpeta);
            Console.WriteLine($"[BorrarElemento] Carpeta '{carpeta.Nombre}' borrada");
        }
    }
}
