namespace GwentLogic;


public enum Skills
{
    Decoy,
    Buff,
    Weather,
    Clearing
        SummonBuff,
    SummonWeather,
    Draw,
    DestroyRow,
    DestroyLesserUnit,
    DestroyGreaterUnit,
    MultiplyPower,
    BalanceFieldPower
}

Dictionary<Skills, string> unitsSkillDescription = new Dictionary<UnitSkill, string>()
    {
        {Skills.SummonBuff, "Summon a SummonBuff card to an own row"},
        {Skills.SummonWeather, "Summon a SummonWeather card"},
        {Skills.Draw, "Draw one card from Deck"},
        {Skills.DestroyLesserUnit, "Destroy the adversary unit with the lowest Power"},
        {Skills.DestroyGreaterUnit, "Destroy the adversary unit with the highest Power"},
        {Skills.DestroyRow,"Determine the Average Power among all units in the field(own or rival),"
                             +"then equalize all units(own or rival) Power to that value"},
        {Skills.Buff, "Duplicate the Power of all the units in this row"},
        {Skills.Weather, "Set to 1 the Power of all the units in boths"
                        +"rows (own and rival) of the type stated by this card"},
        {Skills.Clearing, "Destroy all weathers in the Board"},
        {Skills.Decoy, "Swap this card by one unit on your field and return that unit to your hand"}
    };




public class Skill
{

    public string SkillDescription { get; set; }

    public Skill(UnitSkill skill)
    {

    }
}
   