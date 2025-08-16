using Ejercicio4.Core;

namespace Ejercicio4.Visitors
{
    public interface IVisitante
    {
        void VisitarArchivo(Archivo archivo);
        void VisitarCarpeta(Carpeta carpeta);
    }
}
