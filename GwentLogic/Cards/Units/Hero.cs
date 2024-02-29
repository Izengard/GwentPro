using GwentLogic.Cards.Skill;

namespace GwentLogic.Cards.Units;

public class Hero : UnitCard
{
    public Hero(string name, string description, string faction, int power, AttackType[] types, UnitSkill skill) :
        base(name, description, faction, types, power, skill)
    { }

}