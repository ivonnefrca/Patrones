namespace Ejercicio1;

public class NotificadorCompuesto : INotificador
{
    private readonly List<INotificador> canales = new();

    public void Agregar(INotificador canal)
        => canales.Add(canal);

    public void Quitar(INotificador canal)
        => canales.Remove(canal);

    public void Enviar(string mensaje, Destinatario destinatario)
        => canales.ForEach(canal => canal.Enviar(mensaje, destinatario));
}

public class NotificadorCorreo : INotificador
{
    public void Enviar(string mensaje, Destinatario destinatario)
        => Console.WriteLine($"Enviando correo a {destinatario.Email}: {mensaje}");    
}

public class NotificadorSMS : INotificador
{
    public void Enviar(string mensaje, Destinatario destinatario)
        => Console.WriteLine($"Enviando SMS a {destinatario.Telefono}: {mensaje}");
}

public class NotificadorWhatsApp : INotificador
{
    public void Enviar(string mensaje, Destinatario destinatario)
        => Console.WriteLine($"Enviando Whatsapp a {destinatario.Telefono}: {mensaje}");
}

public class NotificadorSlack : INotificador
{
    public void Enviar(string mensaje, Destinatario destinatario)
        => Console.WriteLine($"Enviando mensaje a canal de Slack {destinatario.SlackChannel}: {mensaje}");
}

public class NotificadorOtra : INotificador
{
    public void Enviar(string mensaje, Destinatario destinatario)
        => Console.WriteLine($"Enviando otro tipo de notificación: {mensaje}");
}
