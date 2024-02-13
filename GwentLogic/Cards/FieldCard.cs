namespace GwentLogic;

public abstract class FieldCard : Card
{
    public FieldCard(string name, string description, string faction, Skill skill) : 
        base(name, description, faction, skill){}

    public abstract void Destroy();
    public abstract void ReturnToHand();

    
}