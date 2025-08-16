namespace Ejercicio3.Persistencia;

public class Repositorio<T>
    where T : class
{
    private List<T> _items = [];

    public void Agregar(T item, int id)
    {
        _items.Add(item);
        Console.WriteLine($"Item {id} agregado");
    }

    public T Actualizar(T itemAnterior, T itemNuevo, int id)
    {
        var itemExistente = _items.Find(t => t == itemAnterior);
        if (itemExistente != null) return itemNuevo;

        Console.WriteLine($"Item {id} Actualizado");
        return itemAnterior;
    }

    public T Bucar(T item)
        => _items.Find(t => t == item);

    public void Eliminar(T item, int id)
    {
        _items.Remove(item);
        Console.WriteLine($"Item {id} Eliminado");
    }

}
