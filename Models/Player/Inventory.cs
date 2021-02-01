using System.Collections.Generic;
namespace AdventuringGuild{
    public class Inventory
    {
        private Dictionary<ItemBase, float> inventoryDictionary;
        public Inventory()
        {
            inventoryDictionary = new Dictionary<ItemBase, float>();
            // read inventory logic for now

        }
    }
}