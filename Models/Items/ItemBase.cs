using Godot;
using System;
using System.Collections.Generic;
public namespace AdventuringGuild
{

public class ItemBase : Node
{
    private string name;
    private ItemType itemType;

    private Dictionary<Recipe> itemRecipes;

    public ItemBase()
    {
        itemType = 2;
        name = "Default";
        itemRecipes = null;
    }
}
}
    