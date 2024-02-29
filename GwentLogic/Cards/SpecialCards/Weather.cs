using GwentLogic.Cards;
using GwentLogic.Cards.Skill;
using GwentLogic.Cards.Units;

namespace GwentLogic.Cards.SpecialCards;


public abstract class Weather : SpecialCard
{
    public Weather(string name, string description, string faction, AttackType type) :
    base(name, description, faction, Skills.Weather.ToString())
    {
         this.AttackType = type;
    }

    public AttackType AttackType {get;}

}
