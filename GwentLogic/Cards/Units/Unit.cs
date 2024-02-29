namespace GwentLogic.Cards;

public class Unit : UnitCard
{
    private int powerModifier = 0;
    public Unit(string name, string description, string faction,  int power, AttackType[] atkTypes) :
        base(name, description, faction, power,type){}

    public int Power {get => Power * powerModifier;}
    public void SetPowerModifier(int modifier)
    {
        powerModifier = modifier;
    }

    

}