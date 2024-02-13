namespace GwentLogic;

public abstract class FieldCard : Card
{
    public FieldCard(string name, string description, string faction, string skill) : 
        base(name, description, faction, skill){}

    protected abstract void Destroy();
    protected abstract void ReturnToHand();

    
}