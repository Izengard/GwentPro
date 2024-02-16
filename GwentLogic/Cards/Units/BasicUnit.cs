namespace GwentLogic;

public class Unit : UnitCard
{
    public Unit(string name, string description, string faction, Skill skill, int power, AttackType type) :
        base(name, description, faction, skill,power,type){}

}