namespace GwentLogic;

public abstract class UnitCard : DeckCard
{
    public UnitCard(string name, string description, string faction, Skill skill, int power, AttackType type) :
        base(name, description, faction, skill)
    {
        this.Power = power;

    }

    public int Power {get; set;}
    public AttackType Type {get;}
}
public enum AttackType
{
    Melee,
    Ranged,
    Siege
}