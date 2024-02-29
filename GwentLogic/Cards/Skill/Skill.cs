using System;

namespace GwentLogic.Cards.Skill;

public enum Skills
{
    Weather,
    Buff,
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
    public static Dictionary<string, string> SkillEffectsDescription = new Dictionary<string, string>()
    {
        {"SummonBuff",         "Summon a SummonBuff card from the hand to the field"},
        {"SummonWeather",      "Summon a SummonWeather card from the player's hand"},
        {"Draw",               "The player draws one card from Deck"},
        {"DestroyLesserUnit",  "Destroy the adversary unit with the lowest Power"},
        {"DestroyGreaterUnit", "Destroy the unit in the whole Battlefield with the highest Power"},
        {"BalanceFieldPower",  "Determine the Average Power among all units in the Battlefield,"
                                +"then equalize all units Power to that value"},
        {"DestroyLesserRow",   "Destroy all units on the row of the Battlefield with less units"},
        {"MultiplyPower",      "Multiply this unit Power by n, being n the number of units in the "
                             +"own field equals to this card"},
        {"Buff",               "Duplicate the Power of all the units in this row"},
        {"Weather",            "Set to 1 the Power of all the units in both"
                             +"rows (own and rival) of the type stated by this card"},
        {"Clearing",           "Destroy all weathers in the Board"},
        {"Decoy",              "Swap this card by one unit on your field and return that unit to your hand"}
    };
}
