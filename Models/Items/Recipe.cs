/// <summary>
/// The crafting recipe for an item
/// </summary>
public class Recipe
{
    public bool isUnlocked;
    /// <summary>
    /// Components of the recipe
    /// </summary>
    public List<ItemBase> components;
    /// <summary>
    /// Output of the recipe in whole item ratios
    /// </summary>
    public List<ItemBase> output;
    /// <summary>
    /// Base time to craft
    /// </summary>
    private int rate;

    private CraftingStationEnum craftingStation;

    public Recipe(List<ItemBase> _components, List<ItemBase> _output, int _rate, CraftingStationEnum _craftingStation)
    {
        components = _components;
        output = _output;
        rate = _rate;
        craftingStation = _craftingStation;
    }
}