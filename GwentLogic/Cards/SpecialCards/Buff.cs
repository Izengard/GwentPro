namespace GwentLogic;

public abstract class Buff : SpecialCard
{
    public Buff (string name, string description, string faction, Skill skill,AttackType type) :
    base(name, description, faction, skill){
        this.Type = type;
    }


    AttackType Type {get; set;}
}   
