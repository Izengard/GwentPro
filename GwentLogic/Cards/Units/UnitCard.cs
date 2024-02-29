namespace GwentLogic.Cards;

public abstract class UnitCard : DeckCard
{
    public UnitCard(string name, string description, string faction,AttackType[] types, int power) :
        base(name, description, faction)
    {
        this.Power = power;
        this.AttackTypes = types;
    }
    public virtual int Power { get; }
    public AttackType[] AttackTypes { get; }
}

public enum AttackType
{
    Melee,
    Ranged,
    Siege
}