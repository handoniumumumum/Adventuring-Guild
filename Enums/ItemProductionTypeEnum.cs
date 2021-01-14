public namespace AdventuringGuild
{
    /// <summary>
    /// How the item is produced
    /// </summary>
    public enum ItemProductionType {
    //Comes from a seed. Resource
    Seed,
    // fruits from a plant. Resource
    Plant,
    // You have to craft it
    Crafted,
    // Found but not crafted or grown
    Nonrenewable
}
}