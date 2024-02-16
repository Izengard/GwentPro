namespace GwentLogic;


public class Field
{
    public Field()
    {

    }

    public Leader Leader { get; set; }
    public Deck Deck {get; set;}
    public Graveyard Graveyard {get; set;}
    public Row MeleeRow { get; set; }
    public Row RangedRow { get; set; }
    public Row SiegeRow { get; set; }
    public int TotalPower {get; set;}


}