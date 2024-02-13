namespace GwentLogic;


public class Deck
{
    public Deck(IList<FieldCard> cards)
    {
        this.DeckCards = cards;
    }
    public IList<FieldCard> DeckCards {get; set;}
}