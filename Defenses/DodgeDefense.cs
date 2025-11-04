using POO_1.Interfaces;

namespace POO_1.Defenses
{
    public class DodgeDefense : IDefenseBehavior
    {
        public void Defend()
        {
            Console.WriteLine(" Esquivando ágilmente");
        }
    }
}
