using GwentLogic.Cards;

namespace GwentLogic;


public class Graveyard
{
    public Graveyard(ICollection<Cards.DeckCard> cards)
    {
        this.GraveyardCards = cards;
    }
    public ICollection<Cards.DeckCard> GraveyardCards {get; set;}
}