namespace GwentLogic;

public class Skill
{

    public string SkillDescription { get; set; }
    
    public Skill(UnitSkill skill)
    {

    }

    Dictionary<UnitSkill, string> unitsSkillDescription = new Dictionary<UnitSkill, string>()
    {
        {UnitSkill.SummonBuff, "Summon a SummonBuff card to an own row"},
        {UnitSkill.SummonWeather, "Summon a SummonWeather card"},
        {UnitSkill.Draw, "Draw one card from Deck"},
        {UnitSkill.DestroyLesserUnit, "Destroy the adversary unit with the lowest Power"},
        {UnitSkill.DestroyGreaterUnit, "Destroy the adversary unit with the highest Power"},
        {UnitSkill.DestroyRow,"Determine the Average Power among all units in the field(own or rival),"
                             +"then equalize all units(own or rival) Power to that value"}
    };

    Dictionary<SpecialSkill, string> specialSkillDescription = new Dictionary<SpecialSkill, string>()
    {
        {SpecialSkill.Buff, "Duplicate the Power of all the units in this row"},
        {SpecialSkill.Weather, "Set to 1 the Power of all the units in both"
                            +"rows (own and rival) of the type stated by this card"},
        {SpecialSkill.Clearing, "Destroy all weathers in the Board"},
        {SpecialSkill.Decoy, "Swap this card by one unit on your field and return that unit to your hand"}
        };

    public enum UnitSkill
    {
        SummonBuff,
        SummonWeather,
        Draw,
        DestroyRow,
        DestroyLesserUnit,
        DestroyGreaterUnit,
        MultiplyPower,
        BalanceFieldPower
    }

    public enum SpecialSkill
    {
        Decoy,
        Buff,
        Weather,
        Clearing
    }





}