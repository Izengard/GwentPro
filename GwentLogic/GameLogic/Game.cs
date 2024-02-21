namespace GwentLogic;

// Following an abstraction a game is a set rules and items to play with
public class Game
{
    public GameBoard GameBoard {get; set;}
    public Player Player1 {get; set;}
    public Player Player2 {get; set;}
    public Judge Judge {get; set;}

    public Game(PlayerInfo Player1Info, PlayerInfo Player2Info)
    {
        this.GameBoard = new GameBoard();
        this.Judge = new Judge();
        this.Player1 = new Player(Player1Info.Nick);
        this.Player2 = new Player(Player2Info.Nick);
                
        StartGame(Player1Info, Player2Info);

        while (false)
            new Round();

        EndGame();
    }

    void StartGame(PlayerInfo Player1Info, PlayerInfo Player2Info)
    {
        // Set Leaders and Decks in the GameBoard
        GameBoard.Player1Field.Leader = Player1Info.Leader;
        GameBoard.Player1Field.Deck = Player1Info.Deck;
        GameBoard.Player2Field.Leader = Player1Info.Leader;
        GameBoard.Player2Field.Deck = Player1Info.Deck;
                
        SetHands();

        void SetHands() { }

    }

    void EndGame() { }

}



