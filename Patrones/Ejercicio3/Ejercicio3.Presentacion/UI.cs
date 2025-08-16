using Ejercicio3.Aplicacion;
using Ejercicio3.Dominio;

namespace Ejercicio3.Presentacion;

public class UI(Invocador invocador)
{
    public void CrearEnviar(ICommand comando) 
        => invocador.Ejecutar(comando);
}
