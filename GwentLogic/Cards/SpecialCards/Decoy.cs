namespace GwentLogic;

public abstract class Decoy : SpecialCard
{
    public Decoy(string name, string description, string faction, Skill skill) :
    base(name, description, faction, skill){ }

    public int Power => 0;
}
