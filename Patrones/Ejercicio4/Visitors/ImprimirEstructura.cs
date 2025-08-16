using Ejercicio4.Core;

namespace Ejercicio4.Visitors
{
    public class ImprimirEstructura : IVisitante
    {
        private int _nivel = 0;

        public void VisitarArchivo(Archivo archivo)
        {
            Console.WriteLine($"{new string(' ', _nivel * 2)}- {archivo.Nombre} ({archivo.Bytes} B)");
        }

        public void VisitarCarpeta(Carpeta carpeta)
        {
            Console.WriteLine($"{new string(' ', _nivel * 2)}+ {carpeta.Nombre}/");
            _nivel++;

            foreach (var hijo in carpeta.Listar())
            { 
                hijo.Aceptar(this); 
            }

            _nivel--;
        }
    }
}
