namespace GwentLogic;

public class GameBoard
{
    public Field PlayerFiled {get; set;}
    public Field Player2Field {get; set;}

    public Weather MeleeWather {get; set;}
    public Weather RangedWeather {get; set;}
    public Weather SiegeWather {get; set;}
}