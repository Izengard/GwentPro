using GwentLogic.Cards.Skill;
namespace GwentLogic.Cards;

public class Leader : Card
{
    public Leader(string name, string description, string faction, Skills skill) :
        base(name, description, faction,skill.ToString()){}

}

