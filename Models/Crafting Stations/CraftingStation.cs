using System.Collections.Generic;

namespace AdventuringGuild
{
    public abstract class CraftingStation
    {
        public CraftingStation(List<Recipe> recipes)
        {
            GetAvailableRecipes(recipes);
        }
        private List<Recipe> GetAvailableRecipes(List<Recipe> recipes)
        {
            
            // child classes will filter the results
        }

        public Step()
        {
            RefreshIngredients();
        }

        private RefreshIngredients()
        {
            
        }
    }
}