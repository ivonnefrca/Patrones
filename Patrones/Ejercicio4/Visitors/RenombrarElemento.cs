using Ejercicio4.Core;

namespace Ejercicio4.Visitors
{
    public class RenombrarElemento : IVisitante
    {
        private readonly string _nuevoNombre;

        public RenombrarElemento(string nuevoNombre)
        {
            _nuevoNombre = nuevoNombre;
        }

        public void VisitarArchivo(Archivo archivo)
        {
            Console.WriteLine($"[RenombrarElemento] Renombrando archivo '{archivo.Nombre}' a '{_nuevoNombre}'");
            archivo.Nombre = _nuevoNombre;
        }

        public void VisitarCarpeta(Carpeta carpeta)
        {
            Console.WriteLine($"[RenombrarElemento] Renombrando carpeta '{carpeta.Nombre}' a '{_nuevoNombre}'");
            carpeta.Nombre = _nuevoNombre;
        }
    }
}