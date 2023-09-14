using System.Collections.Generic;
namespace AdventuringGuild{
    /// <summary>
    /// represents the player's status and belongings in the game
    /// </summary>
    public class Player
    {
        private Inventory _inventory;
        public Player()
        {
            _inventory = new Dictionary<ItemBase, float>();
        }
    }
}