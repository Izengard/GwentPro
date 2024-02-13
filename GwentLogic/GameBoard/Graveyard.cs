namespace GwentLogic;


public class Graveyard
{
    public Graveyard(ICollection<FieldCard> cards)
    {
        this.GraveyardCards = cards;
    }
    public ICollection<FieldCard> GraveyardCards {get; set;}
}