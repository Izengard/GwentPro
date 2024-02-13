namespace GwentLogic;

public class Unit : FieldCard
{
    public Unit(string name, string description, string faction, string skill, int power) :
        base(name, description, faction, skill)
    {
        this.Power = power;
    }

    public int Power { get; set; }
    private void ModifyPower(int value, Operation op)
    {
        switch (Op)
        {
            case 0:
                Power += value;
                vreak;
            case 1:
                Power -= value;
                break;
            case 2:
                Power *= value;
                vreak;
            case 3:
                Power = value;
                break;
        }
    }

    enum Operation
    { Increase, Reduce, Multiply, Set }
}