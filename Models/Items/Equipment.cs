using Godot;
using System;
using System.Collections.Generic;
public namespace AdventuringGuild
{
    /// <summary>
    /// These items can be equipped by adventurers.
    /// </summary>
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