namespace GwentLogic.Cards;
public abstract class Card
{
    public string Name { get; }
    public string Description { get; }
    public string Faction { get; }
    public Skill Skill { get; }

    public Card(string name, string description, string faction, Skill skill)
    {
        this.Name = name;
        this.Description = description;
        this.Faction = faction;
        this.Skill = skill;
    }

}
