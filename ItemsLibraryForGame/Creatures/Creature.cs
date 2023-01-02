using ItemsLibraryForGame.Interfaces;

namespace ItemsLibraryForGame.Creatures
{
    internal class Creature : IHitable, IMovable
    {
        public int maxHitPoints { get; set; }
        public int currentHitPoints { get; set; }

        private double maxMovePoint { get; set; }
        private double currentMovePoint { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }


        public void move(Direction direction)
        {
            switch (direction)
            {
                case Direction.north:
                    if (currentMovePoint >= 1)
                    {
                        currentMovePoint--;
                        //todo move
                    }
                    break;
                case Direction.south:
                    if (currentMovePoint >= 1)
                    {
                        currentMovePoint--;
                        //todo move
                    }
                    break;
                case Direction.west:
                    if (currentMovePoint >= 1)
                    {
                        currentMovePoint--;
                        //todo move
                    }
                    break;
                case Direction.east:
                    if (currentMovePoint >= 1)
                    {
                        currentMovePoint--;
                        //todo move
                    }
                    break;
                case Direction.north_west:
                    if (currentMovePoint >= 1.5)
                    {
                        currentMovePoint -= 1.5;
                        //todo move
                    }
                    break;
                case Direction.north_east:
                    if (currentMovePoint >= 1.5)
                    {
                        currentMovePoint -= 1.5;
                        //todo move
                    }
                    break;
                case Direction.south_west:
                    if (currentMovePoint >= 1.5)
                    {
                        currentMovePoint -= 1.5;
                        //todo move
                    }
                    break;
                case Direction.south_east:
                    if (currentMovePoint >= 1.5)
                    {
                        currentMovePoint -= 1.5;
                        //todo move
                    }
                    break;
            }
        }

        public void hit(Damage damage)
        {
            currentHitPoints -= damage.damage;

            if (currentHitPoints <= 0)
            {
                if (currentHitPoints <= -maxHitPoints)
                {
                    //todo death
                }
                currentHitPoints = 0;
            }
        }

        public void heal(Damage heal)
        {
            currentHitPoints += heal.damage;
            if (currentHitPoints > maxHitPoints)
            {
                currentHitPoints = maxHitPoints;
            }
        }

        public void lifeDrain(Damage drain)
        {
            maxHitPoints -= drain.damage;
            if (maxHitPoints <= 0)
            {
                //todo death
            }
        }

    }

    internal class Aberration : Creature
    {

    }

    internal class Beast : Creature
    {

    }

    internal class Celestial : Creature
    {
    }

    internal class Dragon : Creature
    {

    }

    internal class Elemental : Creature
    {

    }

    internal class Fey : Creature
    {

    }

    internal class Fiend : Creature
    {

    }

    internal class Giant : Creature
    {

    }

    internal class Humanoid : Creature
    {

    }

    internal class Monstrosity : Creature
    {

    }

    internal class Ooze : Creature
    {

    }

    internal class Plant : Creature
    {

    }

    internal class Undead : Creature
    {

    }
}
