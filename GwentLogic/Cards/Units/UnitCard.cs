using GwentLogic.Cards.Skill;

namespace GwentLogic.Cards.Units;

public abstract class UnitCard : DeckCard
{
    public UnitCard(string name, string description, string faction,AttackType[] types, int power,UnitSkill skill) :
        base(name, description, faction,skill.ToString())
    {
        this.Power = power;
        this.AttackTypes = types;
    }

    public virtual int Power { get; }
    public virtual AttackType[] AttackTypes { get; }
}

public enum AttackType
{
    Melee,
    Ranged,
    Siege
}