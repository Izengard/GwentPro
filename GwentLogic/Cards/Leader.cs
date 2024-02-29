using GwentLogic.Cards.Skill;
namespace GwentLogic.Cards;

public class Leader : Card
{
    Skills skill;
    public Leader(string name, string description, string faction, Skills skill) :
        base(name, description, faction){
            skill = skill;
        }

    public override Skills Skill  => skill;
}

