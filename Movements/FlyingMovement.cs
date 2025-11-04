using POO_1.Interfaces;

namespace POO_1.Movements
{
    public class FlyingMovement : IMovementBehavior
    {
        public void Move()
        {
            Console.WriteLine(" Volando por los aires - ¡Libertad total!");
        }
    }
}
