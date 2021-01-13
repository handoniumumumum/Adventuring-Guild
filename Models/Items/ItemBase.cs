using Godot;
using System;
using System.Collections.Generic;
public namespace AdventuringGuild
{
/// <summary>
/// Base for items in the engine
/// </summary>
public class ItemBase : Node
{
    private string name;
    private ItemProductionType itemType;

    private Dictionary<Recipe> itemRecipes;

    public ItemBase()
    {
        itemType = 2;
        name = "Default";
        itemRecipes = null;
    }
}
}
    