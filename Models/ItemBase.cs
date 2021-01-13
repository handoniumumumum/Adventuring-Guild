using Godot;
using System;
using System.Collections.Generic;
public namespace AdventuringGuild
{



public class ItemBase : Node
{
    private int type;

    private Dictionary<Recipe> itemRecipes;

    public ItemBase()
    {
        type = 4;
        itemRecipes = null;
    }
}
}
    