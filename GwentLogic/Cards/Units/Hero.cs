namespace GwentLogic.Cards;

public class Hero : UnitCard
{
    public Hero(string name, string description, string faction, Skill skill, int power, AttackType type) :
        base(name, description, faction, skill,power, type){}
  
}