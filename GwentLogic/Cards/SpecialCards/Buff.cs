using GwentLogic.Cards.Skill;

namespace GwentLogic.Cards.SpecialCards;

public abstract class Buff : SpecialCard
{
    public Buff (string name, string description, string faction) :
    base(name, description, faction, Skills.Buff.ToString()){}
}
