namespace Ejercicio3.Dominio.Commands;

public class CompletarTareaCommand(GestorTareas gestor, Tarea tarea) : ICommand
{
    public void Ejecutar()
    {
        var tareaCompletada = tarea;
        tareaCompletada.Completada = true;
        gestor.ActualizarTarea(tarea, tareaCompletada);
        Console.WriteLine($"Tarea '{tareaCompletada.Titulo}' completada.");
    }
}
