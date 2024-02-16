namespace GwentLogic;


public class Graveyard
{
    public Graveyard(ICollection<DeckCard> cards)
    {
        this.GraveyardCards = cards;
    }
    public ICollection<DeckCard> GraveyardCards {get; set;}
}