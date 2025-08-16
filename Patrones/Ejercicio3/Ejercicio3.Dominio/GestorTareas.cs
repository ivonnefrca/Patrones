using Ejercicio3.Persistencia;

namespace Ejercicio3.Dominio;

public class GestorTareas
{
    private readonly Repositorio<Tarea> _repositorio;
    public GestorTareas(Repositorio<Tarea> repositorio) 
        => _repositorio = repositorio;

    public void AgregarTarea(Tarea tarea)
        => _repositorio.Agregar(tarea, tarea.Id);

    public void EliminarTarea(Tarea tarea)
        => _repositorio.Eliminar(tarea, tarea.Id);

    public Tarea ActualizarTarea(Tarea tarea, Tarea tareaActualizada)
    {
        var tareaExistente = _repositorio.Bucar(tarea) 
            ?? throw new Exception("Tarea no encontrada");

        tareaExistente.Titulo = tareaActualizada.Titulo;
        tareaExistente.Descripcion = tareaActualizada.Descripcion;
        tareaExistente.Completada = tareaActualizada.Completada;
        return _repositorio.Actualizar(tareaExistente, tareaActualizada, tarea.Id);
    }
        
}
