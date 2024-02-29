using GwentLogic.Cards;

namespace GwentLogic;



public class Hand
{
    public DeckCard[] cards;
    public int Count {get; private set;}

    public Hand()
    {
        cards = new DeckCard[14];
        Count = 0;
    }

    public void Draw(DeckCard card)
    {
        if ( Count == 14) throw new Exception("Hand is full");
        cards[Count++] = card;
    }
} 