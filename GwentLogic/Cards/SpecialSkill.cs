namespace GwentLogic;

public class SpecialSkill
{
    
    public string SkillDescription{get; set;}
    
    public SpecialSkill(Skills skill)
    {
        ActivateSkill(skill);
    }
    enum Skills{
        Buff;
        Weather;
        Draw;
        DestroyRow;
        DestroyLesserUnit;
        DestroyGreaterUnit;
        MultiplyPower;
        BalanceFieldPower;
    }
    
    var _skillDescription = new Dictionary<Skills, string>{
        Skills.Buff = "",
        Skills.Weather = "",
        Skills.Draw = "",
        Skills.DestroyLesserUnit = "",
        Skills.DestroyGreaterUnit = "",
        Skills.DestroyRow = "",
        Skills.MultiplyPower = "",
        Skills.BalanceFieldPower = "",
       
    }

   

}