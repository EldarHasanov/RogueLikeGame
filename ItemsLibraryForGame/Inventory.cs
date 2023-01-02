namespace ItemsLibraryForGame
{
    internal class Inventory
    {
        public List<Item> inventoryItems { get; set; }
        public int inventoryWeight { get; set; }
        public int inventoryCount { get; set; }

        Inventory(List<Item> inventoryItems)
        {
            this.inventoryItems = inventoryItems;
            this.inventoryWeight = countInventoryWeight();
            this.inventoryCount = inventoryItems.Count();
        }

        Inventory()
        {
            inventoryItems = new List<Item>();
            this.inventoryCount = 0;
        }

        public int countInventoryWeight()
        {
            inventoryWeight = 0;

            foreach (var item in inventoryItems)
            {
                inventoryWeight += item.Weight;
            }

            return inventoryWeight;
        }

        public void takeItem(Item item)
        {
            inventoryItems.Add(item);
        }
    }
}
