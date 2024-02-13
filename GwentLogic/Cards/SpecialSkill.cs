namespace GwentLogic;

public class Skill
{
    
    public string SkillDescription{get; set;}
    
    public Skill(SkillEffects skill)
    {

    }
    
    Dictionary<SkillEffects, string> skillDescription = new Dictionary<SkillEffects, string>()
    {
        {SkillEffects.Buff, "Summon a Buff card to an own row"},
        {SkillEffects.Weather, "Summon a Weather card"},
        {SkillEffects.Draw, "Draw one card from Deck"},
        {SkillEffects.DestroyLesserUnit, "Destroy the adversary unit with the lowest Power"},
        {SkillEffects.DestroyGreaterUnit, "Destroy the adversary unit with the highest Power"},
        {SkillEffects.DestroyRow,"Determine the Average Power among all units in the field(own or rival),"
                                +"then equalize all units(own or rival) Power to that value"}
    };
    
    public enum SkillEffects{
        Buff,
        Weather,
        Draw,
        DestroyRow,
        DestroyLesserUnit,
        DestroyGreaterUnit,
        MultiplyPower,
        BalanceFieldPower
    }
    
    

   

}