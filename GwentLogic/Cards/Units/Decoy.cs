using GwentLogic.Cards;
using GwentLogic.Cards.Skill;

namespace GwentLogic.Cards.Units;

public abstract class Decoy : UnitCard

{
    AttackType[] attackType = { AttackType.Melee, AttackType.Ranged, AttackType.Siege };
    public Decoy(string name, string description, string faction) :
        base(name, description, faction, null, 0, UnitSkill.Decoy)
    { }

    public override AttackType[] AttackTypes => attackType;
    public int Power => 0;
}
