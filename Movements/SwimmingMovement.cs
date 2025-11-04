using POO_1.Interfaces;

namespace POO_1.Movements
{
    public class SwimmingMovement : IMovementBehavior
    {
        public void Move()
        {
            Console.WriteLine(" Nadando bajo el agua...");
        }
    }
}
