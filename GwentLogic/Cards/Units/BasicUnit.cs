namespace GwentLogic.Cards;

public class Unit : UnitCard
{
    private int _powerModifier = 0;
    public Unit(string name, string description, string faction, Skill skill, int power, AttackType type) :
        base(name, description, faction, skill,power,type){}

    public int Power {get => Power + _powerModifier;}

    public int GetPowerModifier(int modifier)
    {
        _powerModifier = modifier;
    }

    

}