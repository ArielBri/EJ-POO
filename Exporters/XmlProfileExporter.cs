using POO_1.Interfaces;

namespace POO_1.Exporters
{
    public class XmlProfileExporter : IProfileExporter
    {
        public void Export(UserProfile profile)
        {
            Console.WriteLine("=== Exportando a XML ===");
            Console.WriteLine("<UserProfile>");
            Console.WriteLine($"  <Username>{profile.GetUsername()}</Username>");
            Console.WriteLine($"  <Email>{profile.GetEmail()}</Email>");
            Console.WriteLine("</UserProfile>");
        }
    }
}
