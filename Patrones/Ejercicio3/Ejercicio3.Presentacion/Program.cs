using Ejercicio3.Aplicacion;
using Ejercicio3.Dominio;
using Ejercicio3.Dominio.Commands;
using Ejercicio3.Persistencia;
using Ejercicio3.Presentacion;

var repositorio = new Repositorio<Tarea>();
var gestorTareas = new GestorTareas(repositorio);
var invocador = new Invocador();
var ui = new UI(invocador);

var tarea1 = new Tarea { Id = 1, Titulo = "Tarea 1", Descripcion = "Descripción de la tarea 1", Completada = false };
ui.CrearEnviar(new CrearTareaCommand(gestorTareas, tarea1));

ui.CrearEnviar(new CompletarTareaCommand(gestorTareas, tarea1));
