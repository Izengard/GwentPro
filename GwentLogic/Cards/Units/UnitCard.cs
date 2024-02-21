namespace GwentLogic.Cards;

public abstract class UnitCard : DeckCard
{
    public UnitCard(string name, string description, string faction, Skill skill, int power, AttackType type) :
        base(name, description, faction, skill)
    {
        this._power = power;

    }
    public int Power{get;}
    public AttackType Type {get;}
}
