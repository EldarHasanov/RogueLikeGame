using ItemsLibraryForGame.Interfaces;

namespace ItemsLibraryForGame
{
    internal class Item : ILootable
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public int Cost { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }



        public Item(int id, int weight, int cost, string name, string description)
        {
            Id = id;
            Weight = weight;
            Cost = cost;
            Name = name;
            Description = description;
        }

        public Item(int id)
        {
            if (SearchById(id))
            {
                return;
            }
            else
            {
                return;
            }
            //todo
        }

        private bool SearchById(int id)
        {
            Id = id;
            return true;
        }

        public void remove()
        {
            throw new NotImplementedException();
        }

        public void take(Inventory inventory)
        {
            inventory.takeItem(this);
        }

        public void drop()
        {
            throw new NotImplementedException();
        }
    }
}
