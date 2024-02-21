namespace GwentLogic.Cards;

public abstract class DeckCard : Card
{
    public DeckCard(string name, string description, string faction, Skill skill) : 
        base(name, description, faction, skill){}

    public void Destroy(){}
    public void ReturnToHand(){}
 
}
public enum AttackType
{
    Melee,
    Ranged,
    Siege
}