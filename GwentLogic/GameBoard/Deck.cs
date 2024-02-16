namespace GwentLogic;

public class Deck
{
    public Deck(IList<DeckCard> cards)
    {
        this.cards = cards;
    }
    public IList<DeckCard> cards {get; set;}
}