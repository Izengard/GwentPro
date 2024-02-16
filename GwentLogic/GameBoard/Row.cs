namespace GwentLogic;

public class Row
{
    // Constructor
    public Row(AttackType type)
    {
        this.Type = type;
    }

    //Atributes
    AttackType Type { get; set; }
    public ICollection<UnitCard> Units { get; set; }
    public Buff Buff { get; set; }
    public bool ActiveWeather { get; set; }
    public int PowerSubtotal
    {
        get
        {
            var subtotal = 0;
            foreach (var unit in Units)
                subtotal += unit.Power;
            return subtotal;
        }
    }

    // Methods
    public void DestroyRow()
    {
        foreach (var unit in Units)
            unit.Destroy();
    }



}

