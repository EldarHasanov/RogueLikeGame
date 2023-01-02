using ItemsLibraryForGame.Interfaces;

namespace ItemsLibraryForGame
{
    internal class Dagger:Item, IWeapon
    {
        private int damage = 4;
        private DamageType damageType = DamageType.piercing;

        public Dagger(int id, int weight, int cost, string name, string description) : base(id, weight, cost, name, description)
        {
        }

        public Dagger(int id) : base(id)
        {
        }

        public Damage rollDamage()
        {
            DateTime dateTime = new DateTime();
            Random rand = new Random(dateTime.Millisecond);
            return new Damage(rand.Next(1, damage), damageType);
        }
    }
}
