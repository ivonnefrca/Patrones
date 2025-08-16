using Ejercicio4.Core;

namespace Ejercicio4.Visitors
{
    public class MoverElemento : IVisitante
    {
        private readonly Carpeta _destino;

        public MoverElemento(Carpeta destino)
        {
            _destino = destino;
        }

        public void VisitarArchivo(Archivo archivo)
        {
            archivo.Padre?.Remover(archivo);
            _destino.Agregar(archivo);
            Console.WriteLine($"[MoverElemento] Archivo '{archivo.Nombre}' movido a carpeta '{_destino.Nombre}'");
        }

        public void VisitarCarpeta(Carpeta carpeta)
        {
            carpeta.Padre?.Remover(carpeta);
            _destino.Agregar(carpeta);
            Console.WriteLine($"[MoverElemento] Carpeta '{carpeta.Nombre}' movida a '{_destino.Nombre}'");
        }
    }
}