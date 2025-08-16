using Ejercicio3.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Aplicacion;

public class Historial
{
    private readonly Stack<ICommand> _historial = new();
    public void Agregar(ICommand comando) => _historial.Push(comando);
    public ICommand Deshacer() => _historial.Pop(); 
}
