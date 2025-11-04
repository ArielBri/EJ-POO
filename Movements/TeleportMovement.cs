using POO_1.Interfaces;

namespace POO_1.Movements
{
    public class TeleportMovement : IMovementBehavior
    {
        public void Move()
        {
            Console.WriteLine(" Teletransportándose - ¡Desaparece y reaparece!");
        }
    }
}
