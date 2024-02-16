using System;
using System.Collections.Generic;

namespace GwentLogic;
public class Turn
{
    public Turn(TurnAction action)
    {
        if(action == TurnAction.PlayCard)
        {

        }

        else if (action == TurnAction.ActivateLeaderSkill)
        {

        }
        else PassTurn();
    }

    void PassTurn(){}


}

public enum TurnAction
{
    PlayCard,
    ActivateLeaderSkill,
    Pass
}
    
