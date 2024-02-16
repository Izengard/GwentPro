namespace GwentLogic;

public abstract class DeckCard : Card
{
    public DeckCard(string name, string description, string faction, Skill skill) : 
        base(name, description, faction, skill){}

    public void Destroy(){}
    public void ReturnToHand(){}

    
}