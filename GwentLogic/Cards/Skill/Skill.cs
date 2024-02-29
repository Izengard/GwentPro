using System;

namespace GwentLogic.Cards.Skill;

public enum Skills
{
    weather,
    buff,
    Decoy,
    Clearing,
    SummonBuff,
    SummonWeather,
    Draw,
    DestroyLesserRow,
    DestroyLesserUnit,
    DestroyGreaterUnit,
    MultiplyPower,
    BalanceFieldPower
}

public enum UnitSkill
{
    SummonBuff,
    SummonWeather,
    Draw,
    DestroyRow,
    DestroyLesserUnit,
    DestroyGreaterUnit,
    MultiplyPower,
    BalanceFieldPower,
    Decoy
}

public class Skill
{
    public static Dictionary<UnitSkill, Skills> unitSkills = new Dictionary<UnitSkill, Skills>
    {
        {UnitSkill.SummonBuff, Skills.SummonBuff},  
        {UnitSkill.SummonWeather, Skills.SummonWeather},
        {UnitSkill.Draw, Skills.Draw},
        {UnitSkill.DestroyRow, Skills.DestroyLesserRow},
        {UnitSkill.DestroyLesserUnit, Skills.DestroyLesserUnit},
        {UnitSkill.DestroyGreaterUnit, Skills.DestroyGreaterUnit},
        {UnitSkill.MultiplyPower, Skills.MultiplyPower},
        {UnitSkill.BalanceFieldPower, Skills.BalanceFieldPower}
    };




    public static Dictionary<Skills, string> unitsSkillDescription = new Dictionary<Skills, string>()
    {
        {Skills.SummonBuff, "Summon a SummonBuff card to an own row"},
        {Skills.SummonWeather, "Summon a SummonWeather card"},
        {Skills.Draw, "Draw one card from Deck"},
        {Skills.DestroyLesserUnit, "Destroy the adversary unit with the lowest Power"},
        {Skills.DestroyGreaterUnit, "Destroy the adversary unit with the highest Power"},
        {Skills.BalanceFieldPower,"Determine the Average Power among all units in the field(own or rival),"
                             +"then equalize all units(own or rival) Power to that value"},
        {Skills.DestroyRow, "Destroy all units on the adversary the designed adversary row"},
        {Skills.MultiplyPower, "Multiply this unit Power by n, being n the number of units in the "
                                +"own field equals to this card"},
        {Skills.Buff, "Duplicate the Power of all the units in this row"},
        {Skills.Weather, "Set to 1 the Power of all the units in both"
                        +"rows (own and rival) of the type stated by this card"},
        {Skills.Clearing, "Destroy all weathers in the Board"},
        {Skills.Decoy, "Swap this card by one unit on your field and return that unit to your hand"}
    };
}
