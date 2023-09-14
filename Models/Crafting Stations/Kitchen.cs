using System.Collections.Generic;
using System
namespace AdventuringGuild
{
    /// <summary>
    /// For creating meals
    /// </summary>
    public class Kitchen : CraftingStation
    {
        public Kitchen(List<Recipe> recipes)
        {
            base(recipes);
        }
        private List<Recipe> GetAvailableRecipes(List<Recipe> recipes)
        {
            
            
        }

        public Kitchen()
        {
            base()
        }

        private Kitchen()
        {
            base()
        }
    }
}