namespace GwentLogic.Cards.SpecialCards;

public abstract class SpecialCard : DeckCard
{
    public SpecialCard(string name, string description, string faction,string skill) :
    base(name, description, faction,skill){ }
}

