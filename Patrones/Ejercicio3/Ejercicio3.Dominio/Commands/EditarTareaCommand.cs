namespace Ejercicio3.Dominio.Commands;

public class EditarTareaCommand(GestorTareas gestor, Tarea tarea) : ICommand
{
    public void Ejecutar() => gestor.ActualizarTarea(tarea, tarea);
}

