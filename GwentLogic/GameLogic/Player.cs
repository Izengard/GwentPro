using System;
namespace GwentLogic;


// The Player makes a Move. In order to play, the player needs a Hand
public class Player
{
    public Player(string Nick)
    {
        this.Nick = Nick;
        this.Hand = new Hand();
    }

    public Move Play()
    {
        throw new NotImplementedException();
    }

    public string Nick { get; private set; }
    public Hand Hand { get; set; }

}

public class PlayerInfo
{
    Deck _deck;
    public PlayerInfo(string nick, Leader leader, Deck playerDeck)
    {
        this.Leader = leader;
        this.Nick = nick;
        this._deck = playerDeck;
    }
    public readonly string Nick;
    public readonly Leader Leader;
    public Deck Deck => (Deck)_deck.Clone();
    
}