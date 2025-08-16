namespace Ejercicio3.Dominio.Commands;

public class EliminarTareaCommand(GestorTareas gestor, Tarea tarea) : ICommand
{
    public void Ejecutar() => gestor.EliminarTarea(tarea);
}
