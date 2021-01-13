using Godot;
using System;
using System.Collections.Generic;
public namespace AdventuringGuild
{   
    /// <summary>
    /// A place where resources are gathered
    /// </summary>
    public class GatherPoint
    {
        public string name;
        public GatherSource source;
        /// <summary>
        /// Items received when gathering
        /// </summary>
        public List<itemBase> loot;
    }
}