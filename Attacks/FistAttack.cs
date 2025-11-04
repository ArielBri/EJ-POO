using POO_1.Interfaces;

namespace POO_1.Attacks
{
    public class FistAttack : IAttackBehavior
    {
        public void Attack()
        {
            Console.WriteLine(" Golpe con puño - ¡Impacto directo!");
        }
    }
}
