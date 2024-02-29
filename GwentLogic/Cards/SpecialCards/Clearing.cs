using GwentLogic.Cards;
using GwentLogic.Cards.Skill;

namespace GwentLogic.Cards.SpecialCards;

public abstract class Clearing : SpecialCard
{
    public Clearing(string name, string description, string faction) :
    base(name, description, faction, Skills.Clearing.ToString()){ }

}
