namespace Ejercicio3.Dominio.Commands;

public class CrearTareaCommand(GestorTareas gestor, Tarea tarea) : ICommand
{
    public void Ejecutar() => gestor.AgregarTarea(tarea);
}
