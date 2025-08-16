using Ejercicio4.Visitors;

namespace Ejercicio4.Core
{
    public class Carpeta : IBaseElemento
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Nombre { get; set; } = string.Empty;
        public Carpeta? Padre { get; private set; }

        private readonly List<IBaseElemento> _elementos = new();

        public void Agregar(IBaseElemento elemento)
        {
            _elementos.Add(elemento);
            elemento.EstablecerPadre(this);
            Console.WriteLine($"[Carpeta] Agregado '{(elemento is Archivo a ? a.Nombre : (elemento as Carpeta)?.Nombre)}' en '{Nombre}'");
        }

        public void Remover(IBaseElemento elemento)
        {
            _elementos.Remove(elemento);
            Console.WriteLine($"[Carpeta] Removido elemento de '{Nombre}'");
        }

        public IReadOnlyList<IBaseElemento> Listar()
        {
            return _elementos.AsReadOnly();
        }

        public void Aceptar(IVisitante visitante)
        {
            Console.WriteLine($"[Carpeta] Aceptando visitante en '{Nombre}'");
            visitante.VisitarCarpeta(this);
        }

        public void EstablecerPadre(Carpeta? carpeta)
        {
            Padre = carpeta;
        }
    }
}
