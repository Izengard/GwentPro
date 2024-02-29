using GwentLogic.Cards.Skill;
namespace GwentLogic.Cards;

public abstract class Card
{
    public string Name { get; }
    public string Faction { get; }
    public string Description { get; }
    public abstract Skills Skill { get; }

    public Card(string name, string description, string faction)
    {
        this.Name = name;
        this.Description = description;
        this.Faction = faction;
    }

}
