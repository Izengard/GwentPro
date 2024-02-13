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
    public Buff Buff {get; set;}

    // Methods
    public void DestroyRow()
    { 
        foreach (var unit in Units) 
            unit.Destroy();
    }



}

