using Ejercicio4.Visitors;

namespace Ejercicio4.Core
{
    public interface IBaseElemento
    {
        Guid Id { get; }
        Carpeta? Padre { get; }

        void Aceptar(IVisitante visitante);
        void EstablecerPadre(Carpeta? carpeta);
    }
}
