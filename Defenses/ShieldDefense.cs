using POO_1.Interfaces;

namespace POO_1.Defenses
{
    public class ShieldDefense : IDefenseBehavior
    {
        public void Defend()
        {
            Console.WriteLine("  Bloqueando con escudo");
        }
    }
}
