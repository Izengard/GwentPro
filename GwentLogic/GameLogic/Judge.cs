using System.ComponentModel.DataAnnotations;

namespace GwentLogic;

// The judge validates and executes the plays 
// In order to do this he needs to know the players, players' hands
//
public class Judge
{
    public Judge()
    {
        this.Validator = new Validator();
        this.Executioner = new Executioner();

    }

    public Validator Validator { get; set; }
    public Executioner Executioner { get; set; }

}


// The Validator Validates the possible Plays
public class Validator
{

}

public class Executioner
{
    
}