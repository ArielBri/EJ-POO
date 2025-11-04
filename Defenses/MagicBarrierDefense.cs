using POO_1.Interfaces;

namespace POO_1.Defenses
{
    public class MagicBarrierDefense : IDefenseBehavior
    {
        public void Defend()
        {
            Console.WriteLine(" Creando barrera mágica");
        }
    }
}
