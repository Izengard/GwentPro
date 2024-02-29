using System;
using GwentLogic.Cards;

namespace GwentLogic.GameBoard;

public class Deck
{
    DeckCard[] _cards;
    public int Count{get; private set;}

    public Deck(IList<DeckCard> cards)
    {
        if(cards.Count > 30)
            throw new Exception("Deck may only contains 30 cards");
        this._cards = cards.ToArray<DeckCard>();
        this.Count = 30;
    }
    public DeckCard Draw()
    {
        if(Count == 0) 
            throw new Exception("Deck is already empty");
        return _cards[Count--];
    }

    
}