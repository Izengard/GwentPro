using GwentLogic.Cards.Skill;

namespace GwentLogic.Cards.Units;

public class Unit : UnitCard
{
    private int powerModifier = 0;
    public Unit(string name, string description, string faction, AttackType[] types, int power, UnitSkill skill) :
        base(name, description, faction, types, power, skill) {}
    public int Power { get => Power * powerModifier; }
    public void SetPowerModifier(int modifier)
    {
        powerModifier = modifier;
    }



}