/*ENUNCIADO ORIGINAL
 * 
public class UserProfile
{
    public string Username;
    public string Email;
    public string Password; // ¡Muy inseguro!

    public void DisplayProfile()
    {
        Console.WriteLine($"Username: {Username}");
        Console.WriteLine($"Email: {Email}");
    }

    public void ExportToJSON()
    {
        // Lógica para exportar a JSON...
        Console.WriteLine($"{{\"username\": \"{Username}\"}}");
    }
}
*/

using POO_1;

/*EJERCICIO 1*/

// Crear un perfil de usuario
UserProfile user = new UserProfile(
    "juan_perez",
    "juan@example.com",
    "miPassword123"
);

// Mostrar perfil
user.DisplayProfile();
Console.WriteLine();

// Exportar usando JSON
IProfileExporter jsonExporter = new JsonProfileExporter();
jsonExporter.Export(user);
Console.WriteLine();

// Exportar usando XML
IProfileExporter xmlExporter = new XmlProfileExporter();
xmlExporter.Export(user);
Console.WriteLine();


/*EJERCICIO 2*/

//CREANDO SERVICIO NOTIFICACIONES
NotificationService service = new NotificationService();

//CREANDO LISTA DE NOTIFICACIONES
List<Notification> notifications = new List<Notification>();

//AGREGANDO NOTIFICACIONES
notifications.Add(new EmailNotification(
    "juan@gmail.com",
    "Tu pedido ha sido enviado",
    "Confirmación de Pedido"
));

notifications.Add(new SmsNotification(
    "Juan Perez",
    "Tu código de verificación es: 123456",
    "+54 11 1234-5678"
));

notifications.Add(new PushNotification(
    "Carlos López",
    "Tienes un nuevo mensaje",
    "device-android-abc123"
));

notifications.Add(new EmailNotification(
    "ana@gmail.com",
    "Recordatorio: Reunión mañana a las 10:00",
    "Recordatorio de Reunión"
));

notifications.Add(new SmsNotification(
    "Pedro Martínez",
    "Tu reserva ha sido confirmada",
    "+54 11 9876-5432"
));

//ENVIAR TODAS LAS NOTIFICACIONES -  POLIMORFISMO
service.SendBatch(notifications);

// Ejemplo adicional: enviar una notificación individual
Console.WriteLine("\n\n--- Ejemplo de notificación individual ---\n");
Notification urgentNotification = new PushNotification(
    "Admin",
    "¡ALERTA! Actividad sospechosa detectada",
    "device-ios-xyz789"
);

Console.WriteLine("\n--- Presiona cualquier tecla para salir ---");
Console.ReadKey();


/*EJERCICIO 3*/