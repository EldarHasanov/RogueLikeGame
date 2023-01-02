namespace ItemsLibraryForGame.Interfaces
{
    internal interface ILootable
    {
        public void remove();
        public void take(Inventory inventory);
        public void drop();
    }
}
