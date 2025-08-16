using Ejercicio3.Dominio;

namespace Ejercicio3.Aplicacion;

public class Invocador
{
	private readonly Historial _historial = new();

	public void Ejecutar(ICommand comando)
	{
		comando.Ejecutar();
		_historial.Agregar(comando);
	}

	public Historial ObtenerHistorial() => _historial;
}
