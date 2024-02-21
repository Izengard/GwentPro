using System;
namespace GwentLogic;

public class Deck : ICloneable
{
    public Deck(IList<DeckCard> cards)
    {
        this.Cards = cards;
    }
        
    public IList<DeckCard> Cards {get;}

    public object Clone()
    {
        var clone = new Deck(this.Cards);
        return clone;
    }
}