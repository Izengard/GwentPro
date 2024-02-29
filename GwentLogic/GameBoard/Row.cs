using GwentLogic.Cards;
namespace GwentLogic;

public class Row
{
    // Constructor
    UnitCard[] cards = new UnitCard[10];
    public int UnitsCount { get; private set; }
    public Row(AttackType type)
    {
        this.Type = type;
    }

    AttackType Type { get; }
    public Buff Buff { get; private set; }
    public int PowerSubtotal
    {
        get
        {
            var subtotal = 0;
            for (int i = 0; i < UnitsCount; i++)
                subtotal += cards[i].Power;

            return subtotal;
        }
    }

    public void Summon(UnitCard unit)
    {
        this.cards[UnitsCount++] = unit;
    }
    public void SetBuff(Buff buff)
    {
        this.Buff = buff;
        for (int i = 0; i < UnitsCount; i++)
            if (cards[i] is Unit) 
}







}

