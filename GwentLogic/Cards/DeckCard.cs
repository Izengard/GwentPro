namespace GwentLogic.Cards;

public abstract class DeckCard : Card
{
    public DeckCard(string name, string description, string faction, string skill) : 
        base(name, description, faction, skill){}
    
}
