namespace GwentLogic.GameBoard;

public class GameBoard
{
    public Field Player1Field {get; set;}
    public Field Player2Field {get; set;}

    public Weather MeleeWeather {get; set;}
    public Weather RangedWeather {get; set;}
    public Weather SiegeWeather {get; set;}
}