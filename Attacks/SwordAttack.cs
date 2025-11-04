using POO_1.Interfaces;

namespace POO_1.Attacks
{
    public class SwordAttack : IAttackBehavior
    {
        public void Attack()
        {
            Console.WriteLine("  Atacando con espada - ¡Corte devastador!");
        }
    }
}
