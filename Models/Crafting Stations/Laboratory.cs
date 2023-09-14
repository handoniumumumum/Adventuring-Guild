using System.Collections.Generic;
using System
namespace AdventuringGuild
{
    /// <summary>
    /// for creating chemical materials
    /// </summary>
    public class Laboratory : CraftingStation
    {
        public Laboratory(List<Recipe> recipes)
        {
            base(recipes);
        }
        private List<Recipe> GetAvailableRecipes(List<Recipe> recipes)
        {
            
            
        }

        public Laboratory()
        {
            base();
        }

        private Laboratory()
        {
            
        }
    }
}