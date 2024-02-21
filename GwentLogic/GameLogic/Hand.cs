namespace GwentLogic;

public class Hand
{
    public ICollection<DeckCard> cards { get; set; }
    public int HandCount => cards.Count;
}