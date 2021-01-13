using Godot;
using System;
using System.Collections.Generic;
public namespace AdventuringGuild
{
public class Equipment : ItemBase
{
    private List<Modifier> bonuses;
    private EquipmentSlot slot;
    public Equipment()
    {
        base();
        itemRecipes = null;
    }

}
}