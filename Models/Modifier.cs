/// <summary>
///  Described a way that an adventurer's abilities are modified
/// </summary>
public class Modifier
{
    private StatModifierType statType;
    private int bonus;
    private int chance;
    /// <summary>
    /// Number of times the modifier can stack
    /// </summary>
    private int stackLimit;
}