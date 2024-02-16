namespace GwentLogic;

public class Hand
{
    
    public ICollection<DeckCard> cards {get; set;}
    public int HandCount  => cards.Count;


    public void Draw(Deck deck, int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            this.cards.Add(deck.cards[0]);
            deck.cards.RemoveAt(0);
        }
    }
}