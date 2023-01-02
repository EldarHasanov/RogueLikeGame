namespace ItemsLibraryForGame.Interfaces
{
    internal interface IHitable
    {
        public void hit(Damage damage);

        public void heal(Damage heal);

        public void lifeDrain(Damage drain);
    }
}
