using GwentLogic.Cards.Skill;
namespace GwentLogic.Cards;

public abstract class Card
{
    public string Name { get; }
    public string Faction { get; }
    public string Description { get; }
    public string Skill { get; set; }

    public Card(string name, string description, string faction, string skill)
    {
        this.Name = name;
        this.Description = description;
        this.Faction = faction;
        this.Skill = skill;
    }

}
