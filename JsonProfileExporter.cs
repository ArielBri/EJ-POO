using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_1
{
    public class JsonProfileExporter : IProfileExporter
    {
        public void Export(UserProfile profile)
        {
            Console.WriteLine("=== Exportando a JSON ===");
            Console.WriteLine("{");
            Console.WriteLine($"  \"username\": \"{profile.GetUsername()}\",");
            Console.WriteLine($"  \"email\": \"{profile.GetEmail()}\"");
            Console.WriteLine("}");
        }
    }
}
