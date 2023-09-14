using System.Collections.Generic;
using System
namespace AdventuringGuild
{
    /// <summary>
    /// for creating industrial engineering materials
    /// </summary>
    public class Workshop : CraftingStation
    {
        public Workshop(List<Recipe> recipes)
        {
            base(recipes);
        }
        private List<Recipe> GetAvailableRecipes(List<Recipe> recipes)
        {
            
            
        }

        public Workshop()
        {
            base();
        }

        private Workshop()
        {
            
        }
    }
}