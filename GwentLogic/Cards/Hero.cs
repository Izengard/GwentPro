namespace GwentLogic;

public class Hero : FieldCard
{
    public Hero(string name, string description, string faction, string skill, int power) :
        base(name, description, faction, skill)
    {
        this.Power = power;
    }
    public int Power {get; set}
}