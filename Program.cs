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

