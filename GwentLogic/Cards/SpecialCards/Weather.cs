namespace GwentLogic;

public abstract class Weather :SpecialCard
{
    public Weather(string name, string description, string faction, Skill skill, AttackType type) :
    base(name, description, faction, skill){ this.Type = type;}

    public AttackType Type {get; set;}

}
