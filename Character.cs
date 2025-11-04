using POO_1.Interfaces;

namespace POO_1
{
    public class Character
    {
        #region PRIVATE
        private string name;
        private IAttackBehavior attackBehavior;
        private IMovementBehavior movementBehavior;
        private IDefenseBehavior defenseBehavior;
        private int health;
        private int level;
        #endregion

        #region CTOR
        public Character(
            string name,
            IAttackBehavior attackBehavior,
            IMovementBehavior movementBehavior,
            IDefenseBehavior defenseBehavior = null,
            int health = 100,
            int level = 1)
        {
            this.name = name;
            this.attackBehavior = attackBehavior;
            this.movementBehavior = movementBehavior;
            this.defenseBehavior = defenseBehavior;
            this.health = health;
            this.level = level;
        }
        #endregion

        #region COMPORTAMIENTOS
        public void PerformAttack()
        {
            Console.Write($"{name}: ");
            attackBehavior.Attack();
        }

        public void PerformMove()
        {
            Console.Write($"{name}: ");
            movementBehavior.Move();
        }

        public void PerformDefense()
        {
            if (defenseBehavior != null)
            {
                Console.Write($"{name}: ");
                defenseBehavior.Defend();
            }
            else
            {
                Console.WriteLine($"{name}: No tiene defensa especial");
            }
        }
        #endregion

        #region CAMBIOS DE COMPORTAMIENTO
        public void SetAttackBehavior(IAttackBehavior newAttack)
        {
            this.attackBehavior = newAttack;
            Console.WriteLine($" {name} ha aprendido un nuevo ataque!");
        }

        public void SetMovementBehavior(IMovementBehavior newMovement)
        {
            this.movementBehavior = newMovement;
            Console.WriteLine($" {name} ha aprendido una nueva forma de moverse!");
        }

        public void SetDefenseBehavior(IDefenseBehavior newDefense)
        {
            this.defenseBehavior = newDefense;
            Console.WriteLine($" {name} ha aprendido una nueva defensa!");
        }


        
        public void DisplayInfo()
        {
            Console.WriteLine($"==================================");
            Console.WriteLine($" {name} (Nivel {level})");
            Console.WriteLine($"  Salud: {health}");
            Console.WriteLine($"==================================");
        }

        
        public void PerformCombatSequence()
        {
            PerformMove();
            PerformAttack();
            PerformDefense();
        }
        #endregion
    }
}
