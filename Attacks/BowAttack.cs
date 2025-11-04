using POO_1.Interfaces;

namespace POO_1.Attacks
{
    public class BowAttack : IAttackBehavior
    {
        public void Attack()
        {
            Console.WriteLine(" Disparando flecha - ¡Tiro preciso!");
        }
    }
}
