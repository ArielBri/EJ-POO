using POO_1.Interfaces;

namespace POO_1.Attacks
{
    public class MagicAttack : IAttackBehavior
    {
        public void Attack()
        {
            Console.WriteLine(" Lanzando hechizo - ¡Bola de fuego!");
        }
    }
}
