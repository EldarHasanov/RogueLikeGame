namespace ItemsLibraryForGame
{
    enum DamageType
    {
        acid, 
        bludgeoning, 
        cold, 
        fire, 
        force, 
        lightning, 
        necrotic, 
        piercing, 
        poison, 
        psychic, 
        radiant, 
        slashing, 
        thunder, 
        magic
    }

    internal class Damage
    {
        public int damage;
        public DamageType damageType;

        public Damage(int damage, DamageType damageType)
        {
            this.damage = damage;
            this.damageType = damageType;
        }
    }
}
