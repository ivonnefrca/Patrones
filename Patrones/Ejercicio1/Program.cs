using Ejercicio1;

var destinatario = new Destinatario()
{
    Email = "correo@test.com",
    Telefono = "123456789",
    SlackChannel = "#Grupo6"
};

var notificador = new NotificadorCompuesto();
notificador.Agregar(new NotificadorCorreo());
notificador.Agregar(new NotificadorSMS());
notificador.Agregar(new NotificadorSlack());

notificador.Enviar("Hola, este es el Ejercicio 1", destinatario);