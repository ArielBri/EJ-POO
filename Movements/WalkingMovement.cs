using POO_1.Interfaces;

namespace POO_1.Movements
{
    public class WalkingMovement : IMovementBehavior
    {
        public void Move()
        {
            Console.WriteLine(" Caminando por el terreno...");
        }
    }
}
