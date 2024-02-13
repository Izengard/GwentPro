namespace GwentLogic;
public abstract class Card
{
    public string Name {get; set;}
    public string Description {get; set;}
    public string Faction {get; set;}
    public Skill Skill{get; set;}

    public Card(string name, string description, string faction, Skill skill)
    {
        this.Name = name;
        this.Description = description;
        this.Faction = faction;
        this.Skill = skill;
    }
    
}  
